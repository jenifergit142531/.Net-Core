using System.Linq;
class Program
{
    public static void Main(string[] args)
    {

        //LINQ TO XML

        LinqXML lxml=new LinqXML();
        lxml.xmlFile();


        /* set operations 
        SetOperation so=new SetOperation();
        so.showSet();*/

/*partition

Partition p=new Partition();
p.showPartion();*/
        /*Element operator

        Element el=new Element();
        el.ShowElement();*/

        /* group join

        IList<Student> stulist=new List<Student>()
      {
        new Student(){Sid=101,Sname="Mira",StandardId=1},
        new Student(){Sid=102,Sname="Mitra",StandardId=2},
        new Student(){Sid=103,Sname="Rahul",StandardId=5},
        new Student(){Sid=104,Sname="Vikram",StandardId=2},
        new Student(){Sid=105,Sname="Amrut",StandardId=1},
      };
       IList<Standard> stdlist=new List<Standard>()
      {
        new Standard(){StandardId=1,StandardName="First"},
        new Standard(){StandardId=2,StandardName="Second"},
        new Standard(){StandardId=3,StandardName="Third"}

      };

      var groupjoin = stdlist.GroupJoin(
                      stulist,
                      std => std.StandardId,
                      stu=>stu.StandardId,
                      
                      (std,sgroup) => new{
                        std=sgroup,
                        standardName=std.StandardName
                      }
                      );
foreach(var i in groupjoin)
{
    Console.WriteLine(i.standardName);

    foreach(var stud in i.std)
    {
        Console.WriteLine(stud.Sname);
    }
}

End of GroupJoin*/ 

        //Joining j=new Joining();
       // j.JoinMe();

     /* IList<Student> stulist=new List<Student>()
      {
        new Student(){Sid=101,Sname="Mira",Age=18},
        new Student(){Sid=102,Sname="Mitra",Age=23},
        new Student(){Sid=103,Sname="Rahul",Age=24},
        new Student(){Sid=104,Sname="Vikram",Age=17},
        new Student(){Sid=105,Sname="Amrut",Age=23},
      };

//LINQ to objects
      /*var votingMembers = from s in stulist
                          // where s.Age > 18
                          //orderby s.Age ascending
                          //orderby s.Age descending
                          
                          select s.Sname;

   // var votingMembers = stulist.Average(s=>s.Age);
   var MinAge = stulist.Min(s=>s.Age);
   var MaxAge = stulist.Max(s=>s.Age);
   Console.WriteLine("Minimum age :"+MinAge);
   Console.WriteLine("Maximum age :"+MaxAge);

    //Console.WriteLine("Average age of student :"+votingMembers);


/*foreach(var i in votingMembers)
{
    Console.WriteLine(i);
}*/



       //LinqOperators lq=new LinqOperators();
       //lq.show(); 
    }
}
