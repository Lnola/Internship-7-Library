using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }
        public int TotalNumberOfBooks { get; set; }
        public Author BookAuthor { get; set; }
        public Publisher BookPublisher { get; set; }
        public ICollection<BookBorrow> BookBorrows { get; set; }
    }
}