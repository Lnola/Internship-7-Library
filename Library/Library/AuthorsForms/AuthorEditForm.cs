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
    public partial class AuthorEditForm : Form
    {
        private AuthorsRepository _authorsRepository;
        private Author _author;

        public AuthorEditForm(string authorId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);

            _author = _authorsRepository.GetAuthorById(int.Parse(authorId));

            FillDetails();
        }

        private void FillDetails()
        {
            firstNameTextBox.Text = _author.FirstName;
            lastNameTextBox.Text = _author.LastName;

            booksListBox.Items.Clear();
            foreach (var book in _author.BooksByAuthor)
                booksListBox.Items.Add(book.Name, true);
            foreach (var book in _authorsRepository.GetAllBooksWithoutAnAuthor())
                booksListBox.Items.Add(book.Name);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var books = booksListBox.CheckedItems;

            var isSaved = _authorsRepository.AddOrEditAnAuthor(firstName, lastName, books, _author.AuthorId);

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
