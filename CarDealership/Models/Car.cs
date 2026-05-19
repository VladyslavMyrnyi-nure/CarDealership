using CarDealership.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public bool IsNew { get; set; }
        public double EngineVolume { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }
        public TransmissionType Transmission { get; set; }
        public int Mileage { get; set; }
        public TechnicalCondition Condition { get; set; }
        public string Features { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public BodyType BodyType { get; set; }

        // Конструктор за замовчуванням
        public Car()
        {
            Id = Guid.NewGuid();

            Brand = string.Empty;
            Model = string.Empty;
            Country = string.Empty;
            Features = string.Empty;
            Location = "";
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year})";                
        }
    }
}
