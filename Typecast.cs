class Typecast
{
    public void cast()
    {
        short a=10;
        int b = a;
        double c=23.45;
        int d=(int)c;

//boxing
        object iob=b;

//unboxing
        int e = (int)iob;

        Console.WriteLine(e);

        Console.WriteLine(iob is int);

        Console.WriteLine(b is short);

        



        Console.WriteLine("implicit conversion :{0}",b);
        Console.WriteLine("Explicit conversion :"+d);
    }
}