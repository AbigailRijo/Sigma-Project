using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data;
using DataLayer.Data.Enums;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;

namespace BussinessLayer.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHotelService _hotelService;
        private readonly IRoomTypeService _roomTypeService;
        private readonly IRoomService _roomService;
        private readonly IGuestService _guestService;
        private readonly ITranferService _tranferService;

        public BookingService(ApplicationDbContext context, IHotelService hotelService,
            IRoomTypeService roomTypeService, IRoomService roomService, IGuestService guestService,
            ITranferService tranferService)
        {
            _context = context;
            _hotelService = hotelService;
            _roomTypeService = roomTypeService;
            _roomService = roomService;
            _guestService = guestService;
            _tranferService = tranferService;
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

        public async Task<Booking> Update(BookingSelection _bookingSelection)
        {
            DateTime _toDay = DateTime.Today;
            // update the booking hotel, rooms, transfer, status - pending

            Booking _draftBooking = await GetById((int)_bookingSelection.bookingForm.BookingId);

            Hotel _hotel = _bookingSelection.bookingForm.Hotel;

            List<Room> roomList = new List<Room>();

            foreach (var bookingFormRoom in _bookingSelection.bookingForm.Rooms)
            {
                Room _room = new Room
                {
                    Chindren = bookingFormRoom.Children,
                    Adults = bookingFormRoom.Adults,
                    ModifyedDate = _toDay
                };

                var _roomId = await _roomService.CreateRoom(_room);

                foreach (var guestRoomBookingForm in bookingFormRoom.Guests)
                {
                    await _guestService.Create(new Guest
                    {
                        Age = guestRoomBookingForm.Age,
                        Name = guestRoomBookingForm.Name,
                        AgeQualifying = (int) (guestRoomBookingForm.Age > 17
                            ? AgeQualifying.Adult
                            : AgeQualifying.Children),
                        Status = (int) Status.Pendig,
                        RoomId = _roomId,
                        ModifyedDate = _toDay
                    });
                }

                roomList.Add(_room);


                if (_draftBooking != null)
                {
                    _draftBooking.HotelId = 1;

                    //Calculate price
                }
            }

            return _draftBooking;
        }
    }
}
