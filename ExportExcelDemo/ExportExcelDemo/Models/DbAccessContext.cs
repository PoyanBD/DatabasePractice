using System.Data.Entity;
namespace ExportExcelDemo.Models
{
    public class DbAccessContext : DbContext
    {
        public DbAccessContext() : base("DefaultConnection") { }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
    }
}