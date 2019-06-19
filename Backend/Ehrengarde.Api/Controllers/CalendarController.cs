using Ehrengarde.Api.Services.Calendar;
using Microsoft.AspNetCore.Mvc;

namespace Ehrengarde.Api.Controllers
{
    [Route("api/[controller]")]
    public class CalendarController
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpGet]
        public void GetPublic()
        {
            _calendarService.GetPulbicCalendar();
        }
    }
}