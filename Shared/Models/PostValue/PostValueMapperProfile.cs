using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Department;

namespace TestDeeplay.Shared.Models.PostValue
{
    public class PostMapperProfile : Profile
    {
        public PostMapperProfile()
        {
            CreateMap<PostValueEntity, PostValueReadDto>();
        }
    }
}
