namespace Aviation_WebApp.Models
{
    public class AirlineRoot
    {
        public Request request { get; set; }
        public List<ResponseItem> response { get; set; } = new List<ResponseItem>();
        public string terms { get; set; }
    }
}
