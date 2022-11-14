namespace webapiclass3.Model
{
    public class ParkingInformation : IParking
    {
        public IEnumerable<CarParking> GetDetails()
        {

            List<CarParking> details = new List<CarParking>()
            {
               new CarParking
                {
                   CarNumber="AP12B2",
                   CarName ="Vento",
                   Parkinglot = 'I',
                   Hours = 3


                },
                new CarParking
                {
                   CarNumber="DL12H657",
                   CarName ="Octavia",
                   Parkinglot = 'G',
                   Hours = 5


                },
                new CarParking
                {
                   CarNumber="TN141234",
                   CarName ="Polo",
                   Parkinglot = 'A',
                   Hours = 2


                },
                   new CarParking
                {
                   CarNumber="TN141564",
                   CarName ="BMW",
                   Parkinglot = 'A',
                   Hours = 12


                },
                      new CarParking
                {
                   CarNumber="TN141234",
                   CarName ="Kia",
                   Parkinglot = 'B',
                   Hours = 25


                }

            
        };

            return details;

        }
        public IEnumerable<CarParking> GetCarParkings() => GetDetails().ToList();

        public string Show()
        {
            return "New method here";
        }
        public int CalculatePrice(CarParking cp)
        {

            int rate = 60;
            var price = cp.Hours * rate;
            return price;
        }
    }
}
