using System.ComponentModel.DataAnnotations; //This is a namespace that contains attributes that can be used to define metadata for classes and properties. In this case, it is used to define the primary key for the Book class.
using System.ComponentModel; //This is a namespace that contains attributes that can be used to define metadata for classes and properties. In this case, it is used to define the display name for the DatePublished property.

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

        [DataType(DataType.Date)] //This is an attribute that is used to define the data type for the property. This is used in the view to display the property as a date picker. This is optional, but it is a good practice to use it.
        [DisplayName("Date Published")] //This is an attribute that is used to define the display name for the property. This is used in the view to display the name of the property. This is optional, but it is a good practice to use it.
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //This is an attribute that is used to define the display format for the property. This is used in the view to display the property as a date. This is optional, but it is a good practice to use it.
        public DateTime DatePublished { get; set; }
        public string Genre { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")] //This is an attribute that is used to define the display format for the property. This is used in the view to display the property as a currency. This is optional, but it is a good practice to use it.
        public decimal Price { get; set; }

    }
}