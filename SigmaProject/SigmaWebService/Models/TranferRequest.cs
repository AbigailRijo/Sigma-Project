using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigmaWebService.Models
{
    public class TranferRequest
    {
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        public TranferAvailCriterias AvailCriterias { get;set }
    }
}
