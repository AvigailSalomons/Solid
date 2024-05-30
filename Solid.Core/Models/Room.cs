using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int NumOfBeds { get; set; }
        public double PricePerDay { get; set; }
    }
}
