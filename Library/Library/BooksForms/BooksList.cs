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

namespace Library.Presentation.BooksForms
{
    public partial class BooksList : Form
    {
        private BooksRepository _booksRepository;

        public BooksList()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);

            FillBooksListBox();
        }

        private void FillBooksListBox()
        {
            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);

            booksListBox.DataSource = _booksRepository.GetAllBooks();
            booksListBox.DisplayMember = "Name";
            booksListBox.ValueMember = "BookId";
        }

        private void ShowBookDetailsForm(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi knjigu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var bookDetails = new BookDetailsForm(booksListBox.SelectedValue.ToString());
                bookDetails.ShowDialog();
                FillBooksListBox();
            }
        }

        private void ShowBookAddForm(object sender, EventArgs e)
        {
            var bookAdd = new BookAddForm();
            bookAdd.ShowDialog();
            FillBooksListBox();
        }

        private void ShowBookEditForm(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi knjigu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var bookEdit = new BookEditForm(booksListBox.SelectedValue.ToString());
                bookEdit.ShowDialog();
                FillBooksListBox();
            }
        }

        private void ShowBookDeleteForm(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi knjigu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var dialogResult = MessageBox.Show("Zelis li izbrisati ovu knjigu?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    _booksRepository.RemoveABook(booksListBox.SelectedValue.ToString());

                    MessageBox.Show("Knjiga uspjesno izbrisana! Time su neki autori, izdavaci i posudbe ostali bez knjige!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillBooksListBox();
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
