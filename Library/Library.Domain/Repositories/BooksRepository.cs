using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BooksRepository
    {
        private readonly LibraryContext _context;

        public BooksRepository(LibraryContext context)
        {
            _context = context;
        }

        public ICollection<Book> GetAllBooks()
        {
            return _context.Books.Include(book => book.BookAuthor).Include(book => book.BookBorrows).ToList();
        }

        public Book GetBookById(string id)
        {
            return _context.Books.Include(book => book.BookAuthor).Include(book => book.BookPublisher)
                .Include(book => book.BookBorrows).FirstOrDefault(book => book.BookId == int.Parse(id));
        }

        public ICollection<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public ICollection<Publisher> GetAllPublishers()
        {
            return _context.Publishers.ToList();
        }

        public bool AddOrEditBook(string title, string authorId, string publisherId, string genre, string numberOfPages, string totalBooks, int? bookId)
        {
            title = title.FirstLettersToUpper(false);
            numberOfPages = numberOfPages.OnlyNumbers();
            totalBooks = totalBooks.OnlyNumbers();

            if (title == "" || numberOfPages == "" || numberOfPages == "Error" || totalBooks == "" || totalBooks == "Error")
                return false;

            var bookAuthor = _context.Authors.Find(int.Parse(authorId.OnlyNumbers()));
            var bookPublisher = _context.Publishers.Find(int.Parse(publisherId.OnlyNumbers()));
            var genreAsEnum = Genre.Roman;

            switch (genre)
            {
                case "Pripovjetka":
                    genreAsEnum = Genre.Pripovjetka;
                    break;
                case "Pjesma":
                    genreAsEnum = Genre.Pjesma;
                    break;
                case "Ep":
                    genreAsEnum = Genre.Ep;
                    break;
                case "Enciklopedija":
                    genreAsEnum = Genre.Enciklopedija;
                    break;
                case "Drama":
                    genreAsEnum = Genre.Drama;
                    break;
            }

            if (bookId == null)
            {
                _context.Add(new Book()
                {
                    Name = title,
                    BookAuthor = bookAuthor,
                    BookPublisher = bookPublisher,
                    Genre = genreAsEnum,
                    NumberOfPages = int.Parse(numberOfPages),
                    TotalNumberOfBooks = int.Parse(totalBooks)
                });
                _context.SaveChanges();

                return true;
            }

            _context.Books.Find(bookId).Name = title;
            _context.Books.Find(bookId).BookAuthor = bookAuthor;
            _context.Books.Find(bookId).BookPublisher = bookPublisher;
            _context.Books.Find(bookId).Genre = genreAsEnum;
            _context.Books.Find(bookId).NumberOfPages = int.Parse(numberOfPages);
            _context.Books.Find(bookId).TotalNumberOfBooks = int.Parse(totalBooks);
            _context.SaveChanges();

            return true;
        }

        public void RemoveABook(string id)
        {
            _context.Books.Remove(_context.Books.Find(int.Parse(id)));
            _context.SaveChanges();
        }

        public Student GetStudentByStudentId(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
