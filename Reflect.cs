class Reflect
{
    public void show()
    {
        Type num=typeof(Int64);
        
        Console.WriteLine(num.FullName);
        Console.WriteLine(num.BaseType);
        Console.WriteLine(num.Namespace);
        Console.WriteLine(num.GUID);

    }
}