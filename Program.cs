using EFCoreApproachDemo;

class Program
{
    public static void SelectFilms()
    {
        using (var context = new EFCoreDemoContext())
        {
            foreach(var film in context.FilmDetail01)
            {
                Console.WriteLine("Film Name:" +film.FilmName);
                Console.WriteLine("Director :"+film.Director);
            }
        }
    }
    public static void InsertFilms()
    {
        using (var context = new EFCoreDemoContext())
        {
            //Inserting single record to the db
           /* var film1 = new FilmDetails()
            {
                FilmName="batman",
                Director="nolan"
            };
            var location1 = new Filmshooting()
            {
                Location="germany",
                ScheduledDays=12
            };*/


            //inserting multiple records to db

            List<FilmDetails> film1 = new List<FilmDetails>
            {
                new FilmDetails {FilmName = "Batman",Director = "Nolan"},
                new FilmDetails {FilmName = "Avatar",Director = "james"},
                new FilmDetails {FilmName = "Harry potter",Director = "Jenifer" }

            };
           List<Filmshooting> location1 = new List<Filmshooting>
            {
                new Filmshooting {Location = "Germany",ScheduledDays = 20 },
                new Filmshooting {Location = "Poland",ScheduledDays = 15 },
                new Filmshooting {Location = "Russia",ScheduledDays = 25 }

            };

            foreach(FilmDetails fd in film1)
            {
                context.FilmDetail01.Add(fd);
            }
            foreach (Filmshooting fs in location1)
            {
                context.Filmshooting01.Add(fs);
            }

            //context.Add(film1);

            //context.Add(location1);
            context.SaveChanges();
            
        }
        Console.WriteLine("Film details inserted successfully");
       
    }
    public static void DeleteFilms()
    {
        using(var context=new EFCoreDemoContext())
        {
            var delitem = context.FilmDetail01.FirstOrDefault(x => x.FilmName == "tenet");
            context.FilmDetail01.Remove(delitem);
            context.SaveChanges();
        }
    }
    public static void UpdateFilms()
    {
        using (var context = new EFCoreDemoContext())
        {
            var itemupdate = context.Filmshooting01.FirstOrDefault(x => x.Location == "germany");
            itemupdate.Location = "UK";
            context.SaveChanges();
        }
    }
    public static void Main(string[] args)
    {
        //InsertFilms();
        //DeleteFilms();
        UpdateFilms();
        SelectFilms();
    
    }
}
