using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeeplay.Shared.Models.Department
{
    public class DepartmentMapperProfile : Profile
    {
        public DepartmentMapperProfile()
        {
            CreateMap<DepartmentEntity, DepartmentReadDto>();
        }
    }
}
