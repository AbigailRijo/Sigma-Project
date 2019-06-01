using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLayer.Services.Contracts
{
    public interface IUserService :IBaseService<User>
    {
        Task<User> GetByUserNameAndPass(User _user);
    }
}
