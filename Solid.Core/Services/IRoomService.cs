using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IRoomService
    {
        IEnumerable<Room> GetRooms();

        Room GetById(int id);
        Task<Room> AddRoomAsync(Room room);

        Task<Room> UpdateRoomAsync(int id, Room room);

        Task DeleteRoomAsync(int id);
    }
}
