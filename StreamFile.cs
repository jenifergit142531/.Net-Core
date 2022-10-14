public class StreamFile
{
    public void WriteStream()
    {
    FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/Streamfile.txt",FileMode.OpenOrCreate);
    StreamWriter sw=new StreamWriter(fs);
    sw.WriteLine("This is a file handling session");
    sw.Close();
    fs.Close();
    }
    public void ReadStream()
    {
    FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/Streamfile.txt",FileMode.OpenOrCreate);
    StreamReader sr=new StreamReader(fs);
    string line=sr.ReadLine();
    Console.WriteLine(line);
    sr.Close();
    fs.Close();

    }

}