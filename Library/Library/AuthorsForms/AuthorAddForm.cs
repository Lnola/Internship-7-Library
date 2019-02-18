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

namespace Library.Presentation.AuthorsForms
{
    public partial class AuthorAddForm : Form
    {
        private AuthorsRepository _authorsRepository;

        public AuthorAddForm()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);

            FillBooks();
        }

        private void FillBooks()
        {
            booksListBox.Items.Clear();
            foreach (var book in _authorsRepository.GetAllBooksWithoutAnAuthor())
                booksListBox.Items.Add(book.Name);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var selection = booksListBox.CheckedItems;

            var isSaved = _authorsRepository.AddOrEditAnAuthor(firstName, lastName, selection, null);

            if (!isSaved)
                MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Autor uspjesno spremljen!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
