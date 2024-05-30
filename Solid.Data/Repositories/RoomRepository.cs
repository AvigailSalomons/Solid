using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class RoomRepository:IRoomRepository
    {
        private readonly DataContext _context;
        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Room> GetRooms()
        {
            return _context.rooms;
        }
        public Room GetById(int id)
        {
            return _context.rooms.Find(id);
        }
        public async Task<Room> AddRoomAsync(Room room)
        {
            _context.rooms.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> UpdateRoomAsync(int id, Room room)
        {
            var temp = _context.rooms.Find(id);
            temp = room;
            await _context.SaveChangesAsync();
            return temp;
        }

        public async Task DeleteRoomAsync(int id)
        {
            var temp = _context.rooms.Find(id);
            _context.rooms.Remove(temp);
            await _context.SaveChangesAsync();
        }
    }
}
