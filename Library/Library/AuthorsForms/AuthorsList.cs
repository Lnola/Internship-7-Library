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

namespace Library.Presentation.AuthorsForms
{
    public partial class AuthorsList : Form
    {
        private AuthorsRepository _authorsRepository;

        public AuthorsList()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);

            FillAuthorsListBox();
        }

        private void FillAuthorsListBox()
        {
            authorsListBox.Items.Clear();

            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);

            foreach (var author in _authorsRepository.GetAllAuthors())
                authorsListBox.Items.Add($"{author.AuthorId}. {author.FirstName} {author.LastName}");
        }

        private void ShowAuthorDetailsForm(object sender, EventArgs e)
        {
            if (authorsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi autora!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var authorDetails = new AuthorDetailsForm(authorsListBox.SelectedItem.ToString().OnlyNumbers());
                authorDetails.ShowDialog();
                FillAuthorsListBox();
            }
        }

        private void ShowAuthorAddForm(object sender, EventArgs e)
        {
            if (_authorsRepository.GetAllBooksWithoutAnAuthor().Count != 0)
            {
                var authorAdd = new AuthorAddForm();
                authorAdd.ShowDialog();
                FillAuthorsListBox();
            }
            else
                MessageBox.Show(
                    "Ne postoji nijedna knjiga bez autora. Kako bi dodao novog autora prvo dodaj novu knjigu!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ShowAuthorEditForm(object sender, EventArgs e)
        {
            if (authorsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi autora!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var authorEdit = new AuthorEditForm(authorsListBox.SelectedItem.ToString().OnlyNumbers());
                authorEdit.ShowDialog();
                FillAuthorsListBox();
            }
        }

        private void ShowAuthorDeleteForm(object sender, EventArgs e)
        {
            if (authorsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi autora!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (_authorsRepository.GetAllAuthors().Count == 0)
                MessageBox.Show("Mora postojati barem jedan autor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var dialogResult = MessageBox.Show("Zelis li izbrisati ovog autora?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    _authorsRepository.RemoveAnAuthor(authorsListBox.SelectedItem.ToString().OnlyNumbers());

                    MessageBox.Show("Autor uspjesno izbrisan! Time su neke od knjiga ostale bez autora!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillAuthorsListBox();
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
