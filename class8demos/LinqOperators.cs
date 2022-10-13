class LinqOperators
{
    public void show()
    {
        string[] breakfast={"Bread","Jam","Egg","Butter"};

        var pancake = from  b in breakfast 
                      where b.Contains('B')
                      select b;


         foreach(var i in pancake)
         {
            Console.WriteLine(i+"");
         }             

    }
}