namespace CarDealership.Models
{

    public class AppData
    {
        public List<Car> Cars { get; set; }
        public List<Buyer> Buyers { get; set; }
        public List<Request> Requests { get; set; }

        public AppData()
        {
            Cars = new List<Car>();
            Buyers = new List<Buyer>();
            Requests = new List<Request>();
        }
    }
}