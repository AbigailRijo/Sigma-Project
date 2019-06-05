using SigmaWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SigmaWebService.Service
{
    public interface IApiAuthService
    {
        User Authenticate(string username, string password); 
    }
    public class ApiAuthService : IApiAuthService
    {
        private List<User> users = new List<User>
        {
            new User {UserName="SigmaUser",Password="Sigma@!!123"}
        };
        public User Authenticate(string username, string password)
        {
            var usr =users.SingleOrDefault(x => x.UserName.Equals(username) && x.Password.Equals(password));

            if(usr != null)
            {
                usr.Password = null;
                return usr;
            }
            return null;
        }
    }
}
