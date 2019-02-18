using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BookBorrowsRepository
    {
        private readonly LibraryContext _context;

        public BookBorrowsRepository(LibraryContext context)
        {
            _context = context;
        }

        public ICollection<BookBorrow> GetAllBorrows()
        {
            return _context.BookBorrows.Include(bookBorrow => bookBorrow.Book).Include(bookBorrow => bookBorrow.Student).ToList();
        }

        public BookBorrow GetBookBorrowById(int id)
        {
            return _context.BookBorrows.Include(bookBorrow => bookBorrow.Book).Include(bookBorrow => bookBorrow.Student)
                .FirstOrDefault(bookBorrow => bookBorrow.BookBorrowId == id);
        }

        public ICollection<Student> GetAllStudentsWhoCanBorrow()
        {
            return _context.Students.Where(student => student.BookBorrows.Count < 3).ToList();
        }

        public ICollection<Book> GetAllBooksForBorrow()
        {
            return _context.Books.Where(book => book.BookBorrows.Count < book.TotalNumberOfBooks).ToList();
        }

        public void AddOrEditBookBorrow(string studentId, string bookId, DateTime borrowDate, DateTime? returnDate, int? bookBorrowId)
        {
            var student = _context.Students.Find(int.Parse(studentId.OnlyNumbers()));
            var book = _context.Books.Find(int.Parse(bookId.OnlyNumbers()));

            if (bookBorrowId == null)
            {
                _context.Add(new BookBorrow()
                {
                    Student = student,
                    Book = book,
                    BorrowDate = borrowDate
                });
                _context.SaveChanges();

                return;
            }

            _context.BookBorrows.Find(bookBorrowId).Student = student;
            _context.BookBorrows.Find(bookBorrowId).Book = book;
            _context.BookBorrows.Find(bookBorrowId).BorrowDate = borrowDate;
            _context.BookBorrows.Find(bookBorrowId).ReturnDate = returnDate;
            _context.SaveChanges();
        }

        public void RemoveABorrow(string bookBorrowId)
        {
            _context.BookBorrows.Remove(_context.BookBorrows.Find(int.Parse(bookBorrowId)));
            _context.SaveChanges();
        }

        public int TotalNumberOfBooks()
        {
            return Enumerable.Sum(_context.Books, book => book.TotalNumberOfBooks);
        }
    }
}
