using System;
namespace Class11
{
    public class AsyncTasking
    {

        public static async Task printer1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Printer 1 value :" + i);
                    Task.Delay(500).Wait();

                }
            });
        }
        public static async Task printer2()
        {
            
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Printer 2 value :" + i);
                    Task.Delay(500).Wait();

                }
            
        }
    }
}

