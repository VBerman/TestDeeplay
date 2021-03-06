using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.PostValue;

namespace TestDeeplay.Shared.Models.Post
{
    public class PostEntity
    {
        
        public int Id { get; set; }
        [MinLength(4)]
        [MaxLength(50)]
        public string Name { get; set; }
       
        public virtual ICollection<EmployeeEntity> Employees { get; set; } 
        public virtual ICollection<PostValueEntity> Values { get; set; }
    }
}
