using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class RoomService:IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public IEnumerable<Room> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public Room GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public async Task<Room> AddRoomAsync(Room room)
        {
            await _roomRepository.AddRoomAsync(room);
            return room;
        }

        public async Task<Room> UpdateRoomAsync(int id, Room room)
        {
            await _roomRepository.UpdateRoomAsync(id, room);
            return room;

        }
        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteRoomAsync(id);
        }
    }
}
