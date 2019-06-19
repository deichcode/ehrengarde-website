using System.Reflection;
using Ehrengarde.Api.Controllers;
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
            public void ShouldCallGetPublicOnCalendarService()
            {
                _sut.GetPublic();

                _calendarService.Verify(s => s.GetPulbicCalendar(), Times.Once);
            }
        }
    }
}