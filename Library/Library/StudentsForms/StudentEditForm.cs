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

namespace Library.Presentation.StudentsForms
{
    public partial class StudentEditForm : Form
    {
        private StudentsRepository _studentsRepository;
        private Student _student;

        public StudentEditForm(string studentId)
        {
            InitializeComponent();
            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            _student = _studentsRepository.GetStudentById(studentId);

            FillDetails();
        }

        private void FillDetails()
        {
            genderListBox.Items.Add(StudentGender.M);
            genderListBox.Items.Add(StudentGender.F);

            firstNameTextBox.Text = _student.FirstName;
            lastNameTextBox.Text = _student.LastName;
            dateOfBirthDTP.Value = _student.DateOfBirth;
            genderListBox.SelectedItem = _student.Gender;
            gradeTextBox.Text = _student.StudentGrade;
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var dateOfBirth = dateOfBirthDTP.Value;
            var gender = genderListBox.SelectedItem as string;
            var grade = gradeTextBox.Text;

            var isSaved = _studentsRepository.AddOrEditAStudent(firstName, lastName, dateOfBirth, gender, grade, _student.StudentId);

            if (!isSaved)
                MessageBox.Show("Pogreska pri unosu. Sva polja moraju imati sadrzaj! Razred mora biti formata broj.slovo", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Ucenik uspjesno spremljen!", "Message", MessageBoxButtons.OK,
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
