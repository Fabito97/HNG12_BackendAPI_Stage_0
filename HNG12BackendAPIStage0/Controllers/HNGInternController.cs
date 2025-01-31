﻿using Microsoft.AspNetCore.Http;
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
            var response = new 
            {
                email = "fabbenco97@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                github_url = "https://github.com/Fabito97/HNG12_BackendAPI_Stage_0",
            };

            return Ok(response);
        }
    }
}
