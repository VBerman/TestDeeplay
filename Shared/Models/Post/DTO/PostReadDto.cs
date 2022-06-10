using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Enums;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.PostValue;

namespace TestDeeplay.Shared.Models.Post
{
    public class PostReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PostValueReadDto> Values { get; set; }

    }
}
