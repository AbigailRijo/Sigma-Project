using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;

namespace BussinessLayer.Services
{
    public class GuestService : IGuestService
    {
        public Task<bool> Create(Guest EntityToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guest EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Guest> Edit(Guest EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Guest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Guest> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
