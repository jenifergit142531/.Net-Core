using System;
namespace Class11
{
    public class DependentAsyncTasking
    {

        public static async void Display()
        {
            string filepath = "/Users/jenifery1409icloud.com/Desktop/DotNet/Class11/Class11/myfile.txt";
            Task<int> t1 = Readfile(filepath);
            Console.WriteLine("get work 1 done");
            Console.WriteLine("get work 2 done");
            Console.WriteLine("get work 3 done");

            int length = await t1;
            Console.WriteLine("Length of the file is :" + length);
            Console.WriteLine("get work 4 done");
            Console.WriteLine("get work 5 done");

        }
        public static async Task<int> Readfile(string filename)
            
        {
            int length = 0;
            Console.WriteLine("Started to read the file");
            using(StreamReader sr=new StreamReader(filename))
            {
                string s = await sr.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed");
            return length;
        }
    }
}

