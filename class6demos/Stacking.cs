using System.Collections;
using System.Collections.Generic;

class Stacking
{
    public void dispensePlates()
    {
       Stack plates=new Stack();
       plates.Push("Red plate");
       plates.Push("Green plates");
       plates.Push("Blue plates");
       plates.Push("kids plates");
       plates.Push(101);

       foreach(var i in plates)
       {
        Console.WriteLine(i);
       }

       plates.Pop();

       Console.WriteLine("After deleting the elements:::");

        foreach(var i in plates)
       {
        Console.WriteLine(i);
       }

       /*Stack<int> books=new Stack<int>();
       books.Push(101);
       books.Push(105);

        foreach(var i in books)
       {
        Console.WriteLine(i);
       }*/

       
    }
}