﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data;
using DataLayer.Data.Models;

namespace BussinessLayer.Services
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> Create(Room EntityToCreate)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateRoom(Room _entityToCreate)
        {
            _context.Add(_entityToCreate);
            await _context.SaveChangesAsync();

            return _entityToCreate.Id;
        }

        public Task<bool> Delete(Room EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Room> Edit(Room EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
