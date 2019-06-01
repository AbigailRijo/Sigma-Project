using BussinessLayer.Services.Contracts;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace BussinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(User EntityToCreate)
        {
            _context.Users.Add(EntityToCreate);
           return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(User EntityToDelete)
        {
            _context.Users.Remove(EntityToDelete);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<User> Edit(User EntityToEdit)
        {
            _context.Users.Update(EntityToEdit);
            await _context.SaveChangesAsync();

            return EntityToEdit;
        }

        public async Task<IEnumerable<User>> GetAll() => await _context.Users.ToListAsync();

        public async Task<User> GetById(int id) => await _context.Users.FindAsync(id);

        public async Task<User> GetByUserNameAndPass(string _username, string _password) => await _context.Users
            .Where(x => x.Username == _username && x.Password == GetEncryptedPassword(_password)).FirstOrDefaultAsync();

        public string GetEncryptedPassword(string _pass)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: _pass,
                salt: new byte[128 / 8],
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }

        public async Task<bool> SoftDelete(int id)
        {
            var toDelete = await _context.Set<User>().FindAsync(id);
            if (toDelete != null)
            {
                toDelete.IsDeleted = true;
                _context.Set<User>().Update(toDelete);
            }
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
