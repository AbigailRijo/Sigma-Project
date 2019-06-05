using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data.Models;

namespace BussinessLayer.Services.Contracts
{
    public interface IRoomService : IBaseService<Room>
    {
        Task<int> CreateRoom(Room _entityToCreate);
    }
}
