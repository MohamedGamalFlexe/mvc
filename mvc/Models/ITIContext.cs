
using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public class ITIContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Exam;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }

        public ITIContext() : base()
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
