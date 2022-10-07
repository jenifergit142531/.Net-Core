class Box
{
    private double length;
    private double breadth;
    private double height;

    public double calcVolume()
    {
        return length * breadth * height;
    }
    public void setLength( double len)
    {
    length=len;
    }
    public void setBreadth(double bre)
    {
        breadth=bre;
    }
    public void setHeight(double hei)
    {
       height=hei ;
    }

    public static Box operator+(Box a,Box b)
    {
       Box bx=new Box();
       bx.length=a.length+b.length;
       bx.height=a.height+b.height;
       bx.breadth=a.breadth+b.breadth;
        return bx;
    }
}
