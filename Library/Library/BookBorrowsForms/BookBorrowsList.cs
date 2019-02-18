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
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.BookBorrowsForms
{
    public partial class BookBorrowsList : Form
    {
        private BookBorrowsRepository _bookBorrowsRepository;

        public BookBorrowsList()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _bookBorrowsRepository = new BookBorrowsRepository(context);

            FillBookBorrowDetails();
        }

        private void FillBookBorrowDetails()
        {
            bookBorrowsListBox.Items.Clear();

            var context = new LibraryContext();
            _bookBorrowsRepository = new BookBorrowsRepository(context);

            foreach (var bookBorrow in _bookBorrowsRepository.GetAllBorrows())
                if ((bookBorrow.BorrowDate.AddDays(30) - DateTime.Now).Days == 1)
                    bookBorrowsListBox.Items.Add($"{bookBorrow.BookBorrowId}. {bookBorrow.Book.Name} --- {bookBorrow.Student.FirstName} {bookBorrow.Student.LastName} --- SUTRA");
                else if ((bookBorrow.BorrowDate.AddDays(30) - DateTime.Now).Days < 0)
                    bookBorrowsListBox.Items.Add($"{bookBorrow.BookBorrowId}. {bookBorrow.Book.Name} --- {bookBorrow.Student.FirstName} {bookBorrow.Student.LastName} --- KASNI");
                else if (bookBorrow.ReturnDate != null && (bookBorrow.ReturnDate.Value - bookBorrow.BorrowDate).Days > 30)
                    bookBorrowsListBox.Items.Add($"{bookBorrow.BookBorrowId}. {bookBorrow.Book.Name} --- {bookBorrow.Student.FirstName} {bookBorrow.Student.LastName} --- ZAKASNINA");
                else
                    bookBorrowsListBox.Items.Add($"{bookBorrow.BookBorrowId}. {bookBorrow.Book.Name} --- {bookBorrow.Student.FirstName} {bookBorrow.Student.LastName}");

            totalBooksTextBox.Text = _bookBorrowsRepository.TotalNumberOfBooks().ToString();
            borrowedBooksTextBox.Text = _bookBorrowsRepository.GetAllBorrows().Count.ToString();
        }

        private void ShowBookBorrowDetailsForm(object sender, EventArgs e)
        {
            if (bookBorrowsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi posudbu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var bookBorrowDetails = new BookBorrowDetailsForm(bookBorrowsListBox.SelectedItem.ToString().Substring(0, 3).OnlyNumbers());
                bookBorrowDetails.ShowDialog();
                FillBookBorrowDetails();
            }
        }

        private void ShowBookBorrowAddForm(object sender, EventArgs e)
        {
            var bookBorrowAdd = new BookBorrowAddForm();
            bookBorrowAdd.ShowDialog();
            FillBookBorrowDetails();
        }

        private void ShowBookBorrowEditForm(object sender, EventArgs e)
        {
            if (bookBorrowsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi posudbu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var bookBorrowEdit =
                    new BookBorrowEditForm(bookBorrowsListBox.SelectedItem.ToString().Substring(0, 3).OnlyNumbers());
                bookBorrowEdit.ShowDialog();
                FillBookBorrowDetails();
            }
        }

        private void ShowBookBorrowDeleteForm(object sender, EventArgs e)
        {
            if (bookBorrowsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi posudbu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var dialogResult = MessageBox.Show("Zelis li izbrisati ovu posudbu?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    _bookBorrowsRepository.RemoveABorrow(bookBorrowsListBox.SelectedItem.ToString().OnlyNumbers());

                    MessageBox.Show("Posudba uspjesno izbrisana!!", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    FillBookBorrowDetails();
                }
                else
                    MessageBox.Show("Brisanje otkazano!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
