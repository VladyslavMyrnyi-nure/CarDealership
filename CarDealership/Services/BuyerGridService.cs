using CarDealership.Models;

namespace CarDealership.Services
{
    public class BuyerGridService
    {
        public object GetBuyersForGrid(List<Buyer> buyers)
        {
            return buyers.Select(buyer => new
            {
                Id = buyer.Id,
                Покупець = buyer.FullName,
                Телефон = buyer.Phone,
                Email = buyer.Email,
                Марка = buyer.DesiredBrand,
                МінРік = buyer.MinYear,
                Бюджет = $"{buyer.MaxPrice:N0}$",
                Стан = buyer.RequiredCondition,
                Вимоги = buyer.Requirements
            }).ToList();
        }
    }
}