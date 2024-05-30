using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;

namespace Solid.API.Models
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirhDate { get; set; }

        public DateOnly StartDate { get; set; }
        public double Payroll { get; set; }
        public List<Room> supervisedRooms { get; set; }
    }
}
