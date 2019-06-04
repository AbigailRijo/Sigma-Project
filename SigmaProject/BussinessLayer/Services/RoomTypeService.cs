using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;

namespace BussinessLayer.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        public Task<bool> Create(RoomType EntityToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(RoomType EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<RoomType> Edit(RoomType EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoomType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RoomType> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
