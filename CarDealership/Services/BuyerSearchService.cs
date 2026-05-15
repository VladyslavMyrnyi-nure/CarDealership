using CarDealership.Models;

namespace CarDealership.Services
{
    public class BuyerSearchService
    {
        public List<Buyer> SearchBuyers(List<Buyer> buyers, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return buyers;

            searchText = searchText.ToLower();

            return buyers.Where(buyer =>
                buyer.FullName.ToLower().Contains(searchText) ||
                buyer.Phone.ToLower().Contains(searchText) ||
                buyer.Email.ToLower().Contains(searchText) ||
                buyer.DesiredBrand.ToLower().Contains(searchText))
                .ToList();
        }
    }
}