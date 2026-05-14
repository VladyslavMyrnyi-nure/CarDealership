using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    /// <summary>
    /// Сервіс для роботи з автомобілями
    /// </summary>
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

        /// <summary>
        /// Завантаження тестових даних
        /// </summary>
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