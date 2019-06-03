using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Data.ViewModels
{
    public class TranferAvailabilityForm
    {
        public string AvailTranfer { get; set; }
        [Required]
        public string OringinType { get; set; }
        [Required]
        public int DestinationType { get; set; }
    }
}
