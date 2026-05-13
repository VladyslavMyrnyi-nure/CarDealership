using CarDealership.Models;

namespace CarDealership.Services
{
    /// <summary>
    /// Сервіс відображення автомобілів у таблиці
    /// </summary>
    public class CarGridService
    {
        public object GetCarsForGrid(List<Car> cars)
        {
            return cars.Select(car => new
            {
                Марка = car.Brand,
                Модель = car.Model,
                Рік = car.Year,
                Країна = car.Country,
                Стан = car.Condition,
                Ціна = $"{car.Price:N0} грн"
            }).ToList();
        }
    }
}