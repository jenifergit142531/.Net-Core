class Loop
{
    public void bc()
    {
        char choice;
        for (int i=0;i<10;i++)
        {
            if(i==4)
            {
                //break;
                Console.WriteLine("Would you like to continue ? Y / N");
                choice=Convert.ToChar(Console.ReadLine());
                if(choice=='Y')
                continue;
                else if(choice=='N')
                break;
                else
                Console.WriteLine("Invalid choice");
                break;
            }
            Console.WriteLine(i);
        }
    }
    public void exec()
    {
        int n1=0,n2=1,n3,i,number;
        Console.WriteLine("FIBONACCI SERIES ");
        Console.WriteLine("Enter the number of elements :");
        number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n1+" "+n2+" ");
        do
        //while(number<10)
        //for(i=0;i<number;i++)
        {
            n3=n1+n2;
            Console.WriteLine(n3+" ");
            n1=n2;
            n2=n3;
            number++;
        } while(number <10);
    }
}