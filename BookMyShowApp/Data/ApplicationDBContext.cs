using BookMyShowApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options):base(options)
        {
          
        }
        public DbSet<ElectronicProduct> ElectronicProducts { get; set; }
    }
}
