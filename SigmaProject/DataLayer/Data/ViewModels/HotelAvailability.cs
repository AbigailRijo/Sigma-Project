using DataLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Data.ViewModels
{
    public class HotelAvailability
    {
        public int HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }
        public  IEnumerable<RoomAvailability> RoomsAvailability { get; set; }
    }
}
