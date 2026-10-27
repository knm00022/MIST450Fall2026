using Microsoft.EntityFrameworkCore; //This is a namespace that contains classes that are used to interact with a database using Entity Framework Core. In this case, it is used to define the BooksDbContext class, which is used to interact with the database.   

namespace BooksMVC_MIST450.Data
{
    public class BooksDbContext : DbContext //this says its a child class of DBContext, which allows us to talk to the database
    {
        public BooksDbContext(DbContextOptions<BooksDbContext>
         options) : base(options) //this is a constructor that takes in options and passes them to the base class (DbContext)
        {
        }

    }
}