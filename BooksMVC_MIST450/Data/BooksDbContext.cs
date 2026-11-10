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
                },

                new Book
                {
                    BookId = 4,
                    Author = "J.R.R. Tolkien",
                    Description = "A fantasy adventure about Bilbo Baggins and his journey.",
                    Genre = "Fantasy",
                    Title = "The Hobbit",
                    Price = 14.99m,
                    DatePublished = new DateTime(1937, 9, 21)
                },

                new Book
                {
                    BookId = 5,
                    Author = "Agatha Christie",
                    Description = "A detective investigates a murder aboard a luxury train.",
                    Genre = "Mystery",
                    Title = "Murder on the Orient Express",
                    Price = 12.99m,
                    DatePublished = new DateTime(1934, 1, 1)
                },

                new Book
                {
                    BookId = 6,
                    Author = "Jane Austen",
                    Description = "A classic story of love, relationships and social expectations.",
                    Genre = "Romance",
                    Title = "Pride and Prejudice",
                    Price = 11.99m,
                    DatePublished = new DateTime(1813, 1, 28)
                },

                new Book
                {
                    BookId = 7,
                    Author = "Andy Weir",
                    Description = "An astronaut struggles to survive alone on Mars.",
                    Genre = "Science Fiction",
                    Title = "The Martian",
                    Price = 16.99m,
                    DatePublished = new DateTime(2011, 9, 27)
                },

                new Book
                {
                    BookId = 8,
                    Author = "Stephen King",
                    Description = "A writer encounters terrifying events at an isolated hotel.",
                    Genre = "Horror",
                    Title = "The Shining",
                    Price = 15.99m,
                    DatePublished = new DateTime(1977, 1, 28)
                },

                new Book
                {
                    BookId = 9,
                    Author = "Jon Krakauer",
                    Description = "The true story of a young man's journey into the Alaskan wilderness.",
                    Genre = "Adventure",
                    Title = "Into the Wild",
                    Price = 13.99m,
                    DatePublished = new DateTime(1996, 1, 1)
                },


                // THRILLER BOOKS
                new Book
                {
                    BookId = 10,
                    Author = "Dan Brown",
                    Description = "A symbologist investigates a mysterious murder and a series of hidden clues.",
                    Genre = "Thriller",
                    Title = "The Da Vinci Code",
                    Price = 14.99m,
                    DatePublished = new DateTime(2003, 3, 18)
                },

                new Book
                {
                    BookId = 11,
                    Author = "Stieg Larsson",
                    Description = "A journalist and a hacker investigate a decades-old disappearance.",
                    Genre = "Thriller",
                    Title = "The Girl with the Dragon Tattoo",
                    Price = 15.99m,
                    DatePublished = new DateTime(2005, 8, 1)
                },

                // FICTION BOOKS
                new Book
                {
                    BookId = 12,
                    Author = "Harper Lee",
                    Description = "A young girl experiences issues of justice and morality in the American South.",
                    Genre = "Fiction",
                    Title = "To Kill a Mockingbird",
                    Price = 13.99m,
                    DatePublished = new DateTime(1960, 7, 11)
                },

                new Book
                {
                    BookId = 13,
                    Author = "F. Scott Fitzgerald",
                    Description = "A story of wealth, ambition, love, and the American Dream.",
                    Genre = "Fiction",
                    Title = "The Great Gatsby",
                    Price = 12.99m,
                    DatePublished = new DateTime(1925, 4, 10)
                },

                // HISTORICAL FICTION BOOKS
                new Book
                {
                    BookId = 14,
                    Author = "Markus Zusak",
                    Description = "A young girl discovers the power of books during World War II Germany.",
                    Genre = "Historical Fiction",
                    Title = "The Book Thief",
                    Price = 14.99m,
                    DatePublished = new DateTime(2005, 9, 1)
                },

                new Book
                {
                    BookId = 15,
                    Author = "Anthony Doerr",
                    Description = "Two lives become intertwined during World War II.",
                    Genre = "Historical Fiction",
                    Title = "All the Light We Cannot See",
                    Price = 16.99m,
                    DatePublished = new DateTime(2014, 5, 6)
                },

                // TRAVEL BOOKS
                new Book
                {
                    BookId = 16,
                    Author = "Bill Bryson",
                    Description = "A humorous account of hiking the Appalachian Trail.",
                    Genre = "Travel",
                    Title = "A Walk in the Woods",
                    Price = 13.99m,
                    DatePublished = new DateTime(1998, 5, 4)
                },

                new Book
                {
                    BookId = 17,
                    Author = "Paul Theroux",
                    Description = "A travel writer explores the world through a series of railway journeys.",
                    Genre = "Travel",
                    Title = "The Great Railway Bazaar",
                    Price = 15.99m,
                    DatePublished = new DateTime(1975, 1, 1)
                },

                // BIOGRAPHY BOOKS
                new Book
                {
                    BookId = 18,
                    Author = "Walter Isaacson",
                    Description = "A detailed account of the life and career of Apple co-founder Steve Jobs.",
                    Genre = "Biography",
                    Title = "Steve Jobs",
                    Price = 18.99m,
                    DatePublished = new DateTime(2011, 10, 24)
                },

                new Book
                {
                    BookId = 19,
                    Author = "Ron Chernow",
                    Description = "The life story of Alexander Hamilton and his role in American history.",
                    Genre = "Biography",
                    Title = "Alexander Hamilton",
                    Price = 17.99m,
                    DatePublished = new DateTime(2004, 4, 26)
                },

                // DRAMA BOOKS
                new Book
                {
                    BookId = 20,
                    Author = "Lorraine Hansberry",
                    Description = "A family struggles with dreams, identity, and opportunity in Chicago.",
                    Genre = "Drama",
                    Title = "A Raisin in the Sun",
                    Price = 11.99m,
                    DatePublished = new DateTime(1959, 3, 11)
                },

                new Book
                {
                    BookId = 21,
                    Author = "Arthur Miller",
                    Description = "A traveling salesman confronts his dreams and disappointments.",
                    Genre = "Drama",
                    Title = "Death of a Salesman",
                    Price = 12.99m,
                    DatePublished = new DateTime(1949, 2, 10)
                },

                // COMEDY BOOKS
                new Book
                {
                    BookId = 22,
                    Author = "Douglas Adams",
                    Description = "An ordinary man travels through space in a hilarious intergalactic adventure.",
                    Genre = "Comedy",
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Price = 13.99m,
                    DatePublished = new DateTime(1979, 10, 12)
                },

                new Book
                {
                    BookId = 23,
                    Author = "Jerome K. Jerome",
                    Description = "Three friends embark on a comic boating holiday along the River Thames.",
                    Genre = "Comedy",
                    Title = "Three Men in a Boat",
                    Price = 10.99m,
                    DatePublished = new DateTime(1889, 1, 1)
                }



                
                
            );
        }

    }
}