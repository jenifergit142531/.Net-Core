sealed class Closed
{
    public void show()
    {
        Console.WriteLine("sealed class");
    }
}

class Open //: Closed (not allowed)
{
    public void display()
    {
        Console.WriteLine("child class");
    }

    public void show()
    {
        Console.WriteLine("sealed class");
    }
}