class Operate
{
    public void library()
    {
        int code;
        //console.writeline("Enter 1.Addition 2.subtr)
        Console.WriteLine("Enter the book code ");
        code = Convert.ToInt32(Console.ReadLine());
        switch(code)
        {
            case 100:        
            Console.WriteLine("Comic book !! return to library row 112");
            break;
            case 200:
            Console.WriteLine("Thriller book !! return to row 312");
            break;
            case 300:
            Console.WriteLine("Romantic novel!! return to row 450");
            break;
            default:
            Console.WriteLine("Looks like a magazine");
            break;
        }

    }
    /* multiple if..else statements
    public void offer()
    {
        int amount;
        Console.WriteLine("Enter the purchase amount");
        amount=Convert.ToInt16(Console.ReadLine());
        if(amount > 0 && amount <500)
        {
            Console.WriteLine("Offer not available");
        }
        else if(amount > 500 && amount < 1000)
        {
            Console.WriteLine("You get 50 % discount on the purchase of your order worth Rs.{0}",amount);

        }
        else if (amount > 1000 && amount < 5000)
        {
            Console.WriteLine("You get 60 % discount on the purchase of your order worth Rs.{0}",amount);
        }
        else
        {
            Console.WriteLine("You get car free");
        }
    }*/

   /* Operator precedence 
   public void calc()
    {
        int a = 7+3*2;
        Console.WriteLine(a);
    }*/

    /* simple if..else
    public void cond()
    {
        int x ,y,result;
        Console.WriteLine("Enter X value :");
        x=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter Y value :");
        y=Convert.ToInt16(Console.ReadLine());
        
        if(x>y)
        {
           Console.WriteLine("X is greater than Y"); 
        }
        else
        {
            Console.WriteLine("Y is greater than X");
        }
        //result = x > y ? x:y;
        //Console.WriteLine("Result ="+result);
    
    }*/
}