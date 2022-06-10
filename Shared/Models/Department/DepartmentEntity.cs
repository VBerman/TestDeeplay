using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Employee;

namespace TestDeeplay.Shared.Models.Department
{
    public class DepartmentEntity
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [NotMapped]
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
