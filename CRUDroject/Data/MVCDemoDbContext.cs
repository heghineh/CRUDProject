using CRUDroject.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDroject.Data
{
    public class MVCDemoDbContext : DbContext 
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        //We should create properties which are used
        //to access the tables that EntityFrameworkCore will create in our DB

        //Shortcut prop + tab + tab 
        //Now let's create Domain models in the Models folder
        public DbSet<Employee> Employees { get; set; }
        //Now we are going to inject this inside the program.sc
    }
}
