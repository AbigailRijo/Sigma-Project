using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLayer.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> Login(User _user);
    }
}
