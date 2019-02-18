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
    public partial class AuthorDetailsForm : Form
    {
        private AuthorsRepository _authorsRepository;
        private Author _author;

        public AuthorDetailsForm(string authorId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);

            _author = _authorsRepository.GetAuthorById(int.Parse(authorId));

            FillDetails();
        }

        public void FillDetails()
        {
            nameOfAuthorTextBox.Text = $"{_author.FirstName} {_author.LastName}";

            booksByAuthorListBox.Items.Clear();
            foreach (var book in _author.BooksByAuthor)
                booksByAuthorListBox.Items.Add(book.Name);
        }

        private void ShowAuthorEditForm(object sender, EventArgs e)
        {
            var authorEdit = new AuthorEditForm(_author.AuthorId.ToString());
            authorEdit.ShowDialog();
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
