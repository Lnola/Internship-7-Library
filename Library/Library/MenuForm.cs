using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Presentation.AuthorsForms;
using Library.Presentation.BookBorrowsForms;
using Library.Presentation.BooksForms;
using Library.Presentation.PublishersForms;
using Library.Presentation.StudentsForms;

namespace Library
{
    public partial class library : Form
    {
        public library()
        {
            InitializeComponent();
        }

        private void ShowBooksForm(object sender, EventArgs e)
        {
            var booksList = new BooksList();
            booksList.ShowDialog();
        }

        private void ShowAuthorsForm(object sender, EventArgs e)
        {
            var authorsList = new AuthorsList();
            authorsList.ShowDialog();
        }

        private void ShowPublishersForm(object sender, EventArgs e)
        {
            var publishersList = new PublishersList();
            publishersList.ShowDialog();
        }

        private void ShowStudentsForm(object sender, EventArgs e)
        {
            var studentsList = new StudentsList();
            studentsList.ShowDialog();
        }

        private void ShowBookBorrowsForm(object sender, EventArgs e)
        {
            var bookBorrowsList = new BookBorrowsList();
            bookBorrowsList.ShowDialog();
        }
    }
}
