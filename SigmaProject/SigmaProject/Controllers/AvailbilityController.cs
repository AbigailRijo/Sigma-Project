using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Data.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SigmaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailbilityController : ControllerBase
    {
        [HttpGet("GetAvail")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Getavailability(BookingForm reservation)
        {
            if (ModelState.IsValid)
            {

            }
            return Ok();
        }

    }
}