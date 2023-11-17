using Microsoft.EntityFrameworkCore;
using ProniaAB104.Models;

namespace ProniaAB104.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slide> Slides { get; set; }

    }
}
