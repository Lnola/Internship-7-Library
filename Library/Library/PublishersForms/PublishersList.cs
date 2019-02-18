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

namespace Library.Presentation.PublishersForms
{
    public partial class PublishersList : Form
    {
        private PublishersRepository _publishersRepository;

        public PublishersList()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);

            FillPublishersListBox();
        }

        private void FillPublishersListBox()
        {
            publishersListBox.Items.Clear();

            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);

            foreach (var publisher in _publishersRepository.GetAllPublishers())
                publishersListBox.Items.Add($"{publisher.PublisherId}. {publisher.Name}");
        }

        private void ShowPublisherDetailsForm(object sender, EventArgs e)
        {
            if (publishersListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi izdavaca!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var publisherDetails = new PublisherDetailsForm(publishersListBox.SelectedItem.ToString().OnlyNumbers());
                publisherDetails.ShowDialog();
                FillPublishersListBox();
            }
        }

        private void ShowPublisherAddForm(object sender, EventArgs e)
        {
            if (_publishersRepository.GetAllBooksWithoutAPublisher().Count != 0)
            {
                var publisherAdd = new PublisherAddForm();
                publisherAdd.ShowDialog();
                FillPublishersListBox();
            }
            else
                MessageBox.Show(
                    "Ne postoji nijedna knjiga bez izdavaca. Kako bi dodao novog izdavaca prvo dodaj novu knjigu!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ShowPublisherEditForm(object sender, EventArgs e)
        {
            if (publishersListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi izdavaca!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var publisherEdit = new PublisherEditForm(publishersListBox.SelectedItem.ToString().OnlyNumbers());
                publisherEdit.ShowDialog();
                FillPublishersListBox();
            }
        }

        private void ShowPublisherDeleteForm(object sender, EventArgs e)
        {
            if (publishersListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi izdavaca!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (_publishersRepository.GetAllPublishers().Count == 0)
                MessageBox.Show("Mora postojati barem jedan izdavac", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var dialogResult = MessageBox.Show("Zelis li izbrisati ovog izdavaca?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    _publishersRepository.RemoveAPublisher(publishersListBox.SelectedItem.ToString().OnlyNumbers());

                    MessageBox.Show("Izdavac uspjesno izbrisan! Time su neke od knjiga ostale bez izdavaca!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillPublishersListBox();
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
