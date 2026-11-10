using BooksMVC_MIST450.Data;
using BooksMVC_MIST450.Models;
using BooksMVC_MIST450.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BooksMVC_MIST450.Controllers
{
    public class RecommendationController : Controller
    {
        private readonly BooksDbContext _context;
        private readonly INOAAWeatherService _weatherService;
        private readonly IBookRecommendationService _bookService;

        public RecommendationController(
            BooksDbContext context,
            INOAAWeatherService weatherService,
            IBookRecommendationService bookService)
        {
            _context = context;
            _weatherService = weatherService;
            _bookService = bookService;
        }

        // GET: Recommendation/Index
        public IActionResult Index() //TO DO: create a view for this action method
        {
            return View();
        }

        // POST: Recommendation/Results
        [HttpPost]
        public async Task<IActionResult> Results(string city) //TO DO: create a view called Results that will show the results of the recommendations
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                ModelState.AddModelError(
                    "city",
                    "Please enter a city.");

                return View("Index");
            }

            try
            {
                // Step 1: Retrieve weather information
                WeatherData weather =
                    await _weatherService.GetWeatherAsync(city);

                // Step 2: Determine recommended genres
                List<string> genres =
                    _bookService.GetRecommendedGenres(weather);

                // Step 3: Retrieve matching books from LocalDB
                List<Book> books = await _context.Books
                    .Where(b => genres.Contains(b.Genre))
                    .ToListAsync();

                // Step 4: Build the ViewModel
                var viewModel = new RecommendationViewModel
                {
                    Weather = weather,
                    SelectedCity = city,
                    RecommendedGenres = genres,
                    RecommendedBooks = books
                };

                // Step 5: Display results
                return View(viewModel);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(
                    "city",
                    $"Unable to retrieve recommendations: {ex.Message}");

                return View("Index");
            }
        }
    }
}

