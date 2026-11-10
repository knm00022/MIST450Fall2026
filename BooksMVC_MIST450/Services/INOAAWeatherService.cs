using BooksMVC_MIST450.Models;

namespace BooksMVC_MIST450.Services
{
    public interface INOAAWeatherService
    {
        Task<WeatherData> GetWeatherAsync(string city);
    }
}
