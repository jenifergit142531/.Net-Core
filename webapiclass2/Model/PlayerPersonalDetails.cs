namespace webapiclass2.Model
{
    public class PlayerPersonalDetails :IPlayer
    {
        public IEnumerable<Player> GetPersonalDetails()
        {
            List<Player> pd = new List<Player>()
            {
                new Player()
                {
                 
                    PlayerName = "Aron",
                    Age = 25,
                    Location = "chennai"
                },
                  new Player()
                {

                    PlayerName = "Aron",
                    Age = 25,
                    Location = "chennai"
                },
                    new Player()
                {

                    PlayerName = "Aron",
                    Age = 25,
                    Location = "chennai"
                },
                      new Player()
                {

                    PlayerName = "Aron",
                    Age = 25,
                    Location = "chennai"
                },
            };
            return pd;
        }

       
    }
}
