
using crudMVCwebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace crudMVCwebApp.Data
{
    public class ApplicationDBContext:DbContext
    {


        public ApplicationDBContext(DbContextOptions options):base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>();
        }
        
        public DbSet<Employee> Employees {get;set;}
    }
}