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
using Library.Presentation.PublishersForms;

namespace Library.Presentation.StudentsForms
{
    public partial class StudentDetailsForm : Form
    {
        private StudentsRepository _studentsRepository;
        private Student _student;

        public StudentDetailsForm(string studentId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            _student = _studentsRepository.GetStudentById(studentId);

            FillDetails();
        }

        private void FillDetails()
        {
            nameOfStudentTextBox.Text = $"{_student.FirstName} {_student.LastName}";
            dateOfBirthTextBox.Text = _student.DateOfBirth.ToString("dd-MM-yyyy");
            genderTextBox.Text = _student.Gender.ToString();
            gradeTextBox.Text = _student.StudentGrade;

            foreach (var bookBorrow in _studentsRepository.GetBookBorrowsByStudentId(_student.StudentId))
                borrowedBooksListBox.Items.Add(bookBorrow.Book.Name);

            if (_studentsRepository.GetBookBorrowsByStudentId(_student.StudentId).Count == 0)
                borrowedBooksListBox.Items.Add("Ucenik nije posudio nijednu knjigu");
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            var studentEdit = new StudentEditForm(_student.StudentId.ToString());
            studentEdit.ShowDialog();
            Close();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
