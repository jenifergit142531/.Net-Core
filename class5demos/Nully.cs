class Nully
{
    public void checkNull()
    {
         Nullable<int> i=null;

//methods of nullable type
         Console.WriteLine(i.GetValueOrDefault());


         i=25;
         //properties of nullable type

        Console.WriteLine(i.HasValue);
         Console.WriteLine(i.Value);
        
      // ?? : null coalescing operator
        int j= i ?? 5;

       Console.WriteLine(j);


    }
    

}