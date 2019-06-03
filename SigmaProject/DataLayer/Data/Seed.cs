using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace DataLayer.Data
{
    public class Seed
    {
        public List<User> GetUserList()
        {
            List<User> _users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Username = "admin",
                    Password = EncryptedPassword.GetEncryptedPassword("2019@123!")
                }
            };

            return _users;
        }
    }
}
