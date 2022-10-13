using System.Xml.Linq;

public class LinqXML
{
    public void xmlFile()
    {
        string myxml=@"<Department>
        <Dname>IT</Dname>
        <Dname>HR</Dname>
        <Dname>SALES</Dname>
        <Dname>MARKETING</Dname>
        </Department>";

        XDocument xdoc=new XDocument();
        xdoc=XDocument.Parse(myxml);
        var xmlresult=xdoc.Element("Department").Descendants();
        Console.WriteLine("DEPARTMENT NAMES :");
        foreach(XElement i in xmlresult)
        {
            Console.WriteLine(i.Value);
        }
    }
}