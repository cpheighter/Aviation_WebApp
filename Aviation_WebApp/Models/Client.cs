namespace Aviation_WebApp.Models
{
    public class Client
    {
        public string ip { get; set; }
        public Geo geo { get; set; }
        public Connection connection { get; set; }
        public Device device { get; set; }
        public Agent agent { get; set; }
        public Karma karma { get; set; }
    }
}
