public class dogsName{
    public string Name;
    public int Age;
}
class LambExample
{
    public static void sample()
    {
        List<int> numbers=new List<int>(){1,3,4,5,12,13,25,89};

        List<dogsName> Names = new List<dogsName>()
        {
            new dogsName{Name ="walnut" , Age =2},
            new dogsName{Name ="Apricot" ,Age=6},
            new dogsName{Name ="Melon" , Age = 1}
        };
       

        //Check for even numbers 
         
         List<int> evennumbers = numbers.FindAll(x => (x%2)==0);
         foreach(var i in evennumbers)
         {
            Console.WriteLine("Even numbers :{0}",i);
         }


        //select the value

     var newList=Names.Select(x => x.Name);
     foreach(var i in newList)   
     {
        Console.WriteLine("New dog name list :{0}",i);
     } 

     //sort based on age

     var sortList=Names.OrderByDescending(x => x.Age);
     foreach(var i in sortList)   
     {
        Console.WriteLine("Sorted dog name list :{0}",i.Name);
     } 
         
         


    }
    
}