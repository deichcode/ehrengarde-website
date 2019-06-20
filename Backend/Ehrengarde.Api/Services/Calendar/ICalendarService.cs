using System.Collections.Generic;
using System.Threading.Tasks;
using Ehrengarde.Api.Models;

namespace Ehrengarde.Api.Services.Calendar
{
    public interface ICalendarService
    {
        Task<List<Event>> GetPublicEvents();
    }
}
