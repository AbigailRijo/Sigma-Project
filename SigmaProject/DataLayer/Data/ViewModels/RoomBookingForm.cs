using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Data.ViewModels
{
    public class RoomBookingForm
    {
        public string availToken { get; set; }
        public int? RoomTypeId { get; set; }
        [Required]
        public int Adults { get; set; }
        [Required]
        public int Children { get; set; }
        [Required]
        public IEnumerable<GuestRoomBookingForm> Guests { get; set; }
    }
}
