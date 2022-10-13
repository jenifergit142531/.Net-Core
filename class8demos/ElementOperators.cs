public class Element
{
    public void ShowElement()
    {
    IList<int> numbers=new List<int>()
    { 1,21,30,45,12,56,47,10,20};

    Console.WriteLine("First Element :"+numbers.ElementAt(0));
    Console.WriteLine(numbers.ElementAtOrDefault(7));
    Console.WriteLine("First even element :"+numbers.FirstOrDefault(i=>i%2==0));
    Console.WriteLine("last even element :"+numbers.Last(i=>i%2==0));
    Console.WriteLine("single element :"+numbers.SingleOrDefault(i=>i>100));

    }
    
}