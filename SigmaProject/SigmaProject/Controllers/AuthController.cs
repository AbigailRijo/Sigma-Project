using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;

namespace SigmaProject.Controllers
{
    [SwaggerTag("Controlador para la autorizacion")]
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ApiSettings _apiSettings;

        public AuthController(IAuthService authService, IOptions<ApiSettings> settingConfig)
        {
            _authService = authService;
            _apiSettings = settingConfig.Value;
        }

        [SwaggerOperation(Summary = "", Description = "")]
        [SwaggerResponse(201, "Retorna el token")]
        [SwaggerResponse(400, "Cuando el usuario no existe")]
        [HttpPost("login")]
        public async Task<IActionResult> Authorize()
        {
            var header = Request.Headers["Authorization"];
            if (header.ToString().StartsWith("Basic"))
            {
                var credentials = header.ToString().Substring("Basic ".Length).Trim();
                var encodeUserPass = Encoding.UTF8.GetString(Convert.FromBase64String(credentials));
                var userAndPass = encodeUserPass.Split(":");
                User _user = new User
                {
                    Username = userAndPass[0],
                    Password = userAndPass[1]
                };

                if (await _authService.Login(_user))
                {
                    return BuildToken(_user);
                }
            }

            return BadRequest("Error");
        }

        private IActionResult BuildToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_apiSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddMinutes(15);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _apiSettings.Issuer,
                audience: _apiSettings.Audience,
                expires: expiration,
                claims: claims,
                signingCredentials: creds);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}