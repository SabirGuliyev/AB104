using EFstep.Models;
using Microsoft.EntityFrameworkCore;

namespace EFstep.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=msi;database=AB104EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
