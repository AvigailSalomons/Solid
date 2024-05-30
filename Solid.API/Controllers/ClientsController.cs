using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Services;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // GET: api/<ClientController>
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientsController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ClientDto>> Get()
        {
            var clients = _clientService.GetClients();
            var clientDto = _mapper.Map<IEnumerable<ClientDto>>(clients);

            return Ok(clientDto);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var client = _clientService.GetById(id);
            var clientDto = _mapper.Map<ClientDto>(client);

            return Ok(clientDto);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<Client> Post([FromBody] ClientPostModel value)
        {
            var newClient = new Client { FirstName=value.FirstName, LastName = value.LastName};

            return await _clientService.AddClientAsync(newClient);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<Client> Put(int id, [FromBody] Client value)
        {
            return await _clientService.UpdateClientAsync(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _clientService.DeleteClientAsync(id);

        }
    }
}
