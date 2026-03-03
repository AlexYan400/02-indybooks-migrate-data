using System;
namespace IndyBooks.ViewModels
{
	public class SearchResultsVM
	{
		public IEnumerable<IndyBooks.Models.Book> Books { get; set; }
		public Boolean isSale { get; set; }
    }
}

