using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ehrengarde.Api.Adapters.ical.net.Calendar;
using Ehrengarde.Api.Models;
using Ehrengarde.Api.Services.Calendar;
using Ehrengarde.Api.Services.HttpService;
using FluentAssertions;
using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Moq;
using Xunit;

namespace Ehrengarde.Api.Tests.Services
{
    public class CalendarServiceTests
    {
        private const string ICalString = "BEGIN:VCALENDAR";
        private readonly ICalendarService _sut;
        private readonly Mock<IHttpService> _httpClient;
        private readonly Mock<ICalendarAdapter> _calendarAdapter;
        private Calendar _calendar;

        private CalendarServiceTests()
        {
            _calendar = new Calendar
            {
                Events =
                {
                    new CalendarEvent
                    {
                        Uid = new Guid().ToString(),
                        Name = "Some Event",
                        Start = new CalDateTime(2019, 1, 1),
                        End = new CalDateTime(2020, 1, 1),
                        IsAllDay = true,
                        Location = "Neuwied",
                        Description = "This event is going to be awesome!"
                    },
                    new CalendarEvent
                    {
                        Uid = new Guid().ToString(),
                        Name = "Another Event",
                        Start = new CalDateTime(2019, 1, 15, 8, 10, 0),
                        End = new CalDateTime(2020, 1, 15, 18, 0, 0),
                        IsAllDay = false,
                        Location = "Koblenz",
                        Description = "\n"
                    }
                }
            };

            _httpClient = new Mock<IHttpService>();
            _calendarAdapter = new Mock<ICalendarAdapter>();
            _sut = new CalendarService(_httpClient.Object, _calendarAdapter.Object);

            _httpClient.Setup(hc => hc.GetStringAsync(It.IsAny<string>())).ReturnsAsync(ICalString);
            _calendarAdapter.Setup(ca => ca.Load(It.IsAny<string>())).Returns(new Calendar());
        }

        public class GetPublicEvents : CalendarServiceTests
        {
            [Fact]
            public async Task ShouldCallHttpClientWithCalendarAddress()
            {
                await _sut.GetPublicEvents();

                _httpClient.Verify(hc => hc.GetStringAsync(It.Is<string>(s => s.EndsWith(".ics"))));
            }

            [Fact]
            public async Task ShouldMapCalendarEvents()
            {
                const string iCalString = "BEGIN:VCALENDAR";
                _httpClient.Setup(hc => hc.GetStringAsync(It.IsAny<string>())).ReturnsAsync(iCalString);
                _calendarAdapter.Setup(ca => ca.Load(iCalString)).Returns(_calendar);

                var result = await _sut.GetPublicEvents();

                result.First().Uid.Should().Be(_calendar.Events.First().Uid);
                result.First().Title.Should().Be(_calendar.Events.First().Summary);
                result.First().Description.Should().Be(_calendar.Events.First().Description);
                result.First().Start.Should().Be(_calendar.Events.First().Start.Value);
                result.First().End.Should().Be(_calendar.Events.First().End.Value);
                result.First().IsAllDay.Should().Be(_calendar.Events.First().IsAllDay);
                result.First().Location.Should().Be(_calendar.Events.First().Location);

                result.Last().Uid.Should().Be(_calendar.Events.Last().Uid);
                result.Last().Title.Should().Be(_calendar.Events.Last().Summary);
                result.Last().Description.Should().Be("");
                result.Last().Start.Should().Be(_calendar.Events.Last().Start.Value);
                result.Last().End.Should().Be(_calendar.Events.Last().End.Value);
                result.Last().IsAllDay.Should().Be(_calendar.Events.Last().IsAllDay);
                result.Last().Location.Should().Be(_calendar.Events.Last().Location);
            }

            [Fact]
            public async Task ShouldSetNullStringsToEmptyString()
            {
                _calendar = new Calendar
                {
                    Events = { new CalendarEvent
                    {
                        Uid = new Guid().ToString(),
                        Name = "",
                        Start = new CalDateTime(2019, 1, 1),
                        End = new CalDateTime(2020, 1, 1),
                        IsAllDay = false,
                        Location = null,
                        Description = null
                    }}
                };
                _calendarAdapter.Setup(ca => ca.Load(ICalString)).Returns(_calendar);

                var result = await _sut.GetPublicEvents();

                result.First().Location.Should().Be(string.Empty);
                result.First().Description.Should().Be(string.Empty);
            }
        }
    }
}