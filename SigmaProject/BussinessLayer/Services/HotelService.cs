using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;

namespace BussinessLayer.Services
{
    public class HotelService : IHotelService
    {
        public Task<bool> Create(Hotel EntityToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Hotel EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> Edit(Hotel EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
