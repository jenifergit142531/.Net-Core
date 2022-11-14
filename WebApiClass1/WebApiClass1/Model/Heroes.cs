namespace WebApiClass1.Model
{
    public class Heroes
    {
        public int CartoonId { get; set; }
        public string HeroName { get; set; }
        public String CartoonName { get; set; }
        public int Viewers { get; set; }

        internal static object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
