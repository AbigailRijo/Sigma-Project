using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigmaWebService.Models;
using SigmaWebService.Service;
namespace SigmaWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/xml")]
    public class AuthController : ControllerBase
    {
        private IApiAuthService _authService;

        public AuthController(IApiAuthService authService)
        {
            _authService = authService;
        }
      
        [HttpGet("GET")]
        [Authorize]
        public async Task<IActionResult> Get([FromBody]User usr)
        {
            var user =  _authService.Authenticate(usr.UserName, usr.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

    }
}