
class ScrapMethod
{
    [Obsolete("Do not use this method,use NewMethod instead",true)]
    public void OldMethod()
    {
        Console.WriteLine("This is an inactive method");
    }
    public void NewMethod()
    {
        Console.WriteLine("This is a new active method ");
    }
}