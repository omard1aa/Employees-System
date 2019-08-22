using Microsoft.EntityFrameworkCore;
using webapp.Models;
namespace webapp{
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){
            
        }

        public DbSet<Employee> Employees {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Employee>().HasData(
                new Employee{
                    Id = 1,
                    Name = "Omar",
                    Department = "Software development",
                    Mail = "Omar.diaaeldin@nagwa.com",
                    Age = 22,
                    Address = "Ain-Shams"
                }
            );
        }
    }
}