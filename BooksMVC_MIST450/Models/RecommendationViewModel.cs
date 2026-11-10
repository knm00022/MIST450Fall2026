namespace BooksMVC_MIST450.Models
{
    public class RecommendationViewModel
    {
        // Weather information
        public WeatherData Weather { get; set; }

        // List of recommended book genres
        public List<string> RecommendedGenres { get; set; }

        // Books retrieved from the database
        public List<Book> RecommendedBooks { get; set; }

        // City selected by the user
        public string SelectedCity { get; set; }
    }

}
