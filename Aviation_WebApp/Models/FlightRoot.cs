namespace Aviation_WebApp.Models
{
    public class FlightRoot
    {
       
            public Request request { get; set; }
            public List<ResponseItemFlights> response { get; set; }
            public string terms { get; set; }
        
    }
}
