using System.ComponentModel.DataAnnotations;

namespace DataLayer.Data.ViewModels
{
    public class GuestRoomBookingForm
    {
        public int? GuestId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int AgeQualifying { get; set; }
    }
}