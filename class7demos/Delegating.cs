
//declaring the delegate

public delegate void delOne();

public delegate void delTwo(int i,int j);

//generic delegate declaration
public delegate T delThree<T>(T i,T j);

class Delegating
{

    public static void display()
    {
        Console.WriteLine("Hello delegate");
    }

    public static void add(int a,int b)
    {
        Console.WriteLine("Sum is :{0}",a+b);
    }

    public static void sub(int a,int b)
    {
        Console.WriteLine("subtract is :{0}",a-b);
    }

    public static void multiply(int a,int b)
    {
        Console.WriteLine("multiply is :{0}",a*b);
    }

    public static void divide(int a,int b)
    {
        Console.WriteLine("Division is :{0}",a/b);
    }

    public static string concat(string a,string b)
    {
        return a+b;
    }

    public static int addition(int a,int b)
    {
        return a+b;
    }

    
    
}