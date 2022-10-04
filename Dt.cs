class Dt{

public void getDate()
{
    DateTime dt=new DateTime(2022,10,4);
    TimeSpan ts=new TimeSpan(24,20,20);

    DateTime newdate=dt.Add(ts);
    Console.WriteLine("New date :"+newdate);
    
    //Console.WriteLine(dt.TimeOfDay);
    
    /*DateTime dt1=DateTime.MinValue;
    DateTime dt2=DateTime.MaxValue;
    DateTime dt3=DateTime.Today;
    DateTime dt4=DateTime.Now;

    Console.WriteLine(dt1+"\n"+dt2+"\n"+dt3+"\n"+dt4);*/
   // Console.WriteLine(dt.Month.ToString());

}

}