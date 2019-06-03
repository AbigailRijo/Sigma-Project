using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Data.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyedDate { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(100)]
        public string ModifyedByUser { get; set; }

        [StringLength(100)]
        public string CreatedByUser { get; set; }

        public BaseModel()
        {
            CreationDate = DateTime.Now;
        }
    }
}
