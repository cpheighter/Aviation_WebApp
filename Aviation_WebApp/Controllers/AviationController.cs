using Aviation_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace Aviation_WebApp.Controllers
{
    public class AviationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var rootTest = new AirlineRoot();
            var url = "https://airlabs.co/api/v9/airlines?&api_key=d6be5dd7-cf0b-44f6-a883-3d1b8a475ae2";
            var response = await client.GetStringAsync(url);
            Thread.Sleep(3000);
            rootTest = JsonConvert.DeserializeObject<AirlineRoot>(response);
            return View(rootTest);
        }
        
    }
}
