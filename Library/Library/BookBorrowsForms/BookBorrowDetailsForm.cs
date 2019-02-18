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

namespace Library.Presentation.BookBorrowsForms
{
    public partial class BookBorrowDetailsForm : Form
    {
        private BookBorrowsRepository _bookBorrowsRepository;
        private BookBorrow _bookBorrow;

        public BookBorrowDetailsForm(string bookBorrowId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _bookBorrowsRepository = new BookBorrowsRepository(context);

            _bookBorrow = _bookBorrowsRepository.GetBookBorrowById(int.Parse(bookBorrowId));

            FillDetails();
        }

        private void FillDetails()
        {
            nameOfStudentTextBox.Text = $"{_bookBorrow.Student.FirstName} {_bookBorrow.Student.LastName}";
            bookNameTextBox.Text = _bookBorrow.Book.Name;
            dateOfBorrowTextBox.Text = _bookBorrow.BorrowDate.ToString();
            dateOfReturnTextBox.Text = _bookBorrow.ReturnDate == null ? "Knjiga nije vracena" : _bookBorrow.ReturnDate.ToString();
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            var bookBorrowEdit = new BookBorrowEditForm(_bookBorrow.BookBorrowId.ToString());
            bookBorrowEdit.ShowDialog();
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
