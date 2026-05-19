using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    /// Сервіс для роботи з автомобілями
    public class CarService
    {
        public List<Car> Cars { get; set; }

        public CarService()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void DeleteCar(Guid id)
        {
            Car? car = Cars.FirstOrDefault(x => x.Id == id);

            if (car != null)
            {
                Cars.Remove(car);
            }
        }

        public void UpdateCar(Guid id, Car updatedCar)
        {
            Car? oldCar = Cars.FirstOrDefault(x => x.Id == id);

            if (oldCar == null)
                return;

            oldCar.Brand = updatedCar.Brand;
            oldCar.Model = updatedCar.Model;
            oldCar.Year = updatedCar.Year;
            oldCar.EngineVolume = updatedCar.EngineVolume;
            oldCar.HorsePower = updatedCar.HorsePower;
            oldCar.Mileage = updatedCar.Mileage;
            oldCar.Country = updatedCar.Country;
            oldCar.Features = updatedCar.Features;
            oldCar.FuelType = updatedCar.FuelType;
            oldCar.Transmission = updatedCar.Transmission;
            oldCar.Condition = updatedCar.Condition;
            oldCar.IsNew = updatedCar.IsNew;
            oldCar.Price = updatedCar.Price;
        }
    }
}