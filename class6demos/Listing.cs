using System.Collections.Generic;
class Listing
{
    public void Listcheck()
    {
        List<int> myList=new List<int>();
        myList.Add(100);
        myList.Add(200);
        myList.Add(300);
        myList.Add(600);
        myList.Add(450);
        myList.Add(0);
        myList.Add(600);
        myList.Add(450);

         List<int> myList2=new List<int>();
         
         int[] ar=new int[10];


//Copy to method
         myList.CopyTo(ar);

         foreach(var a in ar)
         {
            Console.WriteLine("Copy to "+a);
         }

        Console.WriteLine("count :"+myList.Count);
        
        foreach(int i in myList)
        {
            Console.WriteLine("Elements in List :"+i);
        }

    }
}