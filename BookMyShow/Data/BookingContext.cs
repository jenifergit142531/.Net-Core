using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Booking>Bookings { get; set; }
    }
}
