using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Data.Models
{
    public class Guest : BaseModel
    {
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeQualifying { get; set; }
        public string AgeQualifyingDescription { get; set; }
        public int Status { get; set; } 

    }
}
