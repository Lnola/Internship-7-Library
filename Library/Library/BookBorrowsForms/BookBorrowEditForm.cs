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
using Library.Infrastructure.Extensions;

namespace Library.Presentation.BookBorrowsForms
{
    public partial class BookBorrowEditForm : Form
    {
        private BookBorrowsRepository _bookBorrowsRepository;
        private BookBorrow _bookBorrow;

        public BookBorrowEditForm(string bookBorrowId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _bookBorrowsRepository = new BookBorrowsRepository(context);

            _bookBorrow = _bookBorrowsRepository.GetBookBorrowById(int.Parse(bookBorrowId));

            FillDetails();
        }

        private void FillDetails()
        {
            dateOfBorrowDTP.Value = _bookBorrow.BorrowDate;
            if (_bookBorrow.ReturnDate != null)
                dateOfReturnDTP.Value = _bookBorrow.ReturnDate.Value;

            allStudentsListBox.Items.Clear();
            allStudentsListBox.Items.Add($"{_bookBorrow.Student.StudentId}. {_bookBorrow.Student.FirstName} {_bookBorrow.Student.LastName}");
            allStudentsListBox.SetSelected(0, true);
            foreach (var student in _bookBorrowsRepository.GetAllStudentsWhoCanBorrow())
                if (student.StudentId != _bookBorrow.StudentId)
                    allStudentsListBox.Items.Add($"{student.StudentId}. {student.FirstName} {student.LastName}");

            allBooksListBox.Items.Clear();

            allBooksListBox.DataSource = _bookBorrowsRepository.GetAllBooksForBorrow();
            allBooksListBox.DisplayMember = "Name";
            allBooksListBox.ValueMember = "BookId";
            allBooksListBox.SelectedItem = _bookBorrow.Book;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (allStudentsListBox.SelectedIndex == -1)
                MessageBox.Show("Pogreska pri unosu. Oznaci ucenika!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                var selectedStudent = allStudentsListBox.SelectedItem.ToString();
                var selectedBook = allBooksListBox.SelectedValue.ToString();
                var dateOfBorrow = dateOfBorrowDTP.Value;
                DateTime? dateOfReturn = null;
                if (addReturnDateCB.Checked)
                    dateOfReturn = dateOfReturnDTP.Value;

                if (dateOfReturn < dateOfBorrow)
                    MessageBox.Show("Pogreska pri unosu. Posudba mora biti prije vracanja!", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    _bookBorrowsRepository.AddOrEditBookBorrow(selectedStudent.OnlyNumbers(),
                        selectedBook, dateOfBorrow, dateOfReturn, _bookBorrow.BookBorrowId);

                    var daysBetweenBorrowAndReturn = dateOfReturn - dateOfBorrow;

                    if (dateOfReturn != null && daysBetweenBorrowAndReturn.Value.Days > 30)
                        MessageBox.Show($"Posudba uspjesno spremljena! Ucenik mora platiti {(daysBetweenBorrowAndReturn.Value.Days - 30) * 0.5} kn zakasnine", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Posudba uspjesno spremljena! Ucenik ne mora platiti zakasninu", "Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
