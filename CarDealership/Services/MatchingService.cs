using CarDealership.Models;

namespace CarDealership.Services
{
    public class MatchingService
    {
        public List<Car> FindCars(Buyer buyer,List<Car> cars)
        {
            if (buyer == null)return new List<Car>();

            return cars.Where(car =>
                car.Price <= buyer.MaxPrice
                &&
                car.Year >=buyer.MinYear
                &&
                (string.IsNullOrWhiteSpace(buyer.DesiredBrand) ||
                car.Brand.Trim().Equals(buyer.DesiredBrand.Trim(), StringComparison.OrdinalIgnoreCase))

            ).ToList();
        }
    }
}