using System.Net.Http;
using System.Threading.Tasks;

namespace Ehrengarde.Api.Adapters.HttpAdapter
{
    public class HttpAdapter : IHttpAdatper
    {
        private readonly HttpClient _httpClient;
        public HttpAdapter()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Ehrengarde-Api/1.0.0");
        }
        
        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return _httpClient.GetAsync(requestUri);
        }
    }
}