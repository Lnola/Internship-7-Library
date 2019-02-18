using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class PublishersRepository
    {
        private readonly LibraryContext _context;

        public PublishersRepository(LibraryContext context)
        {
            _context = context;
        }

        public ICollection<Publisher> GetAllPublishers()
        {
            return _context.Publishers.ToList();
        }

        public Publisher GetPublisherById(int id)
        {
            return _context.Publishers.Include(publisher => publisher.PublishedBooks)
                .FirstOrDefault(publisher => publisher.PublisherId == id);
        }

        public ICollection<Book> GetAllBooksWithoutAPublisher()
        {
            return _context.Books.Where(book => book.BookPublisher == null).ToList();
        }

        public bool AddOrEditAPublisher(string name, CheckedListBox.CheckedItemCollection booksByPublisher, int? publisherId)
        {
            name = name.FirstLettersToUpper(true);

            if (name == "" || name == "Error")
                return false;

            var booksCollection = new List<Book>();

            foreach (var book in booksByPublisher)
                booksCollection.AddRange(_context.Books.Where(contextBook => contextBook.Name.Equals(book)));

            if (booksCollection.Count == 0)
                return false;

            if (publisherId == null)
            {
                _context.Add(new Publisher() { Name = name, PublishedBooks = booksCollection });
                _context.SaveChanges();

                return true;
            }

            _context.Publishers.Find(publisherId).Name = name;
            _context.Publishers.Find(publisherId).PublishedBooks = booksCollection;
            _context.SaveChanges();

            return true;
        }

        public void RemoveAPublisher(string publisherId)
        {
            foreach (var book in _context.Publishers.Include(publisher => publisher.PublishedBooks)
                .FirstOrDefault(publisher => publisher.PublisherId == int.Parse(publisherId)).PublishedBooks.ToList())
            {
                _context.Publishers.Include(publisher => publisher.PublishedBooks)
                    .FirstOrDefault(publisher => publisher.PublisherId == int.Parse(publisherId)).PublishedBooks.Remove(book);
            }

            _context.Publishers.Remove(_context.Publishers.Find(int.Parse(publisherId)));
            _context.SaveChanges();
        }
    }
}
