using CarDealership.Enums;

namespace CarDealership.Models
{
    public class Buyer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DesiredBrand { get; set; }
        public int MinYear { get; set; }
        public decimal MaxPrice { get; set; }
        public string Requirements { get; set; }
        public TechnicalCondition RequiredCondition { get; set; }

        public Buyer()
        {
            Id = Guid.NewGuid();

            FullName = "";
            Phone = "";
            Email = "";
            DesiredBrand = "";
            Requirements = "";
        }
    }
}