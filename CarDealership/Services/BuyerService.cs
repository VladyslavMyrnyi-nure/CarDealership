using CarDealership.Enums;
using CarDealership.Models;

namespace CarDealership.Services
{
    public class BuyerService
    {
        public List<Buyer> Buyers { get; set; }

        public BuyerService()
        {
            Buyers = new List<Buyer>();

            LoadTestData();
        }

        private void LoadTestData()
        {
            Buyers.Add(new Buyer
            {
                FullName = "Олена Кравченко",
                Phone = "+380671234567",
                Email = "olena@gmail.com",
                DesiredBrand = "BMW",
                MinYear = 2020,
                MaxPrice = 35000,
                Requirements = "Шкіряний салон, автомат, підігрів сидінь",
                RequiredCondition = TechnicalCondition.Excellent
            });

            Buyers.Add(new Buyer
            {
                FullName = "Ігор Мельник",
                Phone = "+380931112233",
                Email = "igor@gmail.com",
                DesiredBrand = "Audi",
                MinYear = 2017,
                MaxPrice = 28000,
                Requirements = "Круїз-контроль, камера заднього виду",
                RequiredCondition = TechnicalCondition.Good
            });

            Buyers.Add(new Buyer
            {
                FullName = "Марія Сидоренко",
                Phone = "+380991112255",
                Email = "maria@gmail.com",
                DesiredBrand = "Toyota",
                MinYear = 2018,
                MaxPrice = 22000,
                Requirements = "Економна витрата пального, клімат-контроль",
                RequiredCondition = TechnicalCondition.Good
            });

            Buyers.Add(new Buyer
            {
                FullName = "Андрій Коваленко",
                Phone = "+380501998877",
                Email = "andriy@gmail.com",
                DesiredBrand = "Mercedes",
                MinYear = 2021,
                MaxPrice = 45000,
                Requirements = "Повний привід, великий багажник",
                RequiredCondition = TechnicalCondition.Excellent
            });

            Buyers.Add(new Buyer
            {
                FullName = "Світлана Іванова",
                Phone = "+380681234789",
                Email = "svitlana@gmail.com",
                DesiredBrand = "Volkswagen",
                MinYear = 2019,
                MaxPrice = 26000,
                Requirements = "Автоматична коробка, парктроніки",
                RequiredCondition = TechnicalCondition.Good
            });
        }

        public void AddBuyer(Buyer buyer)
        {
            Buyers.Add(buyer);
        }

        public void DeleteBuyer(Guid id)
        {
            Buyer? buyer = Buyers.FirstOrDefault(x => x.Id == id);

            if (buyer != null)
                Buyers.Remove(buyer);
        }

        public void UpdateBuyer(Guid id, Buyer updatedBuyer)
        {
            Buyer? buyer = Buyers.FirstOrDefault(x => x.Id == id);

            if (buyer == null)
                return;

            buyer.FullName = updatedBuyer.FullName;
            buyer.Phone = updatedBuyer.Phone;
            buyer.Email = updatedBuyer.Email;
            buyer.DesiredBrand = updatedBuyer.DesiredBrand;
            buyer.MinYear = updatedBuyer.MinYear;
            buyer.MaxPrice = updatedBuyer.MaxPrice;
            buyer.Requirements = updatedBuyer.Requirements;
            buyer.RequiredCondition = updatedBuyer.RequiredCondition;
        }
    }
}