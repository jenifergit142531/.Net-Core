
public delegate void MyDelegate1();
public delegate void MyDelegate2();
public class Events
{
  
    public event MyDelegate1 Press;
    public event MyDelegate2 Remote;

    public void RaiseEvent()
    {
        Press();
        Remote();
        //Console.WriteLine("Event is completed");
    }
  
    public void alarm()
    {
        Console.WriteLine("Wake up !!! wake up !!!");
    }
    public void Tv()
    {
        Console.WriteLine("Changing channels in TV");
    }
}