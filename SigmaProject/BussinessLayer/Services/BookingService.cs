using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;

namespace BussinessLayer.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;

        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Booking EntityToCreate)
        {
            await _context.Bookings.AddAsync(EntityToCreate);
            return _context.SaveChanges() > 0;
        }

        public Task<bool> Delete(Booking EntityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> Edit(Booking EntityToEdit)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
