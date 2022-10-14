using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Movie
{
  public string moviename;
  public int ticketprice;

  public Movie(string mname,int tp)
  {
     moviename=mname;
     ticketprice=tp;
  }

  public void BinarySerialize()
  {
   FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/MovieBinarySerfile.txt",FileMode.OpenOrCreate);
   BinaryFormatter bf=new BinaryFormatter();
   Movie m=new Movie(moviename,ticketprice);
   bf.Serialize(fs,m);
   fs.Close(); 
  }

  public void BinaryDeSerialize()
  {
   FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/MovieBinarySerfile.txt",FileMode.OpenOrCreate);
   BinaryFormatter bf=new BinaryFormatter();
   Movie mv=(Movie)bf.Deserialize(fs);
   Console.WriteLine("Movie Name :"+mv.moviename);
   Console.WriteLine("Ticket Price :"+mv.ticketprice);
    
  }
  
  
  
  }