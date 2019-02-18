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
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.BooksForms
{
    public partial class BookEditForm : Form
    {
        private BooksRepository _booksRepository;
        private Book _book;

        public BookEditForm(string id)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);

            _book = _booksRepository.GetBookById(id);

            FillDetails();
        }

        private void FillDetails()
        {
            bookTitleTextBox.Text = _book.Name;
            numberOfPagesTextBox.Text = _book.NumberOfPages.ToString();
            totalBooksTextBox.Text = _book.TotalNumberOfBooks.ToString();

            authorsListBox.Items.Clear();
            authorsListBox.Items.Add($"{_book.BookAuthor.AuthorId}. {_book.BookAuthor.FirstName} {_book.BookAuthor.LastName}");
            authorsListBox.SetSelected(0, true);
            foreach (var author in _booksRepository.GetAllAuthors())
                if (author.AuthorId != _book.BookAuthor.AuthorId)
                    authorsListBox.Items.Add($"{author.AuthorId}. {author.FirstName} {author.LastName}");

            publishersListBox.Items.Clear();
            publishersListBox.Items.Add($"{_book.BookPublisher.PublisherId}. {_book.BookPublisher.Name}");
            publishersListBox.SetSelected(0, true);
            foreach (var publisher in _booksRepository.GetAllPublishers())
                if (publisher.PublisherId != _book.BookPublisher.PublisherId)
                    publishersListBox.Items.Add($"{publisher.PublisherId}. {publisher.Name}");

            genresListBox.Items.Add(Genre.Drama);
            genresListBox.Items.Add(Genre.Enciklopedija);
            genresListBox.Items.Add(Genre.Ep);
            genresListBox.Items.Add(Genre.Pjesma);
            genresListBox.Items.Add(Genre.Pripovjetka);
            genresListBox.Items.Add(Genre.Roman);

            switch (_book.Genre)
            {
                case Genre.Drama:
                    genresListBox.SetSelected(0, true);
                    break;
                case Genre.Enciklopedija:
                    genresListBox.SetSelected(1, true);
                    break;
                case Genre.Ep:
                    genresListBox.SetSelected(2, true);
                    break;
                case Genre.Pjesma:
                    genresListBox.SetSelected(3, true);
                    break;
                case Genre.Pripovjetka:
                    genresListBox.SetSelected(4, true);
                    break;
                case Genre.Roman:
                    genresListBox.SetSelected(5, true);
                    break;
            }
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

                var isSaved = _booksRepository.AddOrEditBook(title, author, publisher, genre, numberOfPages, totalBooks, _book.BookId);

                if (!isSaved)
                    MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Podatci o knjizi uspjesno spremljeni!", "Message", MessageBoxButtons.OK,
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
