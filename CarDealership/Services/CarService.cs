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

            LoadTestData();
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

        /// Завантаження тестових даних
        private void LoadTestData()
        {
            Cars.Add(new Car
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2020,
                Country = "Japan",
                IsNew = false,
                EngineVolume = 2.5,
                HorsePower = 181,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.Automatic,
                Mileage = 85000,
                Condition = TechnicalCondition.Good,
                Features = "Клімат-контроль, Камера",
                Price = 950000
            });

            Cars.Add(new Car
            {
                Brand = "BMW",
                Model = "X5",
                Year = 2022,
                Country = "Germany",
                IsNew = true,
                EngineVolume = 3.0,
                HorsePower = 340,
                FuelType = FuelType.Diesel,
                Transmission = TransmissionType.Automatic,
                Mileage = 0,
                Condition = TechnicalCondition.Excellent,
                Features = "Шкіряний салон",
                Price = 2850000
            });
        }
    }
}