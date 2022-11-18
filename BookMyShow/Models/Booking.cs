using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class Booking
    {
        [Key]
        public Guid Bid { get; set; }
        public string Bname { get; set; }
        public string Mname { get; set; }
        public int Ticketprice { get; set; }

    }
}
