using System.Collections.Generic;
using System.Threading.Tasks;
using Ehrengarde.Api.Models;
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
        public async Task<List<Event>> GetPublic()
        {
            return await _calendarService.GetPublicEvents();
        }
    }
}