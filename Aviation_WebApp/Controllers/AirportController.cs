using Aviation_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Aviation_WebApp.Controllers
{
    public class AirportController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var rootTest = new AirportRoot();
            var url = "https://airlabs.co/api/v9/airports?api_key=d6be5dd7-cf0b-44f6-a883-3d1b8a475ae2";
            var response = await client.GetStringAsync(url);
            Thread.Sleep(3000);
            rootTest = JsonConvert.DeserializeObject<AirportRoot>(response);
            return View(rootTest);
        }
    }
}
