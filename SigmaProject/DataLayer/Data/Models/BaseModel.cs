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

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Modifyed Date")]
        public DateTime ModifyedDate { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(100)]
        [Display(Name = "Modifyed By User")]
        public string ModifyedByUser { get; set; }

        [StringLength(100)]
        [Display(Name = "Created by user")]
        public string CreatedByUser { get; set; }

        public BaseModel()
        {
            CreationDate = DateTime.Now;
            ModifyedDate = DateTime.Now;
        }
    }
}
