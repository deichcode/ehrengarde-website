using System.Net.Http;
using System.Threading.Tasks;

namespace Ehrengarde.Api.Adapters.HttpAdapter
{
    public interface IHttpAdatper
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }
}