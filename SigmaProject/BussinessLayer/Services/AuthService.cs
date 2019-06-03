using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data;
using DataLayer.Data.Models;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BussinessLayer.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly ApiSettings _apiSettings;

        public AuthService(ApplicationDbContext context, IOptions<ApiSettings> settingConfig)
        {
            _context = context;

            _apiSettings = settingConfig.Value;
        }

        public async Task<bool> Login(User _user) => (await _context.Users.FirstOrDefaultAsync(x => x.Username == _user.Username && x.Password == EncryptedPassword.GetEncryptedPassword(_user.Password)) != null);

        public string BuildToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_apiSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _apiSettings.Issuer,
                audience: _apiSettings.Audience,
                expires: DateTime.UtcNow.AddMinutes(40),
                claims: claims,
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
