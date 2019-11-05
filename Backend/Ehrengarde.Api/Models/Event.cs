using System;
using Ical.Net.CalendarComponents;

namespace Ehrengarde.Api.Models
{
    public class Event
    {
        public Event()
        {
        }

        public Event(CalendarEvent calendarEvent)
        {
            Uid = calendarEvent.Uid;
            Title = calendarEvent.Summary;
            Description = calendarEvent.Description?.Trim() ?? "";
            Start = calendarEvent.IsAllDay ? calendarEvent.Start.Date.ToString(MomentDateTimeFormat) : calendarEvent.Start.AsDateTimeOffset.ToString(MomentDateTimeFormat);
            End = calendarEvent.IsAllDay ? calendarEvent.End.Date.ToString(MomentDateTimeFormat) : calendarEvent.End.AsDateTimeOffset.ToString(MomentDateTimeFormat);
            IsAllDay = calendarEvent.IsAllDay;
            Location = calendarEvent.Location ?? "";
        }

        public const string MomentDateTimeFormat = "yyyy-MM-ddTHH:mm:sszzz";

        public string Uid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public bool IsAllDay { get; set; }
        public string Location { get; set; }
    }
}