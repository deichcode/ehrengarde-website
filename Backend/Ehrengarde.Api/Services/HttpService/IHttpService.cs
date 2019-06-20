using System.Threading.Tasks;

namespace Ehrengarde.Api.Services.HttpService
{
    public interface IHttpService
    {
        Task<string> GetStringAsync(string requestUri);
    }
}