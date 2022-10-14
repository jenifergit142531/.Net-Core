public class TextFile
{
    public void TextWrite()
    {
       using (TextWriter tw=File.CreateText("/Users/jenifery1409icloud.com/class9/files/Textfile.txt"))
       {
        tw.WriteLine("Text writer is an abstract class for stream writer");
        tw.WriteLine("It is used to write multiple lines of text in the file");
       }
    }
    public void TextRead()
    {
        using(TextReader tr=File.OpenText("/Users/jenifery1409icloud.com/class9/files/Textfile.txt"))
        {
         Console.WriteLine(tr.ReadToEnd());
        }

    }
}