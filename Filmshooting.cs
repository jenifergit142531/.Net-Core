using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApproachDemo
{
    internal class Filmshooting
    {
        [Key]
        public int LocationId { get; set; }
        
        public string Location { get; set; }

        public int ScheduledDays { get; set; }

    }
}
