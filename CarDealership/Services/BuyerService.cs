using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    public class BuyerService
    {
        public List<Buyer> Buyers { get; set; }

        public void AddBuyer(Buyer buyer)
        {
            Buyers.Add(buyer);
        }

        public void DeleteBuyer(Guid id)
        {
            Buyer? buyer = Buyers.FirstOrDefault(x => x.Id == id);

            if (buyer != null)
                Buyers.Remove(buyer);
        }

        public void UpdateBuyer(Guid id, Buyer updatedBuyer)
        {
            Buyer? buyer = Buyers.FirstOrDefault(x => x.Id == id);

            if (buyer == null)
                return;

            buyer.FullName = updatedBuyer.FullName;
            buyer.Phone = updatedBuyer.Phone;
            buyer.Email = updatedBuyer.Email;
            buyer.DesiredBrand = updatedBuyer.DesiredBrand;
            buyer.MinYear = updatedBuyer.MinYear;
            buyer.MaxPrice = updatedBuyer.MaxPrice;
            buyer.Requirements = updatedBuyer.Requirements;
            buyer.RequiredCondition = updatedBuyer.RequiredCondition;
        }
    }
}