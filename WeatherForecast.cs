using System;

namespace microservices_net3
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public DateTime Today { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
