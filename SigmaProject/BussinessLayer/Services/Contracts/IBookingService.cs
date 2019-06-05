using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data.Models;
using DataLayer.Data.ViewModels;

namespace BussinessLayer.Services.Contracts
{
    public interface IBookingService :IBaseService<Booking>
    {
        Task<Booking> Update(BookingSelection _bookingSelection);
    }
}
