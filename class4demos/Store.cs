class Store
{

public void displayArray()
{
int[][] arr=new int[3][]
{
    new int[2] {10,20},
    new int[5] {30,40,50,60,70},
    new int[1] {100}
};
//Console.WriteLine(arr[1][3]);
for(int i =0;i<arr.Length;i++) //iterate through rows
{
    for(int j=0;j<arr[i].Length;j++) //iterate through the column
    {
        Console.WriteLine(arr[i][j]);
    }
}
}



}
    /*
//Multidimentional array

public void showData()
{
    
    try{



      int[,] data=new int[2,3]
        {
            {10,20,30},
            {40,50,60}
        };

        Console.WriteLine(data[0,0]);
        Console.WriteLine(data[1,0]);
        Console.WriteLine(data[3,2]);
    }
    catch(IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally{
        Console.WriteLine("all done and dusted");
    }
    

}

}

    /* single dimensional array
    public void showItems()
    {
        //declaring an array
        string[] products=new string[5]
        {
            "Bread","Butter","Jam","Milk","Eggs"
        };

 Console.WriteLine("Available Items on the store :");
      /*  foreach(string p in products)
        {
         Console.WriteLine(p); 
        }

        for(int i=0;i<5;i++)
        {
            Console.WriteLine(products[i]);
        }

        
    }*/





