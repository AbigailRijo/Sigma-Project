using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
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
        [HttpPost("Avail")]
        public IActionResult Getavailability([FromBody] BookingForm _bookingFormXML)
        {
            //var booking = XElement.
            //XmlSerializer serializer = new XmlSerializer(typeof(BookingForm));
            //StringReader rdr = new StringReader(_bookingFormXML);
            //BookingForm _bookingForm = (BookingForm)serializer.Deserialize(rdr);

            return Ok(_sigmaBookingService.Getavailability(_bookingFormXML));
        }
    }
}