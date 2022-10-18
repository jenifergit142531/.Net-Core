

using Class11;

class Program
{
public static void Main(string[] args)
    {
        TPLDemo td = new TPLDemo();
        //td.DataParallel();
        td.TaskParallel();
        td.ParallelLINQ();

        /*dependent async task

        Task tsk = new Task(DependentAsyncTasking.Display);
        tsk.Start();
        tsk.Wait();*/

        /* Asynchrous tasking

       
        AsyncTasking.printer1();
        AsyncTasking.printer2();

        Console.WriteLine("Main thread completed");*/

      
        /* Synchronous Tasking
        Task t1 = Task.Run(() =>
        {
            Tasking.Printer1(); 
        });
        t1.Wait();
        Tasking.Printer2();
        Console.WriteLine("Main thread completed");*/
    }
}

