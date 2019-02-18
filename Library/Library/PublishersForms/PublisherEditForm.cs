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

namespace Library.Presentation.PublishersForms
{
    public partial class PublisherEditForm : Form
    {
        private PublishersRepository _publishersRepository;
        private Publisher _publisher;

        public PublisherEditForm(string publisherId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);

            _publisher = _publishersRepository.GetPublisherById(int.Parse(publisherId));

            FillDetails();
        }

        private void FillDetails()
        {
            nameOfPublisherTextBox.Text = _publisher.Name;

            booksCheckedListBox.Items.Clear();
            foreach (var book in _publisher.PublishedBooks)
                booksCheckedListBox.Items.Add(book.Name, true);
            foreach (var book in _publishersRepository.GetAllBooksWithoutAPublisher())
                booksCheckedListBox.Items.Add(book.Name);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var nameOfPublisher = nameOfPublisherTextBox.Text;
            var selectedBooks = booksCheckedListBox.CheckedItems;

            var isSaved = _publishersRepository.AddOrEditAPublisher(nameOfPublisher, selectedBooks, _publisher.PublisherId);

            if (!isSaved)
                MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Izdavac uspjesno spremljen!", "Message", MessageBoxButtons.OK,
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
