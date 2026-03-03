
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace IndyBooks.Models;
public class Writer
{
   public long Id { get; set; }
   
   public string Name { get; set; }
   
public ICollection<Book> Books { get; set; } //TODO : Add the Writer Entity properties including the navigation property
}