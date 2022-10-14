using System.Reflection;
class Program
{
   public static void Main(string[] args)
   {
    BollywoodMovie movie=new BollywoodMovie();
    movie.xmlSerialize();
    movie.xmlDeserialize();

    /*binary serialization
    Movie m=new Movie("Avatar",500);
    m.BinarySerialize();
    m.BinaryDeSerialize();*/


    //BinaryFile bf2=new BinaryFile();
    //bf2.BinaryWrite();
    //bf2.BinaryRead();
//TextFile tf=new TextFile();
//tf.TextWrite();
//tf.TextRead();
    //StreamFile sf=new StreamFile();
    //sf.WriteStream();
    //sf.ReadStream();
    //ByteFile bf=new ByteFile();
    //bf.WriteByteFile();
    //bf.ReadByteFile();

//ScrapMethod sm=new ScrapMethod();
//sm.OldMethod();
//sm.NewMethod();
   // Student s=new Student();
    //Student s1=new Student(101,"mira",1);
    //s1.display();
    
   }
}

   // Reflect r=new Reflect();
    //r.show();

   /* Assembly exec = Assembly.GetExecutingAssembly();
    Type[] typeinfo = exec.GetTypes();
    foreach(var item in typeinfo)
    {
        Console.WriteLine("class :" +item.FullName);

        
        ConstructorInfo[] ci = item.GetConstructors();
        foreach(var i in ci)
        {
            Console.WriteLine("Constructor info :"+i.ToString());
        }
    
        MethodInfo[] methodinfo = item.GetMethods();
        foreach(var method in methodinfo)
        {
            Console.WriteLine("Method Name :"+method.Name);
        

            ParameterInfo[] parameters = method.GetParameters();
            foreach(var arg in parameters)
            {
                Console.WriteLine("parameters :"+arg.Name);
                Console.WriteLine("parameter type :"+arg.ParameterType);
            }

        }*/
    








    

