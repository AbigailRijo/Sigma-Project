using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigmaWebService.Models
{
    public class TranferAvailCriterias
    {
        public string OriginCode { get; set; }
        public string OriginType { get; set; }
        public string DestinationCode { get; set; }
        public string DestinationType { get; set; }
    }
}
