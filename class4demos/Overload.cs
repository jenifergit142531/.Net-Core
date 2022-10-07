class Overload
{
    public void display()
    {
    Console.WriteLine("Empty display method");
    }
    public void display(string s1,string s2)
    {
    Console.WriteLine("string concatenation : {0}" , s1+s1);
    }
    public void display(int a)
    {
    Console.WriteLine("Integer method" + a);
    }
    public void display(double d)
    {
    Console.WriteLine("Double method" + d);
    }
    public void display(int a,int b)
    {
    Console.WriteLine("sum method {0}" , a+b);
    }
    
}