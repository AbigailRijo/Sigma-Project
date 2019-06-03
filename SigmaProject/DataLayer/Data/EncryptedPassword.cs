using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Data
{
    public static class EncryptedPassword
    {
        public static string GetEncryptedPassword(string _pass)
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
