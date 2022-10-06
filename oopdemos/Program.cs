class program
{

public static void Main(string[] args)
{
  HR exe1=new HR();
  exe1.details();
  exe1.roles();
  exe1.salary();

  Sales s=new Sales();
  s.details();
  s.roles();
  s.salary();
}
}
/*BollyWood b=new BollyWood();
b.MoviesList();
b.showTimings();

HollyWood h=new HollyWood();
h.MoviesList();
h.showTimings();

Movie m =new Movie();
m.showTimings();
m.MoviesList();

    


}
}*/
    //hybrid inheritance(single inheritance & multilevel inheritance)
    //car + lexus => single inheritance
    // vehicle + car+lexus => multilevel inheritance


/*Lexus l=new Lexus();
l.lexusUpdate();//lexus method
l.get();// car method(base class)
l.vehicleshow();// vehicle method (base class of car)
/*Ford f=new Ford();
f.update();
f.get();
f.show();*/

/*Car c=new Car();
c.get ();
c.show ();*/

/*Bike b=new Bike();
b.display();
b.get();
b.show();*/




    //static variable
    //statics.a=20;
    

   // Console.WriteLine(statics.a);
    

//instance variable
    //statics ob2=new statics();
    //ob2.b=10;

    //ob2.show();
    







    
    /*public static void check()
    {
       Encap en1=new Encap();
    }
    public static void Main(string[] args)
    {
    check();
    GC.Collect();
    
    //Encap en2=new Encap(101,"inferno","Dan Brown");
    //Encap en3=new Encap(en2);
    //en1.BookId=101;
    //en1.get();
    //en1.show();
    //en1.show();
    
    //en3.show();

       /*BankAccount ba1=new BankAccount();
       ba1.GetAccountDetails();

        int choice ;
        Console.WriteLine("Click 1.Deposit \n  2.Withdraw");
        choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            ba1.MakeDeposit();
            break;
            case 2:
            ba1.MakeWithdraw();
            break;
            default:
            Console.WriteLine("Invalid choice");
            break;
            
        }*/
        
    

