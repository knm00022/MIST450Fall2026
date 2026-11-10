using System.Text.Json;
using BooksMVC_MIST450.Models;


namespace BooksMVC_MIST450.Services
{

    public class NOAAWeatherService : INOAAWeatherService
    {
        private readonly HttpClient _httpClient;

        public NOAAWeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "WeatherReads/1.0 (contact: developer@example.com)");
        }

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            // Step 1: Get geographical coordinates for the city
            string geoUrl =
                $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(city)}&count=1&language=en&format=json";

            var geoResponse = await _httpClient.GetAsync(geoUrl);

            geoResponse.EnsureSuccessStatusCode();

            using var geoJson = JsonDocument.Parse(
                await geoResponse.Content.ReadAsStringAsync());

            var results = geoJson.RootElement.GetProperty("results");

            if (results.GetArrayLength() == 0)
                throw new Exception("City not found.");

            var location = results[0];

            double latitude = location.GetProperty("latitude").GetDouble();
            double longitude = location.GetProperty("longitude").GetDouble();

            string cityName = location.GetProperty("name").GetString()
                              ?? city;

            // Step 2: Ask NOAA for the forecast grid
            string pointsUrl =
                $"https://api.weather.gov/points/{latitude},{longitude}";

            var pointsResponse = await _httpClient.GetAsync(pointsUrl);

            pointsResponse.EnsureSuccessStatusCode();

            using var pointsJson = JsonDocument.Parse(
                await pointsResponse.Content.ReadAsStringAsync());

            string forecastUrl = pointsJson.RootElement
                .GetProperty("properties")
                .GetProperty("forecast")
                .GetString()!;

            // Step 3: Retrieve the NOAA forecast
            var forecastResponse =
                await _httpClient.GetAsync(forecastUrl);

            forecastResponse.EnsureSuccessStatusCode();

            using var forecastJson = JsonDocument.Parse(
                await forecastResponse.Content.ReadAsStringAsync());

            var firstPeriod = forecastJson.RootElement
                .GetProperty("properties")
                .GetProperty("periods")[0];


            // Step 4: Extract the weather information

            decimal temperature = firstPeriod
                .GetProperty("temperature").GetDecimal();

            string temperatureUnit = firstPeriod
                .GetProperty("temperatureUnit").GetString() ?? "F";

            string condition = firstPeriod
                .GetProperty("shortForecast").GetString()
                ?? "Unknown";

            string windSpeedText = firstPeriod
                .GetProperty("windSpeed").GetString()
                ?? "0 mph";

            decimal windSpeed = decimal.Parse(
                windSpeedText.Split(' ')[0],
                System.Globalization.CultureInfo.InvariantCulture);

            // Retrieve precipitation probability
            decimal? precipitation = null;

            if (firstPeriod.TryGetProperty(
                "probabilityOfPrecipitation", out var precipitationElement))
            {
                if (precipitationElement.TryGetProperty(
                    "value", out var probabilityValue) &&
                    probabilityValue.ValueKind == JsonValueKind.Number)
                {
                    precipitation = probabilityValue.GetDecimal();
                }
            }



            // Step 5: Return our WeatherData model
            return new WeatherData
            {
                City = cityName,
                Temperature = temperature,
                TemperatureUnit = temperatureUnit,
                WindSpeed = windSpeed,
                WindSpeedUnit = "mph",
                PrecipitationProbability = precipitation,
                WeatherCondition = condition,
                ForecastDate = firstPeriod
                    .GetProperty("startTime").GetDateTime()
            };


        }

    }
}
