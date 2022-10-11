class Indexing
{
    //public int size=10;
    private string[] names=new string[size];
    static public int size=10;

    public Indexing()
    {
        for(int i=0;i< size;i++)
        {
            names[i]="Not applicable";
        }

    }

//creating Indexer using 'this' keyword
    public string this[int i]
    {
        get{

            return names[i];
        }
        set{
            names[i]=value;
        }
    }
   public string this[float a]
   {
    get{
         return names[1];
             }
    set{
         names[1]=value;
    }
   }

}