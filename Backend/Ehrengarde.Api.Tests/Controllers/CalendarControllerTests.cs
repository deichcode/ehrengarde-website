using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Ehrengarde.Api.Controllers;
using Ehrengarde.Api.Models;
using Ehrengarde.Api.Services.Calendar;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Ehrengarde.Api.Tests.Controllers
{
    public class CalendarControllerTests
    {
        private readonly CalendarController _sut;
        private Mock<ICalendarService> _calendarService;

        public CalendarControllerTests()
        {
            _calendarService = new Mock<ICalendarService>();
            _sut = new CalendarController(_calendarService.Object);
        }

        [Fact]
        public void ShouldBeDecoratedWithRouteAttribute()
        {
            typeof(CalendarController).Should().BeDecoratedWith<RouteAttribute>(
                p => p.Template == "api/[controller]"
            );
        }

        public class GetPublic : CalendarControllerTests
        {
            private MethodInfo _method;
            public GetPublic()
            {
                _method = typeof(CalendarController).GetMethod(nameof(_sut.GetPublic));
            }
            [Fact]
            public void ShouldBeDecoratedWithGet()
            {
                _method.Should().BeDecoratedWith<HttpGetAttribute>();
            }
            
            [Fact]
            public async Task ShouldCallGetPublicOnCalendarService()
            {
                await _sut.GetPublic();

                _calendarService.Verify(s => s.GetPublicEvents(), Times.Once);
            }

            [Fact]
            public async Task ShouldReturnEventsFromService()
            {
                var serviceResult = new List<Event>();
                _calendarService.Setup(cs => cs.GetPublicEvents()).ReturnsAsync(serviceResult);
                
                var result = await _sut.GetPublic();

                result.Should().BeEquivalentTo(serviceResult);
            }
        }
    }
}