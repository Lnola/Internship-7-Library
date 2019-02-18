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
    public partial class PublisherDetailsForm : Form
    {
        private PublishersRepository _publishersRepository;
        private Publisher _publisher;

        public PublisherDetailsForm(string publisherId)
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

            allBooksListBox.Items.Clear();
            foreach (var book in _publisher.PublishedBooks)
                allBooksListBox.Items.Add(book.Name);
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            var publisherEdit = new PublisherEditForm(_publisher.PublisherId.ToString());
            publisherEdit.ShowDialog();
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
