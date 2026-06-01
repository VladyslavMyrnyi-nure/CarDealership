using CarDealership.Models;

namespace CarDealership.Services
{
    // Сервіс пошуку автомобілів за текстом
    public class CarSearchService
    {
        public List<Car> SearchCars(
    List<Car> cars,
    string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return cars;

            string[] terms = searchText.ToLower().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            return cars.Where(car => terms.All(term =>
                    car.Brand.ToLower().Contains(term) ||
                    car.Model.ToLower().Contains(term) ||
                    car.Country.ToLower().Contains(term) ||
                    car.FuelType.ToString().ToLower().Contains(term) ||
                    car.Transmission.ToString().ToLower().Contains(term) ||
                    car.Condition.ToString().ToLower().Contains(term) ||
                    car.BodyType.ToString().ToLower().Contains(term) ||
                    car.Location.ToLower().Contains(term) ||
                    car.Year.ToString().Contains(term) ||
                    car.EngineVolume.ToString().Replace(",", ".").Contains(term.Replace(",", "."))
                )
            ).ToList();
        }
    }
}