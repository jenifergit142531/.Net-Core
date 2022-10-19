using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreApproachDemo
{
    internal class EFCoreDemoContext : DbContext
    {
        public DbSet<Filmshooting> Filmshooting01 { get; set; }
        public DbSet<FilmDetails> FilmDetail01 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
    }
}
