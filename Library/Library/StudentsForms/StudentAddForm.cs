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

namespace Library.Presentation.StudentsForms
{
    public partial class StudentAddForm : Form
    {
        private StudentsRepository _studentsRepository;

        public StudentAddForm()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            FillDetails();
        }

        private void FillDetails()
        {
            genderListBox.Items.Add(StudentGender.M);
            genderListBox.Items.Add(StudentGender.F);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var dateOfBirth = dateOfBirthDTP.Value;
            var gender = genderListBox.SelectedItem as string;
            var grade = gradeTextBox.Text;

            var isSaved = _studentsRepository.AddOrEditAStudent(firstName, lastName, dateOfBirth, gender, grade, null);

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
