namespace webapiclass2.Model
{
    public class AllPlayer : IPlayer
    {
       

        public IEnumerable<Player> GetPlayers()
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    Pid = 101,
                    PlayerName = "Aron",
                    MaxScore = 2500,
                    Rating = 3
                },
                  new Player()
                {
                    Pid = 102,
                    PlayerName = "Amy",
                    MaxScore = 3500,
                    Rating = 2
                },
                    new Player()
                {
                    Pid = 103,
                    PlayerName = "John",
                    MaxScore = 4500,
                    Rating = 1
                },
                      new Player()
                {
                    Pid = 104,
                    PlayerName = "Emily",
                    MaxScore = 1500,
                    Rating = 4
                },
            };
            return players;
        }
        

    }
}
