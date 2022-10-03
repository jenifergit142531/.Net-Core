
namespace box{
public class Vardemo
{
    public static void show(ref int val)
    {
    val = val * val;
    Console.WriteLine("Value is :"+val);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int  val=5;
        Console.WriteLine("Value before :"+val);
        Vardemo.show(ref val);
        Console.WriteLine("value after :"+val);

       




      /*  string bname;
        int edition;
        double price ;
        Console.WriteLine("Enter the book name :");
        bname = Console.ReadLine();
        Console.WriteLine ("Enter the edition");
        edition=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Enter the price");
        price=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Thank you for purchasing the book");
        Console.WriteLine("Find the details below :");
        //Console.WriteLine("You got {0} with the {1} edition at a price of Rs.{2}",bname,edition,price);





        //Console.WriteLine("Type :"+name.GetType());
        //Console.WriteLine ("Hello {0} and your age {1}  ",name,age);
  
  */
    }
}
}

