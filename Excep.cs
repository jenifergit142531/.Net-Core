
public class loudException:System.Exception
{
    public loudException(string message) : base(message)
    {
    
    }
}


class Excep
{
    //user defined exception
    public int volume,station ;

   // public void volumeCheck(int volume)
   public void volumeCheck(int volume)
    {
        try
        {
         // Console.WriteLine("Enter your volume level :");
         // volume=Convert.ToInt16(Console.ReadLine());
          if (volume > 100)
          {
            throw new loudException("Its too loud,reduce the volume");
          }
        }
        catch(loudException e)
        {
            Console.WriteLine("exception handled" + e);
        }
        finally{
            Console.WriteLine("all good and done");
        }

        }


        /*
        if(volume > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(volume),"Its too loud,please keep it low and below 100");
        }
    }
    public void stationCheck(string station)
    {
        if(string.IsNullOrEmpty(station))
        {
            throw new ArgumentNullException(nameof(station),"You cannot tune to an empty station");
        }
    }




    //System exception
    int n,d,result;
    public void divide()
    {
        Console.WriteLine("Enter the numerator :");
        n=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the denominator :");
        d=Convert.ToInt16(Console.ReadLine());
        try
        {
            result=n/d;
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine("Do not divide by zero..use a valid denominator" + e.Message);
        }
        finally
        {
            Console.WriteLine("all good and done");
        }
        
        Console.WriteLine("Result : "+result);
        */
    }
