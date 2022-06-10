using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Enums;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.Post;

namespace TestDeeplay.Shared.Models.Employee
{
    public class EmployeeReadDto
    {
        public int Id { get; set; }
        [MinLength(4)]
        [MaxLength(150)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public virtual DepartmentReadDto Department { get; set; }
        public virtual PostReadDto Post { get; set; }
    }
}
