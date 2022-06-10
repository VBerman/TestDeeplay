using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Enums;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.PostKey;

namespace TestDeeplay.Shared.Models.PostValue
{
    public class PostValueReadDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        
        public virtual PostKeyReadDto Key { get; set; }
    }
}
