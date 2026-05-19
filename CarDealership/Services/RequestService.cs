using CarDealership.Models;
using System.Xml.Linq;

namespace CarDealership.Services
{
    public class RequestService
    {
        public List<Request> Requests { get; set; }

        public RequestService()
        {
            Requests = new List<Request>();
        }

        public void AddRequest(Request request)
        {
            Requests.Add(request);
        }

        public void DeleteRequest(Guid id)
        {
            Request? request = Requests.FirstOrDefault(x => x.Id == id);

            if (request != null)
                Requests.Remove(request);
        }
    }
}