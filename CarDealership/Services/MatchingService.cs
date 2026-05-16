using CarDealership.Models;

namespace CarDealership.Services
{
    public class MatchingService
    {
        public List<Car> FindCars(Buyer buyer, List<Car> cars)
        {
            return cars.Where(car =>
                car.Price <= buyer.MaxPrice &&
                car.Year >= buyer.MinYear &&
                car.Condition >= buyer.RequiredCondition &&

                (string.IsNullOrWhiteSpace(buyer.DesiredBrand) ||
                 car.Brand.ToLower().Contains(buyer.DesiredBrand.ToLower()))
            ).ToList();
        }
    }
}