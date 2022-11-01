using System.ComponentModel.DataAnnotations;

namespace BookMyShowApp.Models
{
    public class Bills
    {
        [Required(ErrorMessage ="Name is Required for billing")]
        public string Name { get; set; }

        [Required(ErrorMessage ="mail is is required")]
        [EmailAddress(ErrorMessage ="Enter a valid email address")]
       
        public string Email { get; set; }

        [Range(1,5,ErrorMessage ="single person can book only 1 - 5 tickets only")]
        public int MaxSeats { get; set; }



    }
}
