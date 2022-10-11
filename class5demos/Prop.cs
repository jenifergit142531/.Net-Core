class Prop
{
    private double seconds;

//property
    public double Hours
    {
        get{ return seconds/3600;}
        set
        {
            seconds=18600;

        }
    }

    public int productId{ get; set; }
    
    //property initiazer
    public string pname { get; set; } = "Mouse";
}