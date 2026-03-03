
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.ViewModels;
public class CreateBookVM
{
    //TODO: Add Properties for all of the data shown in the CreateBook View (see Fig.3)
    
        [Display(Name = "Title: ")]
        public String Title { get; set; } = "";

        //TODO: Add properties and Display annotation needed for searching
        [Display(Name = "Author Name: ")]
        public String Name { get; set; } = "";

        [Display(Name = "SKU: ")]
        public decimal SKU { get; set; }

        [Display(Name = "Price: ")]
        public decimal Price { get; set; }

        public long BookId { get; set; }
    }


    // Be sure to add Data Annotations for Validation and Error Messages as shown
   