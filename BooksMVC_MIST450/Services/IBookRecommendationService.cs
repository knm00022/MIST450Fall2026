using BooksMVC_MIST450.Models;

namespace BooksMVC_MIST450.Services
{
    public interface IBookRecommendationService
    {
        List<string> GetRecommendedGenres(WeatherData weather); //any service that implements this contract will provide this method that will give us a list of genres
    }
}
