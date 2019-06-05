using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigmaWebService.Models
{
    /// <summary>
    /// This user is only for handle 
    /// Authentication, Simulating the Ws that
    /// Sigma Provides. 
    /// </summary>
    public class User
    {
        public string UserName { get; set; }

        public string  Password { get; set; }
        
    }
}
