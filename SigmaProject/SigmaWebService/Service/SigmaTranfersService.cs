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
        public TranferResponse GetTranfersAvailability(TranferRequest _tranferRequest)
        {

            //Since": "2019 - 06 - 03T00: 00:00Z",
            //"Until": "2019-06-17T00:00:00Z",
            //"Avails": [
            //{
            //    "AvailToken": "100d2fad4c5c2e588c21038aa3d9b747c08b1339",
            //    "OriginCode": "AIR123",
            //    "DestinationCode": "TR256",
            //    "MaxAdults": 2,
            //    "MaxChildren": 3,
            //    "RatePlanCode": "PREFER",
            //    "Taxes": 123.23,
            //    "Total": 232.42

            //},
            //{
            //    "AvailToken": "100d2fad4c5c2e588c54374aa3d9b747c08b1339",
            //    "OriginCode": "AIR123",
            //    "DestinationCode": "TR256",
            //    "MaxAdults": 2,
            //    "MaxChildren": 3,
            //    "RatePlanCode": "EXCLUSIVE",
            //    "Taxes": 76.23,
            //    "Total": 165.42
            //}

            return new TranferResponse
            {
                Since = Convert.ToDateTime("2019-06-03T00:00:00Z"),
                Until = Convert.ToDateTime("2019-06-17T00:00:00Z")
            };

        }
    }
}
