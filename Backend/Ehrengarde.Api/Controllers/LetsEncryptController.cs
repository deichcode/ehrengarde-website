using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Ehrengarde.Api.Controllers
{
    [Route(".well-known/acme-challenge")]
    public class LetsEncryptController : Controller
    {
        [Route("{challenge}/{filename?}")]
        public IActionResult Index(string challenge, string filename = null)
        {
            var rootPath = Path.Combine(Directory.GetCurrentDirectory(), ".well-known", "acme-challenge");
            var challengeDirectory = Path.Combine(rootPath, challenge);
            var challengeFilename = Path.Combine(challengeDirectory, "index.html");
            return Ok(System.IO.File.ReadAllText(challengeFilename));
        }
    }
}