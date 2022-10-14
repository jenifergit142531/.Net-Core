using System.Xml.Serialization;

[Serializable]
public class BollywoodMovie
{
  public string moviename;
  public int ticketprice;

  public BollywoodMovie()
  {
     moviename="bramastra";
     ticketprice=250;
  }
  public void xmlSerialize()
  {
   XmlSerializer xs=new XmlSerializer(typeof(BollywoodMovie));
   TextWriter tw=new StreamWriter("/Users/jenifery1409icloud.com/class9/files/XMLSerializefile.xml");
   BollywoodMovie bwm=new BollywoodMovie();
   xs.Serialize(tw,bwm);
   tw.Close();
  }
  public void xmlDeserialize()
  {
    XmlSerializer xs=new XmlSerializer(typeof(BollywoodMovie));
    TextReader tr=new StreamReader("/Users/jenifery1409icloud.com/class9/files/XMLSerializefile.xml");
    BollywoodMovie bm=(BollywoodMovie)xs.Deserialize(tr);
    Console.WriteLine("Movie Name :"+bm.moviename);
   Console.WriteLine("Ticket Price :"+bm.ticketprice);
    tr.Close();

  }
  



}