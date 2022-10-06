//abstract class Movie
class Movie
{
    //concrete method
 public void showTimings()
 {
    Console.WriteLine("Three shows: Morning show,Matinee show,Night show");
 }
 //public abstract void MoviesList();
 public virtual void MoviesList()
 {
    Console.WriteLine("All language movies included in this list");
 }

}

class BollyWood : Movie
{
    public override void MoviesList()
    {
        Console.WriteLine("1.Bhramhastra \n 2.Vikram vedha \n 3.Ek tha Tiger");
    }
}

class HollyWood : Movie
{
    public override void MoviesList()
    {
        Console.WriteLine("1.Interstellar \n 2.Tenet \n 3.F&F");

    }
}