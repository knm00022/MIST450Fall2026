using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksMVC_MIST450.Migrations
{
    /// <inheritdoc />
    public partial class InsertRemainingBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.InsertData(
        table: "Books",
        columns: new[] { "BookId", "Author", "Description", "Title", "Genre", "Price", "DatePublished" },
        values: new object[,]
        {
            { 4, "J.R.R. Tolkien", "A fantasy adventure about Bilbo Baggins and his journey.", "The Hobbit", "Fantasy", 14.99m, new DateTime(1937, 9, 21) },
            { 5, "Agatha Christie", "A detective investigates a murder aboard a luxury train.", "Murder on the Orient Express", "Mystery", 12.99m, new DateTime(1934, 1, 1) },
            { 6, "Jane Austen", "A classic story of love, relationships and social expectations.", "Pride and Prejudice", "Romance", 11.99m, new DateTime(1813, 1, 28) },
            { 7, "Andy Weir", "An astronaut struggles to survive alone on Mars.", "The Martian", "Science Fiction", 16.99m, new DateTime(2011, 9, 27) },
            { 8, "Stephen King", "A writer encounters terrifying events at an isolated hotel.", "The Shining", "Horror", 15.99m, new DateTime(1977, 1, 28) },
            { 9, "Jon Krakauer", "The true story of a young man's journey into the Alaskan wilderness.", "Into the Wild", "Adventure", 13.99m, new DateTime(1996, 1, 1) },
            { 10, "Dan Brown", "A symbologist investigates a mysterious murder and a series of hidden clues.", "The Da Vinci Code", "Thriller", 14.99m, new DateTime(2003, 3, 18) },
            { 11, "Stieg Larsson", "A journalist and a hacker investigate a decades-old disappearance.", "The Girl with the Dragon Tattoo", "Thriller", 15.99m, new DateTime(2005, 8, 1) },
            { 12, "Harper Lee", "A young girl experiences issues of justice and morality in the American South.", "To Kill a Mockingbird", "Fiction", 13.99m, new DateTime(1960, 7, 11) },
            { 13, "F. Scott Fitzgerald", "A story of wealth, ambition, love, and the American Dream.", "The Great Gatsby", "Fiction", 12.99m, new DateTime(1925, 4, 10) },
            { 14, "Markus Zusak", "A young girl discovers the power of books during World War II Germany.", "The Book Thief", "Historical Fiction", 14.99m, new DateTime(2005, 9, 1) },
            { 15, "Anthony Doerr", "Two lives become intertwined during World War II.", "All the Light We Cannot See", "Historical Fiction", 16.99m, new DateTime(2014, 5, 6) },
            { 16, "Bill Bryson", "A humorous account of hiking the Appalachian Trail.", "A Walk in the Woods", "Travel", 13.99m, new DateTime(1998, 5, 4) },
            { 17, "Paul Theroux", "A travel writer explores the world through a series of railway journeys.", "The Great Railway Bazaar", "Travel", 15.99m, new DateTime(1975, 1, 1) },
            { 18, "Walter Isaacson", "A detailed account of the life and career of Apple co-founder Steve Jobs.", "Steve Jobs", "Biography", 18.99m, new DateTime(2011, 10, 24) },
            { 19, "Ron Chernow", "The life story of Alexander Hamilton and his role in American history.", "Alexander Hamilton", "Biography", 17.99m, new DateTime(2004, 4, 26) },
            { 20, "Lorraine Hansberry", "A family struggles with dreams, identity, and opportunity in Chicago.", "A Raisin in the Sun", "Drama", 11.99m, new DateTime(1959, 3, 11) },
            { 21, "Arthur Miller", "A traveling salesman confronts his dreams and disappointments.", "Death of a Salesman", "Drama", 12.99m, new DateTime(1949, 2, 10) },
            { 22, "Douglas Adams", "An ordinary man travels through space in a hilarious intergalactic adventure.", "The Hitchhiker's Guide to the Galaxy", "Comedy", 13.99m, new DateTime(1979, 10, 12) },
            { 23, "Jerome K. Jerome", "Three friends embark on a comic boating holiday along the River Thames.", "Three Men in a Boat", "Comedy", 10.99m, new DateTime(1889, 1, 1) }
        });
}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.DeleteData(
        table: "Books",
        keyColumn: "BookId",
        keyValues: new object[]
        {
            4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            14, 15, 16, 17, 18, 19, 20, 21, 22, 23
        });
}
    }
}
