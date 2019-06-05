using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Getavailability(BookingForm _draftBookingForm)
        {
            if (ModelState.IsValid)
            {
                //search availability in the web service

                //booking disponibility view model

                //create the draftbooking
                

                //create drafbooking
                if (await _availabilityService.CreateDraftBooking(_draftBookingForm))
                {
                    //add draftbooking to the booking disponibility view model

                    return Ok();
                }
            }
            return BadRequest();
        }

    }
}