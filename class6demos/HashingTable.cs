using System.Collections;
class HashingTable
{
    public void checkTable()
    {
        Hashtable deptCode=new Hashtable();
        deptCode.Add(1,"HR");
        deptCode.Add(2,"Sales");
        deptCode.Add(3,"SE");
        deptCode.Add(4,"Manager");
        deptCode.Add(5,101);

        //deptCode.Add(1,"Trainer");


      // this adds the new value to the hash table based on the key value
        deptCode["6"]="operations";
         
      
         
        ICollection key=deptCode.Keys;

        ICollection val=deptCode.Values;


        foreach(var i in val)
        {
            Console.WriteLine("Values are :"+i);
        }

        Console.WriteLine("Fixed size :"+deptCode.IsFixedSize);
        Console.WriteLine("Read only  :"+deptCode.IsReadOnly);
       
        Console.WriteLine("Contains value :"+deptCode.ContainsValue("HR"));
        Console.WriteLine("Contains KEY  :"+deptCode.ContainsKey(1));

      



        //ArrayList ar=new ArrayList(key);
        //ar.Reverse();

        foreach(var k in key)
        {
            Console.WriteLine("Actual value :"+deptCode[k]);
        }




    }
}