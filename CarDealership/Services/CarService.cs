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
                Location = "Автосалон Київ",
                BodyType = BodyType.Sedan,
                IsNew = false,
                EngineVolume = 2.5,
                HorsePower = 181,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.Automatic,
                Mileage = 85000,
                Condition = TechnicalCondition.Good,
                Features = "Клімат-контроль, Камера",
                Price = 20000
            });

            Cars.Add(new Car
            {
                Brand = "BMW",
                Model = "X5",
                Year = 2022,
                Country = "Germany",
                Location = "Автосалон Харків",
                BodyType = BodyType.SUV,
                IsNew = true,
                EngineVolume = 3.0,
                HorsePower = 340,
                FuelType = FuelType.Diesel,
                Transmission = TransmissionType.Automatic,
                Mileage = 0,
                Condition = TechnicalCondition.Excellent,
                Features = "Шкіряний салон",
                Price = 32000
            });

            Cars.Add(new Car
            {
                Brand = "Audi",
                Model = "A6",
                Year = 2019,
                Country = "Germany",
                Location = "Склад Київ",
                BodyType = BodyType.Sedan,
                IsNew = false,
                EngineVolume = 2.0,
                HorsePower = 245,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.Automatic,
                Mileage = 78000,
                Condition = TechnicalCondition.Good,
                Features = "Круїз-контроль, камера, парктроніки",
                Price = 27000
            });

            Cars.Add(new Car
            {
                Brand = "Mercedes",
                Model = "E220",
                Year = 2021,
                Country = "Germany",
                Location = "Салон Харків",
                BodyType = BodyType.Sedan,
                IsNew = false,
                EngineVolume = 2.0,
                HorsePower = 194,
                FuelType = FuelType.Diesel,
                Transmission = TransmissionType.Automatic,
                Mileage = 35000,
                Condition = TechnicalCondition.Excellent,
                Features = "Шкіряний салон, підігрів сидінь",
                Price = 43000
            });

            Cars.Add(new Car
            {
                Brand = "Volkswagen",
                Model = "Passat",
                Year = 2018,
                Country = "Germany",
                Location = "Склад Львів",
                BodyType = BodyType.Universal,
                IsNew = false,
                EngineVolume = 1.8,
                HorsePower = 180,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.Automatic,
                Mileage = 92000,
                Condition = TechnicalCondition.Good,
                Features = "Клімат-контроль, автомат",
                Price = 22000
            });

            Cars.Add(new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2022,
                Country = "Japan",
                Location = "Автосалон Київ",
                BodyType = BodyType.Sedan,
                IsNew = true,
                EngineVolume = 1.6,
                HorsePower = 132,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.Automatic,
                Mileage = 0,
                Condition = TechnicalCondition.Excellent,
                Features = "Камера, мультимедіа",
                Price = 25000
            });

            Cars.Add(new Car
            {
                Brand = "Skoda",
                Model = "Octavia",
                Year = 2020,
                Country = "Czech Republic",
                Location = "Майданчик Полтава",
                BodyType = BodyType.Universal,
                IsNew = false,
                EngineVolume = 1.6,
                HorsePower = 150,
                FuelType = FuelType.Diesel,
                Transmission = TransmissionType.Manual,
                Mileage = 67000,
                Condition = TechnicalCondition.Good,
                Features = "Економний двигун, клімат",
                Price = 21000
            });

            Cars.Add(new Car
            {
                Brand = "Honda",
                Model = "Civic",
                Year = 2019,
                Country = "Japan",
                Location = "Склад Одеса",
                BodyType = BodyType.Hatchback,
                IsNew = false,
                EngineVolume = 1.5,
                HorsePower = 182,
                FuelType = FuelType.Petrol,
                Transmission = TransmissionType.CVT,
                Mileage = 81000,
                Condition = TechnicalCondition.Good,
                Features = "Безключовий доступ",
                Price = 23000
            });

            Cars.Add(new Car
            {
                Brand = "Ford",
                Model = "Focus",
                Year = 2017,
                Country = "USA",
                Location = "Склад Дніпро",
                BodyType = BodyType.Hatchback,
                IsNew = false,
                EngineVolume = 1.6,
                HorsePower = 125,
                FuelType = FuelType.Diesel,
                Transmission = TransmissionType.Manual,
                Mileage = 135000,
                Condition = TechnicalCondition.Satisfactory,
                Features = "Кондиціонер",
                Price = 14000
            });
        }
    }
}