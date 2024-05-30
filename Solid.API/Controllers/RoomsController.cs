using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomsController : ControllerBase
    {
        // GET: api/<RoomsController>
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<RoomDto>> Get()
        {
            var rooms = _roomService.GetRooms();
            var roomDto = _mapper.Map<IEnumerable<RoomDto>>(rooms);

            return Ok(roomDto);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var room = _roomService.GetById(id);
            var roomDto = _mapper.Map<RoomDto>(room);

            return Ok(roomDto);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<Room> Post([FromBody] Room value)
        {
            var newRoom = new Room { Id=value.Id, NumOfBeds = value.NumOfBeds, PricePerDay=value.PricePerDay };

            return await _roomService.AddRoomAsync(newRoom);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<Room> Put(int id, [FromBody] Room value)
        {
            return await _roomService.UpdateRoomAsync(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _roomService.DeleteRoomAsync(id);

        }
    }
}
