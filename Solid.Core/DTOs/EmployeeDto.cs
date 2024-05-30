using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirhDate { get; set; }
        public DateOnly StartDate { get; set; }
        public double Payroll { get; set; }
    }
}
