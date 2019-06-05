using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigmaWebService.Models;
using SigmaWebService.Service;

namespace SigmaWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SigmaTranfersController : ControllerBase
    {
        private readonly ISigmaTranfersService _sigmaTranfersService;

        public SigmaTranfersController(ISigmaTranfersService sigmaTranfersService)
        {
            _sigmaTranfersService = sigmaTranfersService;
        }

        [HttpGet("GetTraferAvailability")]
        public IActionResult GetTraferAvailability([FromBody] TranferRequest _request) => Ok(_sigmaTranfersService.GetTranfersAvailability(_request));

    }
}