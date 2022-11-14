using System.ComponentModel.DataAnnotations;

namespace webapiclass2.Model
{
    public class Player
    {
        [Key]
        public int Pid { get; set; }
        public string PlayerName { get; set; }
        public int MaxScore{ get; set; }
        public int Rating { get; set; }

        public int Age { get; set; }
        public string Location { get; set; }

    }
}
