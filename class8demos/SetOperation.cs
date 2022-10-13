public class SetOperation
{
    public void showSet()
    {
        IList<string> studentlist=new List<string>()
        {
          "akshay","arun","amy","steve","patrik","rina"
        };
         IList<string> participants=new List<string>()
        {
          "akshay","amy","andrew","emily","rina"
        };

        var unionresult=studentlist.Union(participants);
        
        var intersectres=studentlist.Intersect(participants);

        var exceptres=studentlist.Except(participants);

        Console.WriteLine("Union Result :");
        foreach(var i in unionresult)
        Console.WriteLine(i);

        Console.WriteLine("Intersect Result :");
        foreach(var i in intersectres)
        Console.WriteLine(i);

        Console.WriteLine("Except Result :");
        foreach(var i in exceptres)
        Console.WriteLine(i);
    }
}