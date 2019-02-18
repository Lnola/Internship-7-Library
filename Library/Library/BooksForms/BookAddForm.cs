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
using Library.Data.Enums;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.BooksForms
{
    public partial class BookAddForm : Form
    {
        private BooksRepository _booksRepository;

        public BookAddForm()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);

            FillDetails();
        }

        private void FillDetails()
        {
            authorsListBox.Items.Clear();
            foreach (var author in _booksRepository.GetAllAuthors())
                authorsListBox.Items.Add($"{author.AuthorId}. {author.FirstName} {author.LastName}");

            publishersListBox.Items.Clear();
            foreach (var publisher in _booksRepository.GetAllPublishers())
                publishersListBox.Items.Add($"{publisher.PublisherId}. {publisher.Name}");

            genresListBox.Items.Add(Genre.Drama);
            genresListBox.Items.Add(Genre.Enciklopedija);
            genresListBox.Items.Add(Genre.Ep);
            genresListBox.Items.Add(Genre.Pjesma);
            genresListBox.Items.Add(Genre.Pripovjetka);
            genresListBox.Items.Add(Genre.Roman);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (authorsListBox.SelectedIndex == -1 || publishersListBox.SelectedIndex == -1 || genresListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var title = bookTitleTextBox.Text;
                var author = authorsListBox.SelectedItem.ToString();
                var publisher = publishersListBox.SelectedItem.ToString();
                var genre = genresListBox.SelectedItem.ToString();
                var numberOfPages = numberOfPagesTextBox.Text;
                var totalBooks = totalBooksTextBox.Text;

                var isSaved = _booksRepository.AddOrEditBook(title, author, publisher, genre, numberOfPages, totalBooks, null);

                if (!isSaved)
                    MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Knjiga uspjesno spremljena!", "Message", MessageBoxButtons.OK,
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
