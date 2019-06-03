using DataLayer.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Data.ViewModels
{
    public class BookingForm
    {
        public int? BookingId { get; set; }
        [Required]
        public DateTime Since { get; set; }
        [Required]
        public DateTime Until { get; set; }
        public int? HotelId { get; set; }
        [Required]
        public int Nights { get; set; }
        [Required]
        public int Adults { get; set; }
        [Required]
        public int Childrens { get; set; }
        public int Status { get; set; }
        public IEnumerable<RoomBookingForm> Rooms { get; set; }
        public TranferAvailabilityForm Tranfer { get; set; }
        [Required]
        public bool IncludeReserveTransfer { get; set; }

        


    }
}
