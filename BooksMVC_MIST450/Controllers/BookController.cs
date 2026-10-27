using BooksMVC_MIST450.Data;
using Microsoft.AspNetCore.Mvc;

namespace BooksMVC_MIST450.Controllers
{
    public class BookController : Controller
    {
        private BooksDbContext _context; //this one persis throughout the class.  this is a private field that will be used to store the BooksDbContext object that is passed in through the constructor. This allows us to use the context object to interact with the database.

        public BookController(BooksDbContext context) //Dependency Injection - this is a constructor that takes in a BooksDbContext object and saves it as a private field. This allows us to use the context object to interact with the database.
        {   
            _context = context; //context exists only wihtin the body of this method. this is where we are saving the context object that is passed in through the constructor as a private field. This allows us to use the context object to interact with the database.  
        }


        public IActionResult Index()
        {
            var booklist = _context.Books.ToList(); //Fetches a list of books from the books table 
            
            return View(booklist); //we are passing booklist to the view. "the view" is the page that will be displayed to the user 
        }
    }
}