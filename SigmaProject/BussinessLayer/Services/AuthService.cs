using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data;
using DataLayer.Models;

namespace BussinessLayer.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;

        public AuthService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<bool> Login(User _user) => (await _userService.GetByUserNameAndPass(_user.Username, _user.Password)) != null;
    }
}
