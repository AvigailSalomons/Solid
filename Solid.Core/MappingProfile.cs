using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{  
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<ClientDto, Client>().ReverseMap();
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<RoomDto, Room>().ReverseMap();

        }
    }
}
