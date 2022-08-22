using Aviation_WebApp.Models;
using Aviation_WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Aviation_WebApp.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            var flights = new FlightViewModel();
            return View(flights);
        }
        [HttpPost]
        public IActionResult FlightTracker(FlightViewModel y)
        {
            var client = new HttpClient();
            var schedules = $"https://airlabs.co/api/v9/schedules?dep_iata={y.iata}&api_key=d6be5dd7-cf0b-44f6-a883-3d1b8a475ae2";
            var response = client.GetStringAsync(schedules).Result;
            var root = JsonConvert.DeserializeObject<FlightRoot>(response);

            return View(root);
        }
        

    }
}
