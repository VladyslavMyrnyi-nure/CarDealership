using CarDealership.Models;

namespace CarDealership.Services
{
    public class MatchingGridService
    {
        public object GetCars(List<Car> cars)
        {
            return cars.Select(car => new
            {
                Марка = car.Brand,
                Модель = car.Model,
                Рік = car.Year,
                Пальне = car.FuelType,
                Коробка = car.Transmission,
                Стан = car.Condition,
                Ціна = $"{car.Price:N0}$"
            }).ToList();
        }
    }
}