using CarDealership.Models;

namespace CarDealership.Services
{
    /// Сервіс відображення автомобілів у таблиці
    public class CarGridService
    {
        public object GetCarsForGrid(List<Car> cars)
        {
            return cars.Select(car => new
            {
                Id = car.Id,
                Марка = car.Brand,
                Модель = car.Model,
                Рік = car.Year,
                Країна = car.Country,
                Стан = car.Condition,
                Ціна = $"{car.Price:N0}$"
            }).ToList();
        }
    }
}