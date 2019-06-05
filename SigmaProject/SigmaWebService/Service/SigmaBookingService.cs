using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;

namespace SigmaWebService.Service
{
    public interface ISigmaBookingService
    {
        Task<BookingAvailability> Getavailability(BookingForm _bookingForm);
    }
    public class SigmaBookingService : ISigmaBookingService
    {
        public Task<BookingAvailability> Getavailability(BookingForm _bookingForm)
        {
           var Availability = new BookingAvailability
           {
               Since = _bookingForm.Since,
               Until = _bookingForm.Until,
               Adults = _bookingForm.Adults,
               Childrens = _bookingForm.Childrens,
               Nights = _bookingForm.Nights,
               DraftBookingId = (int)_bookingForm.BookingId,
               HotelsAvailability = new List<HotelAvailability>
               {
                   new HotelAvailability
                   {
                        HotelId = 1,
                        Hotel = new Hotel
                        {
                            Code = "PTY01",
                            ImageURL = "https://s-ec.bstatic.com/images/hotel/max1024x768/147/147997361.jpg",
                            Name = "Abby's Hotel"
                        },
                        RoomsAvailability = new List<RoomAvailability>
                        {
                            new RoomAvailability
                            {
                                AvailToken = "640ab2bae07bedc4c163f679a746f7ab7fb5d1fa",
                                RateCode = "FTR24",
                                Taxes = 104.55m,
                                Total = 155.22m,
                                QuantityAvailable = 5
                            },
                            new RoomAvailability
                            {
                                AvailToken = "6b3be50971208cd1dc86eaf4822ffdb6f082bac2",
                                RateCode = "FTR28",
                                Taxes = 157.5m,
                                Total = 200.22m,
                                QuantityAvailable = 3
                            }
                        }
                   }
               }
           };

           return Availability;
        }
    }
}
