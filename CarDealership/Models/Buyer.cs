using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarDealership.Enums;

namespace CarDealership.Models
{
    /// <summary>
    /// Клас покупця
    /// </summary>
    public class Buyer
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string DesiredBrand { get; set; }

        public int MinYear { get; set; }

        public decimal MaxPrice { get; set; }

        public TechnicalCondition RequiredCondition { get; set; }

        public Buyer()
        {
            Id = Guid.NewGuid();

            FullName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            DesiredBrand = string.Empty;
        }

        public override string ToString()
        {
            return $"{FullName} - {DesiredBrand}";
        }
    }
}
