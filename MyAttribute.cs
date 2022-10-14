[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute
{
    private string developername;
    private string description;

    private string status;
    private string dt;
    public MyAttribute(string dname,string des,string sta,string d)
    {
        developername=dname;
        description=des;
        status=sta;
        dt=d;
    }

    public string Developername{ get
    {
        return developername;
    } }
    public string Description { get
    {
       return  description;
    } }
    public string Status { get
    {
    return status;
    } }
    public string Dt { get
    {
       return dt;
    } }

}