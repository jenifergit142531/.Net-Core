class Encyclopedia
{
    public void topics()
    {
        Dictionary<string,string> countries=new Dictionary<string, string>();
        countries.Add("UK","london,manchester,birmingham");
        countries.Add("USA","Florida,Reston,Tampa");
        countries.Add("India","pune,gurgaon,chennai");
        countries.Add("Africa",null);

        countries["Africa"]="nairobi,cairo";

        Console.WriteLine(countries["UK"]);

       
       Console.WriteLine(countries.ContainsValue("nairobi,cairo"));


       /* foreach(var search in countries)
{
    Console.WriteLine(search.Key +":"+search.Value);
}*/
        

    }
}