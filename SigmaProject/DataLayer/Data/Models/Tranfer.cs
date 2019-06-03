using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Data.Models
{
    public class Tranfer : BaseModel
    {
        public string Code { get; set; }
        public string OriginCode { get; set; }
        public int OriginType { get; set; }
        public string DestinationCode { get; set; }
        public int DestinationType { get; set; }
        public int Status { get; set; }
    }
}
