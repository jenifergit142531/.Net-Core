using System;
using System.Diagnostics;

namespace Class11
{
    public class TPLDemo
    {

        public void DataParallel()
        {
            Stopwatch stopwatch = new Stopwatch();
            

            //Regular c# Loop
            stopwatch.Start();
            Console.WriteLine("Regular c# for loop");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
            stopwatch.Stop();
            Console.WriteLine ($"Regular c# loop execution time {stopwatch.ElapsedMilliseconds} milliseconds");

            //Parallel For
            stopwatch.Start();
            Console.WriteLine("TPL : Parallel For  loop");
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            stopwatch.Stop();
            Console.WriteLine($"Parallel For loop execution time {stopwatch.ElapsedMilliseconds} milliseconds");


            //Parallel For Each
            stopwatch.Start();
            Console.WriteLine("TPL : Parallel ForEach loop");
            List<int> intlist = Enumerable.Range(0, 10).ToList();
            Parallel.ForEach(intlist, i =>
            {
                Console.WriteLine("i={0},thread={1}", i, Thread.CurrentThread.ManagedThreadId);
            });
            stopwatch.Stop();
            Console.WriteLine($"Parallel For each loop execution time {stopwatch.ElapsedMilliseconds} milliseconds");


        }

        //Task Parallelism

        public void TaskParallel()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            Parallel.Invoke(method2, method1, method3);
            st.Stop();
            Console.WriteLine($"methods execution time {st.ElapsedMilliseconds} milliseconds");
        }
        public void method1()
        {
            Console.WriteLine ($"method 1 completed by thread={Thread.CurrentThread.ManagedThreadId}");
        }
        public void method2()
        {
            Console.WriteLine($"method 2 completed by thread={Thread.CurrentThread.ManagedThreadId}");

        }
        public void method3()
        {
            Console.WriteLine($"method 3 completed by thread={Thread.CurrentThread.ManagedThreadId}");

        }

        //Parallel LINQ

        public void ParallelLINQ()
        {
            var numbers = Enumerable.Range(1, 20);
            var evennumbers = numbers.AsParallel().AsOrdered().Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Parallel LINQ :");
            foreach( var i in evennumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}

