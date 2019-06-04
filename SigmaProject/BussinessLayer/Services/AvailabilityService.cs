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
        private readonly IHotelService _hotelService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private readonly IGuestService _guestService;
        private readonly ITranferService _tranferService;
        private readonly IBookingService _bookingService;

        public AvailabilityService(IHotelService hotelService, IRoomTypeService roomTypeService, IRoomService roomService, IGuestService guestService, ITranferService tranferService, IBookingService bookingService)
        {
            _hotelService = hotelService;
            _roomTypeService = roomTypeService;
            _roomService = roomService;
            _guestService = guestService;
            _tranferService = tranferService;
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
