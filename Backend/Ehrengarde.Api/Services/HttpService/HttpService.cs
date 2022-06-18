using System.Threading.Tasks;
using Ehrengarde.Api.Adapters.HttpAdapter;
using Ehrengarde.Api.Exceptions;

namespace Ehrengarde.Api.Services.HttpService
{
    public class HttpService : IHttpService
    {
        private readonly IHttpAdatper _httpAdapter;

        public HttpService(IHttpAdatper httpAdapter)
        {
            _httpAdapter = httpAdapter;
        }

        public async Task<string> GetStringAsync(string requestUri)
        {
            var responseMessage = await _httpAdapter.GetAsync(requestUri);
            if(responseMessage.IsSuccessStatusCode)
            {
                return await responseMessage.Content.ReadAsStringAsync();
            }
            else {
                throw new HttpServiceException();
            }
        }
    }
}