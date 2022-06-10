using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.PostInformation;

namespace TestDeeplay.Shared.Models.Post
{
    public class PostEntity
    {
        
        public int Id { get; set; }
        [MinLength(4)]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; } 
        public ICollection<PostInformationEntity> PostInformations { get; set; }
    }
}
