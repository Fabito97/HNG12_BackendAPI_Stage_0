using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace HNG12BackendAPIStage0.Controllers
{
    [Route("hngintern")]
    [ApiController]
    public class HNGInternController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var info = new
            {
                Email = "fabbenco97@gmail.com",
                CurrentDate = DateTime.UtcNow,
                GithubURL = "https://github.com/Fabito97/HNG12_BackendAPI_Stage_0",
            };

            return Ok(info);
        }
    }
}
