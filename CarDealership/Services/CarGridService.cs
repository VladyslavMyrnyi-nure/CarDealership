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
                Обєм_двигуна = car.EngineVolume,
                Потужність = $"{car.HorsePower} к.с.",
                Пробіг = $"{car.Mileage:N0} км",
                Країна = car.Country,
                Тип = car.BodyType,
                Місце = car.Location,
                Пальне = car.FuelType,
                Коробка = car.Transmission,
                Стан = car.Condition,
                Новий = car.IsNew ? "Так" : "Ні",
                Особливості = car.Features,
                Ціна = $"{car.Price:N0}$"
            }).ToList();
        }
    }
}