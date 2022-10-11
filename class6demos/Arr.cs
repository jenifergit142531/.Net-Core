using System.Collections;

class Arr
{
    public void ArrList()
    {
        ArrayList ar=new ArrayList();
        ar.Add (10);
        ar.Add(12.35);
        ar.Add("hello");
        ar.Add(25);
        ar.Add(12.5);
        ar.Add("welcome");
        ar.Add(100);
        ar.Add(2100.5);
        ar.Add('b');
        ar.Add(null);
        ar.Add (true);

        ArrayList arr2=new ArrayList(){
            100,500,650,0,10,200,300,200,100
        };

//arr2.Reverse();
//arr2.Sort();
//arr2.Remove(100);
//arr2.Clear();
ArrayList arr3=new ArrayList();
arr3=arr2.GetRange(2,2);

Console.WriteLine("Last index :"+arr2.LastIndexOf(100));
Console.WriteLine("First index :"+arr2.IndexOf(100));
foreach(var i in arr3)
{
    Console.WriteLine(i);
}
/*//Inserting new value anywhere in the list based on index
        ar.Insert(1,"second item");
        ar.InsertRange(2,arr2);

//Removing elements from the array list

ar.Remove("hello");
ar.RemoveAt(0);
ar.RemoveRange(2,3);



        Console.WriteLine("Count :"+ar.Count);
        Console.WriteLine(ar.Contains(10));
        Console.WriteLine(ar.Capacity);
        Console.WriteLine("Array list items are :");
        /*foreach(var i in ar)
        {
            Console.WriteLine(i);
        }

        for(int i=0;i<ar.Count;i++)
        {
            Console.WriteLine(ar[i]);
        }*/
    }
}