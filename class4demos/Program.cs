class Program
{

    enum RGBColours
{
    Red,
    Blue=10,
    Green
}
    public static void Main(string[] args)
    {
       // colorCode r=colorCode.Red;
        //colorCode g=colorCode.Green;
        //colorCode b=colorCode.Blue;
        RGBColours r=RGBColours.Red;
        RGBColours g=RGBColours.Green;
        RGBColours b=RGBColours.Blue;

        
        Console.WriteLine("Color code for Red is "+r);
        Console.WriteLine("Color code for Green is "+(int)g);
        Console.WriteLine("Color code for Blue is "+(int)b);
        /*Open o =new Open();
        //o.show();
        Closed c=new Closed();
        c.show();
        o.display();*/
    }
}

        /*Employee emp1;
        Employee emp2;
        emp1.id=101;
        emp1.name="jeni";

        emp2.id=emp1.id;
        emp2.name="Aron";

        emp1.id=102;

        emp1.get(emp1.id,emp1.name);
        emp2.get(emp2.id,emp2.name);
        //emp.id=101;
        //emp.name="Jeni";
        //emp.get(emp.id,emp.name);

        //Store s=new Store();
        //s.showItems();
        //s.showData();
        //s.displayArray();
    }
}
       /* Box b1=new Box();
        b1.setLength(10.0);
        b1.setBreadth(2.0);
        b1.setHeight(3.0);

        Box b2=new Box();
        b2.setLength(3.0);
        b2.setBreadth(3.0);
        b2.setHeight(3.3);

        Box b3=new Box();

        b3=b1+b2;//(10+3)*(2+3)*(3.0+3.3) => 13*5*6.3 => 409.5


        double result1 = b1.calcVolume();
        Console.WriteLine("Volume one : "+result1);

        double result2 = b2.calcVolume();
        Console.WriteLine("Volume two  : "+result2);

        double result3 = b3.calcVolume();
        Console.WriteLine("Volume three  : "+result3);

    }
}
        /*Overload o=new Overload();
        o.display();  
        o.display(1,2);
        o.display(10);
        o.display(12.4);*/
        
    

   