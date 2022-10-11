using System.Collections.Generic;
class SortingList

{
    public void Slist()
    {
        SortedList<int,string> rating=new SortedList<int, string>();
        rating.Add(10,"Outstanding");
        rating.Add (1,"Poor");
        rating.Add(5,"Average");
        rating.Add(4,"below average");
        rating.Add(6,"above average");
        rating.Add(9,"very good");
        rating.Add(2,"very bad");
        rating.Add(8,"good");
        rating.Add(3,"bad");
        rating.Add(7,"Fair");

        for(int i=rating.Count;i>0;i--)
        {
            Console.WriteLine(rating[i]);
        }

        foreach(var i in rating)
        {
            Console.WriteLine(i.Key+":"+i.Value);
        }

    }
}