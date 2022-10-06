class statics
{
    public static int a ;
    public int b;

   public void show()
   {
    Console.WriteLine("static variable :"+a);
    a++;
    Console.WriteLine("static variable :"+a);
    Console.WriteLine ("Instance variable :"+b);
    b++;
    Console.WriteLine ("Instance variable :"+b);


   }

}