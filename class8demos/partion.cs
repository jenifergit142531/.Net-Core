public class Partition
{
    public void showPartion()
    {
        IList<string> places=new List<string>(){
         "pune","chennai","delhi","goa","kerala"
        };

        var skipresult=places.Skip(2);
        var takeresult = places.Take(2);

         var skipresult2=places.SkipLast(1);
          var takeresult2=places.TakeLast(1);

          var skipresult3=places.SkipWhile(s=>s.Length<5);
           var takeresult3=places.TakeWhile(s=>s.Length>3);


           foreach(var i in takeresult)
           Console.WriteLine("take Values "+i);
           foreach(var i in takeresult2)
           Console.WriteLine("take  last Values "+i);
           foreach(var i in takeresult3)
           Console.WriteLine("while  while Values "+i);
/*foreach(var i in skipresult)
           Console.WriteLine("Skip Values "+i);
           foreach(var i in skipresult2)
           Console.WriteLine("Skip  last Values "+i);
           foreach(var i in skipresult3)
           Console.WriteLine("Skip  while Values "+i);*/




    }
}