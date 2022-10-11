using System.Collections.Generic;
class HashingSet
{
   public void hashSet()
   {
    HashSet<string> Languages=new HashSet<string>();
    Languages.Add("C#");
    Languages.Add("Java");
    Languages.Add("GO");
    Languages.Add("C++");
    Languages.Add("Ruby on rails");
    Languages.Add("C#");
    Languages.Add("Java");

    HashSet<string> Level=new HashSet<string>();
    Level.Add("C#");
    Level.Add("Beginner");
    Level.Add("Intermediate");
    Level.Add("Advanced");

    
    //union : combining both hashset
    //Languages.UnionWith(Level);

    //Intersect :elements that are common in both the hash set
    
    //Languages.IntersectWith(Level);

    //except : remove the common element and return the rest of the elements in the hash set

    Languages.ExceptWith(Level);



    foreach(var i in Languages)
    {
        Console.WriteLine("Hash set values :"+i);
    }


   }
}