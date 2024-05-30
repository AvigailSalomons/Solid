using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Models;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeDto>> Get()
        {
            var clients = _employeeService.GetEmployees();
            var clientDto = _mapper.Map<IEnumerable<EmployeeDto>>(clients);

            return Ok(clientDto);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee = _employeeService.GetById(id);
            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return Ok(employeeDto);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee value)
        {
            var newEmployee = new Employee { FirstName = value.FirstName, LastName = value.LastName };

            return await _employeeService.AddEmployeeAsync(newEmployee);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<Employee> Put(int id, [FromBody] Employee value)
        {
            return await _employeeService.UpdateEmployeeAsync(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);

        }
    }
}
