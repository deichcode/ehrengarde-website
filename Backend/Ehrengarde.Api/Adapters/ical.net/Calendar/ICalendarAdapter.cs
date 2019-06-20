namespace Ehrengarde.Api.Adapters.ical.net.Calendar
{
    public interface ICalendarAdapter
    {
        Ical.Net.Calendar Load(string iCalendarString);
    }
}