using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Department;

namespace TestDeeplay.Shared.Models.Employee
{
    public class EmployeeMapperProfile : Profile
    {
        public EmployeeMapperProfile()
        {
            CreateMap<EmployeeEntity, EmployeeReadDto>();
            CreateMap<EmployeePostDto, EmployeeEntity>();
            CreateMap<EmployeeReadDto, EmployeePostDto>();
        }
    }
}
