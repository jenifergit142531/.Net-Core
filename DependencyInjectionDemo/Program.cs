
   public interface IUserservice
    {
    void serve();
   
     }

    class UserService1 : IUserservice
    {
      public void serve()
    {
        Console.WriteLine("Inside user service 1");
    }
    }
    class UserService2 :IUserservice
    {
    public void serve()
    {
        Console.WriteLine("Inside user service 2");
    }
}
class client
{



    public IUserservice _service;
    /* constructor injection
               public client(IUserservice service)
            { 
                this._service = service;
                  }
    */
    /*property injection

    public IUserservice service
    {
        set { this._service = value; }
    }


    public void access()
            {
                this._service.serve();
           }
    

                }    
    */

    //method injection
    public void access(IUserservice service)
    {
        service.serve();
    }

    /* creating objects to call the methods inside another class create tight coupling 
    public void access()
    {
        UserService1 us1 = new UserService1();
        us1.serve();
        UserService2 us2 = new UserService2();
        us2.serve();
    }*/


    class Program
    {
        public static void Main(string[] args)
        {
            UserService1 us1 = new UserService1();
            UserService2 us2 = new UserService2();

            /* constructor dependency
            client c1 = new client(us1);

            client c2 = new client(us2);
            c1.access();
            c2.access();

             */

            /* Property Injection 
             * 
            client c1 = new client();
            client c2 = new client();

            c1.service = us1;
            c2.service = us2;

            c1.access();
            c2.access();*/

            /*method injection

            client c1 = new client();
            c1.access(us1);
            c1.access(us2);*/


        }
    }
}
