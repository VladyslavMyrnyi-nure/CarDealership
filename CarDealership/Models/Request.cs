namespace CarDealership.Models
{
    public class Request
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string BuyerName { get; set; }
        public string CarInfo { get; set; }
        public decimal MaxPrice { get; set; }
        public string Comment { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime Date { get; set; }
        public decimal CarPrice { get; set; }

        public Request()
        {
            Id = Guid.NewGuid();

            Number = "";
            Type = "";
            BuyerName = "";
            CarInfo = "";
            Comment = "";
            From = "";
            To = "";

            Date = DateTime.Now;
            DeliveryDate = DateTime.Now.AddDays(3);
        }
    }
}