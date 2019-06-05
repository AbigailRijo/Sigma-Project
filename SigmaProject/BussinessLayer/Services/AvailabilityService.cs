using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Enums;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;

namespace BussinessLayer.Services
{
    public class AvailabilityService : IAvailabilityService
    {
        private readonly IBookingService _bookingService;

        public AvailabilityService(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task<bool> CreateDraftBooking(BookingForm _bookingForm)
        {
            Booking _draftBooking = new Booking
            {
                Until = _bookingForm.Until,
                Since = _bookingForm.Since,
                Adults = _bookingForm.Adults,
                Childrens = _bookingForm.Childrens,
                Nights = _bookingForm.Nights,
                Status = (int)Status.Draft
            };
            return await _bookingService.Create(_draftBooking);
        }

        public async Task<bool> Update(BookingForm _bookingForm)
        {
            throw new NotImplementedException();
        }
    }
}
