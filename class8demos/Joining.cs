public class Joining
{
    public void JoinMe()
    {
        IList<string> Role=new List<string>()
        {
           "HR",
           "Sales",
           "SE",
           "IT Manager"
        };
        IList<string> supportRoles=new List<string>()
        {
           "Admin assist",
           "HR",
           "IT support",
           
        };


       var joinlist=Role.Join(   //outer sequence
                    supportRoles,  //inner sequence
                    R=>R,//outer key selector
                    Jc=>Jc,//inner key selector
                    (R,Jc)=>R);

   foreach(var i in joinlist)
   {
     Console.WriteLine("{0}",i);
   }

    }
}