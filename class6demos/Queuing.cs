using System.Collections;
using System.Collections.Generic;
class Queuing
{
    public void WaitingLine()
    {

        //non generic queue
        Queue waitList=new Queue();
        waitList.Enqueue("Patient1");
        waitList.Enqueue("Patient2");
        waitList.Enqueue("Patient3");
        waitList.Enqueue("Patient4");

        waitList.Dequeue();
        Console.WriteLine("Patients waiting list ");
        foreach(var i in waitList)
        {
            Console.WriteLine(i);
        }



        //generic queue
        Queue<string> boarding=new Queue<string>();
        boarding.Enqueue("suitcase");
        boarding.Enqueue("Handbag");
        boarding.Enqueue("sling bag");
        boarding.Enqueue("wallet");
        Console.WriteLine("Luggage list ");
        foreach(var i in boarding)
        {
            Console.WriteLine(i);
        }

    }
}