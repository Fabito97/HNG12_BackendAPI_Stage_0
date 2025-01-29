using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG12BackendAPIStage0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGInternController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var info = new
            {
                Email = "fabbenco97@gmail.com",
                CurrentDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH-mm-ssZ"),
                GithubURL = "http://github.com/fabito97",
            };

            return Ok(info);
        }
    }
}
