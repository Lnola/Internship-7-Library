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
    public partial class BookBorrowAddForm : Form
    {
        private BookBorrowsRepository _bookBorrowsRepository;

        public BookBorrowAddForm()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _bookBorrowsRepository = new BookBorrowsRepository(context);

            FillDetails();
        }

        private void FillDetails()
        {
            allStudentsListBox.Items.Clear();

            foreach (var student in _bookBorrowsRepository.GetAllStudentsWhoCanBorrow())
                allStudentsListBox.Items.Add($"{student.StudentId}. {student.FirstName} {student.LastName}");

            allBooksListBox.Items.Clear();

            allBooksListBox.DataSource = _bookBorrowsRepository.GetAllBooksForBorrow();
            allBooksListBox.DisplayMember = "Name";
            allBooksListBox.ValueMember = "BookId";
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

                _bookBorrowsRepository.AddOrEditBookBorrow(selectedStudent.OnlyNumbers(),
                    selectedBook, dateOfBorrow, null, null);

                MessageBox.Show("Posudba uspjesno spremljena!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
        }

        private void CloseFrom(object sender, EventArgs e)
        {
            Close();
        }
    }
}
