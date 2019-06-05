using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SigmaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailbilityController : ControllerBase
    {
        private readonly IAvailabilityService _availabilityService;
        public AvailbilityController(IAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }

        [HttpGet("GetAvail")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Getavailability( BookingForm _draftBookingForm)
        {
            if (ModelState.IsValid)
            {
                //search availability in the web service
                using (var client = new HttpClient())
                {
                    //create the draftbooking


                    //create drafbooking
                    //if (await _availabilityService.CreateDraftBooking(_draftBookingForm))
                    //{
                    //    //add draftbooking to the booking disponibility view model

                    //    return Ok();
                    //}

                    System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "SigmaUser:Sigma@!!123");
                    var response = await client.PostAsXmlAsync(new Uri("http://localhost:57020/api/SigmaBookings/Avail"), _draftBookingForm);
                    var content = await response.Content.ReadAsAsync<BookingAvailability>();

                    //XmlSerializer serializer = new XmlSerializer(typeof(BookingAvailability));
                    //StringReader rdr = new StringReader(content);
                    //BookingAvailability _bookingAvailability = (BookingAvailability)serializer.Deserialize(rdr);

                    return Ok(content);
                }

                //booking disponibility view model

                
            }
            return BadRequest();
        }

    }
}