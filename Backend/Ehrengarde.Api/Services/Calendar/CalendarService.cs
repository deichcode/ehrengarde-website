using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ehrengarde.Api.Adapters.ical.net.Calendar;
using Ehrengarde.Api.Models;
using Ehrengarde.Api.Services.HttpService;

namespace Ehrengarde.Api.Services.Calendar
{
    public class CalendarService : ICalendarService
    {
        private const string PublicCalendarAddress =
            "https://outlook.office365.com/owa/calendar/bb196fb875144a689a632f849a2a6049@ehrengarde-neuwied.de/31f5aac4f38a41c18820eb6753ce527b12029491783264037806/calendar.ics";

        private readonly IHttpService _httpService;
        private readonly ICalendarAdapter _calendarAdapter;

        public CalendarService(IHttpService httpService, ICalendarAdapter calendarAdapter)
        {
            _httpService = httpService;
            _calendarAdapter = calendarAdapter;
        }

        public async Task<List<Event>> GetPublicEvents()
        {
            var iCalString = await _httpService.GetStringAsync(PublicCalendarAddress);
            var calendar = _calendarAdapter.Load(iCalString);
            return calendar.Events.Select(e => new Event(e)).ToList();
        }
    }
}