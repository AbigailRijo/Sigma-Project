using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataLayer.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SigmaWebService.Service;

namespace SigmaWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/xml")]
    public class SigmaBookingsController : ControllerBase
    {
        private readonly ISigmaBookingService _sigmaBookingService;

        public SigmaBookingsController(ISigmaBookingService sigmaBookingService)
        {
            _sigmaBookingService = sigmaBookingService;
        }

        public IActionResult Getavailability([FromRoute] string _bookingForm)
        {
            //var booking = XElement.


            return Ok();//await _sigmaBookingService.Getavailability(_bookingForm));
        }
    }
}