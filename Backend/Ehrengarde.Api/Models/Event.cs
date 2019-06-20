using System;
using Ical.Net.CalendarComponents;

namespace Ehrengarde.Api.Models
{
    public class Event
    {
        public Event(CalendarEvent calendarEvent)
        {
            Uid = calendarEvent.Uid;
            Title = calendarEvent.Summary;
            Description = calendarEvent.Description.Trim();
            Start = calendarEvent.Start.Value;
            End = calendarEvent.End.Value;
            IsAllDay = calendarEvent.IsAllDay;
            Location = calendarEvent.Location;
        }

        public string Uid { get; }
        public string Title { get; }
        public string Description { get; }
        public DateTime Start { get; }
        public DateTime End { get; }
        public bool IsAllDay { get; }
        public string Location { get; }
    }
}