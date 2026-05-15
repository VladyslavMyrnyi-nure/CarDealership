using CarDealership.Models;

namespace CarDealership.Services
{
    public class CarSearchService
    {
        public List<Car> SearchCars(List<Car> cars, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return cars;

            searchText = searchText.ToLower();

            return cars.Where(car =>
                car.Brand.ToLower().Contains(searchText) ||
                car.Model.ToLower().Contains(searchText) ||
                car.Country.ToLower().Contains(searchText))
                .ToList();
        }
    }
}