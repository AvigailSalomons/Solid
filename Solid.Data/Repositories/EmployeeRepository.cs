using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.employees;
        }
        public Employee GetById(int id)
        {
            return _context.employees.Find(id);
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            _context.employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

       public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
            var temp = _context.employees.Find(id);
            temp = employee;
            await _context.SaveChangesAsync();
            return temp;
        }

       public async Task DeleteEmployeeAsync(int id)
        {
            var temp = _context.employees.Find(id);
            _context.employees.Remove(temp);
            await _context.SaveChangesAsync();
        }
    }
}
