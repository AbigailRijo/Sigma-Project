using DataLayer.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Data.ViewModels
{
    public class BookingAvailability
    {
        public int? DraftBookingId { get; set; }
        //[ForeignKey("DraftBookingId")]
        public Booking DraftBooking { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public int? Nights { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }
        public IEnumerable<HotelAvailability> HotelsAvailability { get; set; }
        public TranferAvailability TranfersAvailability { get; set; }
    }
}
