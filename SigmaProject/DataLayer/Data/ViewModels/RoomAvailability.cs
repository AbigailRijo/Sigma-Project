using DataLayer.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Data.ViewModels
{
    public class RoomAvailability
    {
        public string AvailToken { get; set; }
        public int RoomTypeId { get; set; }
        [ForeignKey("RommTypeId")]
        public virtual RoomType RoomType { get; set; }
        public string RateCode { get; set; }
        public string Description { get; set; }
        public int QuantityAvailable { get; set; }
        public int Nights { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}