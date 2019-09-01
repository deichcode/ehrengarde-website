using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ehrengarde.Api.Models;

namespace Ehrengarde.Api.Services.Calendar
{
    public class FakeCalendarService : ICalendarService
    {
        public Task<List<Event>> GetPublicEvents()
        {
            return Task.FromResult(new List<Event>
            {
                new Event
                {
                    Title = "All Day Event",
                    Description = "Some very important Event",
                    Start = new DateTime(2019, 9, 28),
                    IsAllDay = true,
                    Location = "Neuwied"
                },
                new Event
                {
                    Title = "Event",
                    Start = new DateTime(2019, 9, 28, 18, 0, 0),
                    IsAllDay = false,
                    Location = "Neuwied"
                },
                new Event
                {
                    Title = "Event",
                    Start = new DateTime(2019, 9, 28, 18, 0, 0),
                    IsAllDay = false,
                    Location = "Neuwied"
                },
                new Event
                {
                    Title = "Event",
                    Start = new DateTime(2019, 9, 28, 18, 0, 0),
                    IsAllDay = false,
                    Location = "Neuwied"
                }
            });
        }
    }
}