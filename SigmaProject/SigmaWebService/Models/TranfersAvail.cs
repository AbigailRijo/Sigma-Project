using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigmaWebService.Models
{
    public class TranfersAvail
    {

        public string AvailToken { get; set; }
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
        public string RatePlanCode { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}
