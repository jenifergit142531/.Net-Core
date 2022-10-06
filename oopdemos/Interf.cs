interface Employee
{
    void salary();
    void roles();
    
}
interface Person
{
    void details();
}
class HR : Person,Employee
{
   public void details()
    {
    Console.WriteLine("HR portfolio");
    }
    public void salary()
   {

    Console.WriteLine("Salary is negotiable");
   }
   public void roles()
   {
     Console.WriteLine("You will be managing the recruitment process");
   }
}

class Sales:Employee,Person
{

public void details()
    {
Console.WriteLine("Sales portfolio");
    }   
    public void salary()
   {
    Console.WriteLine("Salary is non negotiable since you get performance based incentives");
   }
   public void roles()
   {
     Console.WriteLine("You will be responsible for selling the company's product");
   } 
}
