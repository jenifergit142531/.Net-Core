struct Employee
{
    public int id;
    public string name;

    /*public Employee(int eid,string ename)
    {
       id=eid;
       name=ename;
    }*/

    public void get(int id,string name)
    //public void show()
    {
    Console.WriteLine("{0} is an employee with id {1}",name,id);
    }
}