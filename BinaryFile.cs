public class BinaryFile
{
    public void BinaryWrite()
    {
using(BinaryWriter bw=new BinaryWriter(File.Open("/Users/jenifery1409icloud.com/class9/files/BinaryFile.txt",FileMode.OpenOrCreate)))
{
    bw.Write(12.5);
    bw.Write("This is a string");
    bw.Write(true);
    bw.Write(20);
    bw.Write(10);
}
    }
    public void BinaryRead()
    {
    using(BinaryReader br=new BinaryReader(File.Open("/Users/jenifery1409icloud.com/class9/files/BinaryFile.txt",FileMode.OpenOrCreate)))
  {
    Console.WriteLine("Double :"+br.ReadDouble());
    Console.WriteLine("String :"+br.ReadString());
    Console.WriteLine("Boolean :"+br.ReadBoolean());
    Console.WriteLine("Int :"+br.ReadInt16());
    //Console.WriteLine(br.ReadInt32());

    }
}
}