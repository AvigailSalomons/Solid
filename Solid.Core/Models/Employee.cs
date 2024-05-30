using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirhDate { get; set; }
       
        public DateOnly StartDate { get; set; }
        public double Payroll { get; set; }
       public List<Room> supervisedRooms { get; set; } 

    }
}
