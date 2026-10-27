using System.ComponentModel.DataAnnotations; //This is a namespace that contains attributes that can be used to define metadata for classes and properties. In this case, it is used to define the primary key for the Book class.

namespace BooksMVC_MIST450.Models
{
    public class Book
    {
        // #################### PROPERTIES ####################
        // prop + tab = property template

        [Key] //This tells the compiler that this is the primary key for the table (only above this attribute (BookId))
        public int BookId { get; set; }
        public string Title { get; set; } //date type is string, varible name is Name
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}