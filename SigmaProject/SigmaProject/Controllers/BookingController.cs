using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Services.Contracts;
using DataLayer.Data.Enums;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SigmaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("BookingSelection")]
        public async Task<IActionResult> BookingSelection(BookingSelection _bookingSelection)
        {


            await _bookingService.Update(_bookingSelection);

            //calculate the total taxes and total price to pay

            return Ok();
        }

        [HttpPost("FinishBooking")]
        public IActionResult FinishBooking(BookingForm _draftBookingForm)
        {
            //consumed the booking and give a new reservation number


            return Ok();
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking()
        {
            //consumed the booking and give a new reservation number


            return Ok();
        }
    }
}