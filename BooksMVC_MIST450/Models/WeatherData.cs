namespace BooksMVC_MIST450.Models
{
    public class WeatherData
    {
        public string City { get; set; } = string.Empty;

        public decimal Temperature { get; set; }

        public string TemperatureUnit { get; set; } = "F";

        public decimal? PrecipitationProbability { get; set; }

        public decimal WindSpeed { get; set; }

        public string WindSpeedUnit { get; set; } = "mph";

        public string WeatherCondition { get; set; } = string.Empty;

        public DateTime ForecastDate { get; set; }
    }
}
