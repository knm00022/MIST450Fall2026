using BooksMVC_MIST450.Models; //This is a namespace that contains the Book class, which is used to represent a book in the database. It is used to define the BooksDbContext class, which is used to interact with the database.
using Microsoft.EntityFrameworkCore; //This is a namespace that contains classes that are used to interact with a database using Entity Framework Core. In this case, it is used to define the BooksDbContext class, which is used to interact with the database.   

namespace BooksMVC_MIST450.Data
{
    public class BooksDbContext : DbContext //this says its a child class of DBContext, which allows us to talk to the database
    {
        public BooksDbContext(DbContextOptions<BooksDbContext>
         options) : base(options) //this is a constructor that takes in options and passes them to the base class (DbContext)
        {

        }
        
        public DbSet<Book> Books { get; set; } //this is a property that represents a collection of Book objects in the database. It is used to query and save instances of Book. The name of the property (Books) will be used as the name of the table in the database.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Author = "Salman Nazir",
                    Description = "This book has no description",
                    Title = "C# for Beginners",
                    Genre = "Programming",
                    Price = 19.99m, //the m at the end of the number tells the compiler that this is a decimal value
                    DatePublished = new DateTime(2025, 10, 27)

                },
                new Book
                {
                    BookId = 2,
                    Author = "Adam Freeman",
                    Description = "This book has no description",
                    Title = "C# Advanced",
                    Genre = "Programming",
                    Price = 29.99m, //the m at the end of the number tells the compiler that this is a decimal value
                    DatePublished = new DateTime(2026, 1, 30)
                },
                new Book
                {
                    BookId = 3,
                    Author = "Morgan Freeman",
                    Description = "This book has no description",
                    Title = "ASP.NET for Beginners",
                    Genre = "Programming",
                    Price = 15.99m, //the m at the end of the number tells the compiler that this is a decimal value
                    DatePublished = new DateTime(2024, 11, 15)
                }
                
                
            );
        }

    }
}