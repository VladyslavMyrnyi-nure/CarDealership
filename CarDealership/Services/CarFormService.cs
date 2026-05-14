using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    /// Логіка форми автомобіля
    public class CarFormService
    {
        public void LoadComboBoxes(ComboBox cmbFuel, ComboBox cmbTransmission, ComboBox cmbCondition)
        {
            cmbFuel.DataSource = Enum.GetValues(typeof(FuelType));

            cmbTransmission.DataSource = Enum.GetValues(typeof(TransmissionType));

            cmbCondition.DataSource = Enum.GetValues(typeof(TechnicalCondition));
        }

        public bool ValidateData(
            string brand,
            string model)
        {
            if (string.IsNullOrWhiteSpace(brand))
                return false;

            if (string.IsNullOrWhiteSpace(model))
                return false;

            return true;
        }

        public Car CreateCar(
            string brand,
            string model,
            int year,
            double engine,
            int horsePower,
            int mileage,
            string country,
            string features,
            FuelType fuel,
            TransmissionType transmission,
            TechnicalCondition condition,
            bool isNew,
            decimal price)
        {
            return new Car
            {
                Brand = brand.Trim(),
                Model = model.Trim(),
                Year = year,
                EngineVolume = engine,
                HorsePower = horsePower,
                Mileage = mileage,
                Country = country.Trim(),
                Features = features.Trim(),
                FuelType = fuel,
                Transmission = transmission,
                Condition = condition,
                IsNew = isNew,
                Price = price
            };
        }
    }
}