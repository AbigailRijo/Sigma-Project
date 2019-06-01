using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Data.Models
{
    public class ApiSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
