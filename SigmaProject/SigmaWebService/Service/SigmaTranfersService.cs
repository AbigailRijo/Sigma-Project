using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Data.ViewModels;
using SigmaWebService.Models;

namespace SigmaWebService.Service
{
    public interface ISigmaTranfersService
    {
        TranferResponse GetTranfersAvailability(TranferRequest _tranferRequest);
    }
    public class SigmaTranfersService : ISigmaTranfersService
    {
        public TranferResponse GetTranfersAvailability(TranferRequest _tranferRequest) => new TranferResponse
            {
                Since = _tranferRequest.Since,
                Until = _tranferRequest.Until,
                avails = new List<TranfersAvail>
                {
                    new TranfersAvail
                    {
                        AvailToken = "100d2fad4c5c2e588c54374aa3d9b747c08b1339",
                        OriginCode = "AIR123",
                        DestinationCode = "TR256",
                        MaxAdults = 2,
                        MaxChildren = 3,
                        RatePlanCode = "PREFER",
                        Taxes = 123.23m,
                        Total = 1232.42m
                    },
                    new TranfersAvail
                    {
                        AvailToken = "100d2fad4c5c2e588c54374aa3d9b747c08b1339",
                        OriginCode = "AIR123",
                        DestinationCode = "TR256",
                        MaxAdults = 2,
                        MaxChildren = 3,
                        RatePlanCode = "EXCLUSIVE",
                        Taxes = 76.23m,
                        Total = 165.42m
                    }
                }
            };
    }
}
