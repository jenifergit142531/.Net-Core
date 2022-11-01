using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class ElectronicProduct
    {
      [Key]
        public int Epid { get; set; }
        public string DeviceName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
}
