namespace webapiclass3.Model
{
    public interface IParking
    {
        IEnumerable<CarParking> GetDetails();

        IEnumerable<CarParking> GetCarParkings();
        string Show();
    }
}
