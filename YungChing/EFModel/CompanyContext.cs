

using Microsoft.EntityFrameworkCore;

namespace YungChing.EFModel
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public string DbPath { get; }

        public CompanyContext() {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "company.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public Company Company { get; set; }
    }
}
