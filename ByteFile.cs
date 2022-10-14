class ByteFile
{
    public void ReadByteFile()
    {
    FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/bytefile.txt",FileMode.OpenOrCreate);
     int i=0;
     while((i=fs.ReadByte())!=-1)
     {
      Console.WriteLine((char)i);
     }
      fs.Close();

    }
    public void WriteByteFile()
    {
      FileStream fs=new FileStream("/Users/jenifery1409icloud.com/class9/files/bytefile.txt",FileMode.OpenOrCreate);
      for(int i=65;i<=90;i++)
      {
        fs.WriteByte((byte)i);
      }
      Console.WriteLine("File is successfully created and contents are written into it");
      fs.Close();
    }
}