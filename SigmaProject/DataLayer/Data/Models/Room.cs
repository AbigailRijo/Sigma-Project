using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataLayer.Data.Models
{
    public class Room : BaseModel
    {
        public int RoomTypeId { get; set; }
        [ForeignKey("RommTypeId")]
        public virtual RoomType RoomType { get; set; }
        public int BookingId { get; set; }
        [ForeignKey("BookingId")]
        public virtual Booking Booking { get; set; }
        public int Adults { get; set; }
        public int Chindren { get; set; }
        public int Status { get; set; }
        public IEnumerable<Guest> Guets { get; set; }
    }
}
