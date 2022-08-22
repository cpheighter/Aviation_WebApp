﻿namespace Aviation_WebApp.Models
{
    public class ResponseItemFlights
    {
        public string? airline_iata { get; set; }
        public string? airline_icao { get; set; }
        public string flight_iata { get; set; }
        public string? flight_icao { get; set; }
        public string? flight_number { get; set; }
        public string? dep_iata { get; set; }
        public string? dep_icao { get; set; }
        public string? dep_terminal { get; set; }
        public string? dep_gate { get; set; }
        public string? dep_time { get; set; }
        public string? dep_time_utc { get; set; }
        public string? arr_iata { get; set; }
        public string? arr_icao { get; set; }
        public string? arr_terminal { get; set; }
        public string? arr_gate { get; set; }
        public string? arr_baggage { get; set; }
        public string? arr_time { get; set; }
        public string? arr_time_utc { get; set; }
        public string? cs_airline_iata { get; set; }
        public string? cs_flight_number { get; set; }
        public string? cs_flight_iata { get; set; }
        public string? status { get; set; }
        public int? duration { get; set; }
        public string? delayed { get; set; }
        public string? aircraft_icao { get; set; }
        public int? arr_time_ts { get; set; }
        public int? dep_time_ts { get; set; }
    }

   

}
