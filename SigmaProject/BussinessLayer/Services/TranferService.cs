using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;

namespace BussinessLayer.Services
{
    public class TranferService : ITranferService
    {
        public Task<bool> Create(Tranfer EntityToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Tranfer EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Tranfer> Edit(Tranfer EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tranfer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Tranfer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
