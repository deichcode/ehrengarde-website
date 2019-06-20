namespace Ehrengarde.Api.Adapters.ical.net.Calendar
{
    public class CalendarAdapter : ICalendarAdapter
    {
        public Ical.Net.Calendar Load(string iCalendarString)
        {
            return Ical.Net.Calendar.Load(iCalendarString);
        }
    }
}