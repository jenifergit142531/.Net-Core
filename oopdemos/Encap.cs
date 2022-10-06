class Encap
{
    private int BookId;
    private string BookName;
    private string Author;

//empty constructor 
    public Encap()
    {
      Console.WriteLine("Empty constructor");
    }

    //parameterized constructor
    public Encap(int bid,string bname,string author)
    {
       BookId = bid;
       BookName=bname;
       Author=author; 
    }


//copy construtor
    public Encap(Encap a)
    {
        Console.WriteLine("Copy constructor invoked :");
        this.BookId=BookId;
        this.BookName=BookName;

    }

     ~Encap()
    {
        
        Console.WriteLine("Destructor invoked");
        
    }
    

   /*public void get()
   {
    Console.WriteLine("Enter the book details");
    Console.WriteLine("BookId :");
    BookId=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Book Name :");
    BookName=Console.ReadLine();
    Console.WriteLine("Author:");
    Author=Console.ReadLine();
   }*/

   public void show()
   {
    Console.WriteLine("You purchased {0} book by the author {1}",BookName,Author);
   }

}