using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.BooksForms
{
    public partial class BookDetailsForm : Form
    {
        private BooksRepository _booksRepository;
        private Book _book;

        public BookDetailsForm(string bookId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);

            _book = _booksRepository.GetBookById(bookId);

            FillDetails();
        }

        private void FillDetails()
        {
            bookTitleTextBox.Text = _book.Name;
            authorTextBox.Text = $"{_book.BookAuthor.FirstName} {_book.BookAuthor.LastName}";
            publisherTextBox.Text = _book.BookPublisher.Name;
            genreTextBox.Text = _book.Genre.ToString();
            numberOfPagesTextBox.Text = _book.NumberOfPages.ToString();
            totalBooksTextBox.Text = _book.TotalNumberOfBooks.ToString();
            numberOfBooksTextBox.Text = (_book.TotalNumberOfBooks - _book.BookBorrows.Count).ToString();

            studentsListBox.Items.Clear();
            for (int i = 0; i < _book.BookBorrows.Count; i++)
            {
                var student = _booksRepository.GetStudentByStudentId(_book.BookBorrows.ElementAt(i).StudentId);

                var hasStudentBorrowedOnlyOneBook = true;

                for (int j = i + 1; j < _book.BookBorrows.Count; j++)
                    if (_book.BookBorrows.ElementAt(j).StudentId == student.StudentId)
                        hasStudentBorrowedOnlyOneBook = false;

                if (hasStudentBorrowedOnlyOneBook)
                    studentsListBox.Items.Add(
                        $"{student.FirstName} {student.LastName} --- Primjeraka: {_book.BookBorrows.Count(s => s.StudentId == student.StudentId)}");
            }

            //foreach (var bookBorrow in _book.BookBorrows)
            //{
            //    var student = _booksRepository.GetStudentByStudentId(bookBorrow.StudentId);
            //    studentsListBox.Items.Add($"{student.FirstName} {student.LastName}");
            //}

            if (_book.BookBorrows.Count == 0)
                studentsListBox.Items.Add("Knjigu nije posudio niti jedan ucenik!");
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            var bookEdit = new BookEditForm(_book.BookId.ToString());
            bookEdit.ShowDialog();
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
