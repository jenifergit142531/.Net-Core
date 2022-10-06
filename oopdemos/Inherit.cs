class Vehicle
{
   public string brand;
   public int WheelType;

   public int price ;
   public void vehicleshow()
   {
    Console.WriteLine("Vehicle class");
   }
}
class  Car : Vehicle
{
  public void get()
  {
    Console.WriteLine("Give your car details ");
    Console.WriteLine("Brand :");
    brand=Console.ReadLine();
    Console.WriteLine("Wheel Type :");
    WheelType=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Price :");
    price=Convert.ToInt32(Console.ReadLine());
  }
  public void show()
  {
    Console.WriteLine("You bought a car {0} at a price Rs.{1}",brand,price);
  }
}

class Ford : Car
{
    public void update()
    {
        Console.WriteLine("no more production units in india");
    }

}
class Toyota
{
  public void tUpdate()
  {
    Console.WriteLine("Popular car brand in the world");
  }
}

class Lexus : Car
{

    public void lexusUpdate()
    {
        Console.WriteLine("Luxury edition of toyoto");
    }
}
class Bike:Vehicle
{
    public void display()
    {
        Console.WriteLine("This is a bike class");
    }
    public void get()
  {
    Console.WriteLine("Give your bike details ");
    Console.WriteLine("Brand :");
    brand=Console.ReadLine();
    Console.WriteLine("Wheel Type :");
    WheelType=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Price :");
    price=Convert.ToInt32(Console.ReadLine());
  }
  public void show()
  {
    Console.WriteLine("You bought a bike {0} at a price Rs.{1}",brand,price);
  }
}