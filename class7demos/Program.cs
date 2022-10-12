class Program
{
    //anonymous delegate declaration

    //public delegate void AnonymousDelegate(int value);
public static void Main(string[] args)

{
    Events e1=new Events();

    //event and delegate binding

    e1.Press += new MyDelegate1(e1.alarm);
    e1.Remote +=new MyDelegate2(e1.Tv);
    
    // Raising the event manually
    e1.RaiseEvent();
   // LambExample.sample();
}
}
    /*
   //Regular predicate expression

   Predicate<string> check=Predicating.isUpperCase;

   bool result = check("hello");

   Console.WriteLine("Predicate regular :{0}",result);


   //Predicate using anonymous 
    Predicate<string> check2 = delegate(string s)
    {
        return s.Equals(s.ToUpper());
    };
        bool result2=check2("world");
        Console.WriteLine("Predicate Anonymous :{0}",result2);

    
    //predicate using lambda

    Predicate<string> check3 = s => s.Equals(s.ToUpper());
    bool result3=check3("WELCOME");
    Console.WriteLine("Predicate _ lambda way :{0}",result3);








}
}

    /*
    //Regular action delegate
   Action<int> printvalue = ActionDelegate.print;
   printvalue(10);

   // action delegate using anonymous method

   Action <int> printno=delegate(int i)
   {
    Console.WriteLine("Inside anonymous method :{0}",i*i);
   };

   printno(20);

   //action delegate using lambda expression

   Action<int> printlambano = i => Console.WriteLine("Inside lambda :{0}",i*i);
   printlambano(30);



}
}

/* function delegate
        Func<int,int,int,int> f1=FuncDelegate.sum;

        int result=f1(10,10,10);
        Console.WriteLine("Sum {0}",result);

*/

/*function delegate implemented using lambda expression

Func<int,int,int,int> add=(x,y,z)=>x+y+z;
Console.WriteLine(add(10,20,30)); */

// func delegate with an anonymous method

/*
Func<int> generateRandomnos=delegate()
{
    Random rnd=new Random();
    return rnd.Next(1,50);
};

Console.WriteLine(generateRandomnos());


// lambda expression to generate random numbers 

Func<int> randomnos = () =>new Random().Next(60,100);

Console.WriteLine(randomnos());



}
}


    //setting target value for the anonymous delegate
    
   /* AnonymousDelegate ad= delegate(int a)
    {
        for(int i=0;i<=a;i++)
        {
            Console.WriteLine("Inside anonymous delegate {0}",i*i);
        }
    };




    //set the target method


    delOne d1=new delOne(Delegating.display);

    /*delTwo d2=new delTwo(Delegating.add);

    d2 += new delTwo(Delegating.sub);

    d2 += new delTwo(Delegating.multiply);

    d2 += new delTwo(Delegating.divide);

    delThree<int> d3= Delegating.addition;

    delThree<string> d4=Delegating.concat;

    //Invoking the delegate
    //d1();

    Console.WriteLine(d3(200,200));

    Console.WriteLine(d4("Hello","world"));

    //d2(10,20);


//invoking ananymous delegate

ad(10);


}
}*/
