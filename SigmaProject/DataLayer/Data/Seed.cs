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
                    Password = GetEncryptedPassword("2019@123!")
                }
            };

            return _users;
        }

        public string GetEncryptedPassword(string _pass)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: _pass,
                salt: new byte[128 / 8],
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }
    }
}
