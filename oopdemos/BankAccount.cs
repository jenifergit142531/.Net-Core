class BankAccount
{
    //code (variable,methods)
    public string Accountnumber;
    public string Holdername;

    public int Balance =0 ;


    public void GetAccountDetails()
    {
       Console.WriteLine("Enter the account number ");
       Accountnumber=Console.ReadLine();
       Console.WriteLine("Enter the account holder name :");
       Holdername=Console.ReadLine();
       if(Holdername=="jeni")
       {
        Balance=20000;
       }
       else if(Holdername=="xxx")
       {
        Balance = 15000;
       }
       else
       {
        Console.WriteLine("Account holder name is unvailable");
       }
    }
    public void MakeDeposit()
    {
        int depositamount;
        Console.WriteLine("Enter the amount to deposit ");
        depositamount=Convert.ToInt32(Console.ReadLine());
        Balance+=depositamount;
        Console.WriteLine("You account is successfully credited with Rs.{0} and your available balance is Rs.{1}",depositamount,Balance);
    }
    public void MakeWithdraw()
    {
        int withdrawamount;
        Console.WriteLine("Enter the amount to withdraw ");
        withdrawamount=Convert.ToInt32(Console.ReadLine());
        Balance-=withdrawamount;
        Console.WriteLine("You account is successfully debited with Rs.{0} and the current balance is Rs.{1}",withdrawamount,Balance);
    }

}