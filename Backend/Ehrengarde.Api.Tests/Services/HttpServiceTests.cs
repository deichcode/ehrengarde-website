using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Ehrengarde.Api.Adapters.HttpAdapter;
using Ehrengarde.Api.Exceptions;
using Ehrengarde.Api.Services.HttpService;
using FluentAssertions;
using Moq;
using Xunit;

namespace Ehrengarde.Api.Tests.Services
{
    public class HttpClientTests
    {
        private readonly IHttpService _sut;
        private readonly Mock<IHttpAdatper> _httpAdapter;
        private const string RequestUri = "https://some.uri";

        public HttpClientTests()
        {
            _httpAdapter = new Mock<IHttpAdatper>();
            SetupHttpAdapterGetAsync("", HttpStatusCode.OK);
            _sut = new HttpService(_httpAdapter.Object);
        }

        private void SetupHttpAdapterGetAsync(string responseString, HttpStatusCode httpStatusCode)
        {
            var responseMessage = new HttpResponseMessage
            {
                Content = new StringContent(responseString),
                StatusCode = httpStatusCode
            };
            _httpAdapter.Setup(a => a.GetAsync(RequestUri)).ReturnsAsync(responseMessage);
        }

        [Fact]
        public async Task ShouldCallIHttpAdapter()
        {
            await _sut.GetStringAsync(RequestUri);

            _httpAdapter.Verify(a => a.GetAsync(RequestUri), Times.Once);
        }

        [Fact]
        public async Task ShouldReturnResponseStringIfStatusIsOk()
        {
            const string responseString = "Response";
            SetupHttpAdapterGetAsync(responseString, HttpStatusCode.OK);

            var result = await _sut.GetStringAsync(RequestUri);

            result.Should().Be(responseString);
        }

        [Fact]
        public async Task ShouldThrowHttpServiceExceptionIfStatusIsNotOk()
        {
            SetupHttpAdapterGetAsync("", HttpStatusCode.InternalServerError);

            await Assert.ThrowsAsync<HttpServiceException>(() => _sut.GetStringAsync(RequestUri));
        }
    }
}