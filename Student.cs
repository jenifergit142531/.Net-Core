class Student
{

    public int sid { get; set; }
    public string sname { get; set; }
    public int grade { get; set; }

    public Student()
    {
        sid=0;
        sname=string.Empty;
        grade=0;
    }

    [MyAttribute("Jenifer","created constructor to accept value","completed","10/14/2022")]
    public Student(int s,string name,int g)
    {
        sid=s;
        sname=name;
        grade=g;
    }

    [MyAttribute("Veer","working on student display module to print id,name,grade of student","in-progress","10/09/2022")]
    public void display()
    {
        Console.WriteLine("Student Id:"+sid);
        Console.WriteLine("Student Name:"+sname);

        Console.WriteLine("Student grade:"+grade);

    }
    
    [MyAttribute("Rina","new to this code still working","bug","10/08/2022")]
    public void show()
    {
        Console.WriteLine("attributes are working fine");
    }

    
}


