using BooksMVC_MIST450.Models;
using BooksMVC_MIST450.Services;

namespace BooksMVC_MIST450.Services
{
    public class BookRecommendationService : IBookRecommendationService
    {
        public List<string> GetRecommendedGenres(WeatherData weather)
        {
            var genres = new List<string>();

            string condition = (weather.WeatherCondition ?? "").ToLowerInvariant();

            // Rainy weather
            if (condition.Contains("rain") ||
                condition.Contains("shower") ||
                condition.Contains("drizzle"))
            {
                genres.AddRange(new[]
                {
                    "Mystery",
                    "Thriller",
                    "Fiction"
                });
            }
            // Snowy weather
            else if (condition.Contains("snow") ||
                     condition.Contains("sleet"))
            {
                genres.AddRange(new[]
                {
                    "Fantasy",
                    "Romance",
                    "Historical Fiction"
                });
            }

            // Stormy weather
            else if (condition.Contains("storm") ||
                     condition.Contains("thunder"))
            {
                genres.AddRange(new[]
                {
                    "Horror",
                    "Thriller",
                    "Mystery"
                });
            }

            // Sunny or clear weather
            else if (condition.Contains("sun") ||
                     condition.Contains("clear"))
            {
                genres.AddRange(new[]
                {
                    "Adventure",
                    "Travel",
                    "Biography"
                });
            }

            // Cloudy weather
            else if (condition.Contains("cloud") ||
                     condition.Contains("overcast"))
            {
                genres.AddRange(new[]
                {
                    "Fiction",
                    "Drama",
                    "Mystery"
                });
            }

            // Default recommendation
            else
            {
                genres.AddRange(new[]
                {
                    "Fiction",
                    "Adventure",
                    "Mystery"
                });
            }

            // Additional temperature-based recommendation
            if (weather.Temperature >= 90)
            {
                genres.Add("Comedy");
                genres.Add("Romance");
            }
            else if (weather.Temperature <= 32)
            {
                genres.Add("Fantasy");
                genres.Add("Historical Fiction");
            }

            return genres.Distinct().ToList();
        }
    }
}

