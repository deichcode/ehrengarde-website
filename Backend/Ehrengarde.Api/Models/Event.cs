using System;
using Ical.Net.CalendarComponents;

namespace Ehrengarde.Api.Models
{
    public class Event
    {
        public Event(){}
        public Event(CalendarEvent calendarEvent)
        {
            Uid = calendarEvent.Uid;
            Title = calendarEvent.Summary;
            Description = calendarEvent.Description?.Trim() ?? "";
            Start = calendarEvent.Start.Value;
            End = calendarEvent.End.Value;
            IsAllDay = calendarEvent.IsAllDay;
            Location = calendarEvent.Location ?? "";
        }

        public string Uid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool IsAllDay { get; set; }
        public string Location { get; set; }
    }
}