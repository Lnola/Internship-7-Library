using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.CheckedListBox;

namespace Library.Domain.Repositories
{
    public class AuthorsRepository
    {
        private readonly LibraryContext _context;

        public AuthorsRepository(LibraryContext context)
        {
            _context = context;
        }

        public ICollection<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.Include(author => author.BooksByAuthor).FirstOrDefault(author => author.AuthorId == id);
        }

        public ICollection<Book> GetAllBooksWithoutAnAuthor()
        {
            return _context.Books.Where(book => book.BookAuthor == null).ToList();
        }

        public bool AddOrEditAnAuthor(string firstName, string lastName, CheckedItemCollection booksByAuthor, int? authorId)
        {
            firstName = firstName.FirstLettersToUpper(true);
            lastName = lastName.FirstLettersToUpper(true);

            if (firstName == "" || lastName == "" || firstName == "Error" || lastName == "Error")
                return false;

            var booksCollection = new List<Book>();

            foreach (var book in booksByAuthor)
                booksCollection.AddRange(_context.Books.Where(contextBook => contextBook.Name.Equals(book)));

            if (booksCollection.Count == 0)
                return false;

            if (authorId == null)
            {
                _context.Add(new Author { FirstName = firstName, LastName = lastName, BooksByAuthor = booksCollection });
                _context.SaveChanges();

                return true;
            }

            _context.Authors.Find(authorId).FirstName = firstName;
            _context.Authors.Find(authorId).LastName = lastName;
            _context.Authors.Find(authorId).BooksByAuthor = booksCollection;
            _context.SaveChanges();

            return true;
        }

        public void RemoveAnAuthor(string authorId)
        {
            foreach (var book in _context.Authors.Include(author => author.BooksByAuthor)
                .FirstOrDefault(author => author.AuthorId == int.Parse(authorId)).BooksByAuthor.ToList())
            {
                _context.Authors.Include(author => author.BooksByAuthor)
                    .FirstOrDefault(author => author.AuthorId == int.Parse(authorId)).BooksByAuthor.Remove(book);
            }

            _context.Authors.Remove(_context.Authors.Find(int.Parse(authorId)));
            _context.SaveChanges();
        }
    }
}
