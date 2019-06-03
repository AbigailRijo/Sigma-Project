using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Data.Models
{
    public class Booking : BaseModel
    {
        public string Number { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public int HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }
        public int Nights { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }
        public int Status { get; set; }
        public string StatusDescription { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Tranfer> Tranfers { get; set; }
    }
}
