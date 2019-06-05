using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SigmaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BookingController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private readonly IGuestService _guestService;
        private readonly ITranferService _tranferService;
        private readonly IBookingService _bookingService;

        public BookingController(IHotelService hotelService, IRoomTypeService roomTypeService, IRoomService roomService, IGuestService guestService, ITranferService tranferService, IBookingService bookingService)
        {
            _hotelService = hotelService;
            _roomTypeService = roomTypeService;
            _roomService = roomService;
            _guestService = guestService;
            _tranferService = tranferService;
            _bookingService = bookingService;
        }

        [HttpPost("Hola")]
        public async Task<IActionResult> Hola(BookingAvailability availability, BookingForm _bookingForm)
        {
            // update the booking hotel, rooms, transfer, status - pending
            Booking _draftBooking = await _bookingService.GetById((int)_bookingForm.BookingId);
            Hotel _hotel = _bookingForm.Hotel;

            List<Room> roomList = new List<Room>();

            foreach (var bookingFormRoom in _bookingForm.Rooms)
            {
                Room _room = new Room
                {
                    Chindren = bookingFormRoom.Children,
                    Adults = bookingFormRoom.Adults,
                    ModifyedDate = DateTime.Today
                };

                var _roomId = await _roomService.CreateRoom(_room);
                
                foreach (var guestRoomBookingForm in bookingFormRoom.Guests)
                {
                    await _guestService.Create(new Guest
                    {

                    });
                }
                
                roomList.Add(_room);
            }

            //calculate the total taxes and total price to pay

            return Ok();
        }

        [HttpPost("FinishBooking")]
        public async Task<IActionResult> FinishBooking(BookingForm _draftBookingForm)
        {
            //consumed the booking and give a new reservation number


            return Ok();
        }

        [HttpGet("GetBooking")]
        public async Task<IActionResult> GetBooking()
        {
            //consumed the booking and give a new reservation number


            return Ok();
        }
    }
}