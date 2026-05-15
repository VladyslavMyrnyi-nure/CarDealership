using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    public class BuyerFormService
    {
        public void LoadComboBox(ComboBox cmbCondition)
        {
            cmbCondition.DataSource =
                Enum.GetValues(typeof(TechnicalCondition));
        }

        public bool Validate(string fullName)
        {
            return !string.IsNullOrWhiteSpace(fullName);
        }

        public Buyer CreateBuyer(
            string fullName,
            string phone,
            string email,
            string brand,
            int minYear,
            decimal maxPrice,
            string requirements,
            TechnicalCondition condition)
        {
            return new Buyer
            {
                FullName = fullName.Trim(),
                Phone = phone.Trim(),
                Email = email.Trim(),
                DesiredBrand = brand.Trim(),
                MinYear = minYear,
                MaxPrice = maxPrice,
                Requirements = requirements.Trim(),
                RequiredCondition = condition
            };
        }
    }
}