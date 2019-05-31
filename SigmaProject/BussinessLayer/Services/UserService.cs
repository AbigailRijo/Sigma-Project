using BussinessLayer.Services.Contracts;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    public class UserService : IUserService
    {
        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
