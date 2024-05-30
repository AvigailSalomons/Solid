using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class ClientDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoomId { get; set; }
        public DateOnly EntryDate { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}

