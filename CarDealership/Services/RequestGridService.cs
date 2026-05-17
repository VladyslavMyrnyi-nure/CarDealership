using CarDealership.Models;

namespace CarDealership.Services
{
    public class RequestGridService
    {
        public object GetSupplierRequests(
            List<Request> requests)
        {
            return requests.Select(x => new
            {
                Id = x.Id,

                Номер = x.Number,
                Дата = x.Date.ToString("dd.MM.yyyy HH:mm"),
                Покупець = x.BuyerName,
                Потрібний_автомобіль = x.CarInfo,
                Ціна = $"{x.CarPrice:N0}$",
                Коментар = x.Comment
            }).ToList();
        }

        public object GetTransportRequests(
            List<Request> requests)
        {
            return requests.Select(x => new
            {
                Id = x.Id,

                Номер = x.Number,
                Дата =x.Date.ToString("dd.MM.yyyy HH:mm"),
                Автомобіль = x.CarInfo,
                Покупець = x.BuyerName,
                Звідки = x.From,
                Куди = x.To,
                Доставка = x.DeliveryDate.ToString("dd.MM.yyyy")
            }).ToList();
        }
    }
}