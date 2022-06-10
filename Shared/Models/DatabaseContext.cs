using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.Post;
using TestDeeplay.Shared.Models.PostInformation;

namespace TestDeeplay.Shared.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<PostInformationEntity> PostInformations { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        
    }
}
