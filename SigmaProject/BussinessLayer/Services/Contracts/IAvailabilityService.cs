using DataLayer.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services.Contracts
{
    public interface IAvailabilityService
    {
        Task<bool> CreateDraftBooking(BookingForm _bookingForm);
        Task<bool> Update(BookingForm _bookingForm);
    }
}
