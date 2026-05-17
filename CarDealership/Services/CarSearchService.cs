using CarDealership.Models;

namespace CarDealership.Services
{
    // Сервіс пошуку автомобілів за текстом
    public class CarSearchService
    {
        public List<Car> SearchCars(List<Car> cars, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return cars;

            searchText = searchText.ToLower().Trim();

            return cars.Where(car =>
                car.Brand.ToLower().Contains(searchText) ||
                car.Model.ToLower().Contains(searchText) ||
                car.Country.ToLower().Contains(searchText) ||
                car.BodyType.ToString().ToLower().Contains(searchText) ||
                car.EngineVolume.ToString().Replace(",", ".").Contains(searchText.Replace(",", "."))).ToList();
        }
    }
}