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

namespace Library.Presentation.StudentsForms
{
    public partial class StudentsList : Form
    {
        private StudentsRepository _studentsRepository;

        public StudentsList()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            FillStudentsListBox();
        }

        private void FillStudentsListBox()
        {
            studentsListBox.Items.Clear();

            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            foreach (var student in _studentsRepository.GetAllStudents())
                studentsListBox.Items.Add($"{student.StudentId}. {student.FirstName} {student.LastName}");
        }

        private void ShowStudentDetailsForm(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi ucenika!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var studentDetails = new StudentDetailsForm(studentsListBox.SelectedItem.ToString().OnlyNumbers());
                studentDetails.ShowDialog();
                FillStudentsListBox();
            }
        }

        private void ShowStudentAddForm(object sender, EventArgs e)
        {
            var studentAdd = new StudentAddForm();
            studentAdd.ShowDialog();
            FillStudentsListBox();
        }

        private void ShowStudentEditForm(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi ucenika!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var studentEdit = new StudentEditForm(studentsListBox.SelectedItem.ToString().OnlyNumbers());
                studentEdit.ShowDialog();
                FillStudentsListBox();
            }
        }

        private void ShowStudentDeleteForm(object sender, EventArgs e)
        {
            if (studentsListBox.SelectedIndex == -1)
                MessageBox.Show("Odaberi ucenika!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var dialogResult = MessageBox.Show("Zelis li izbrisati ovog ucenika?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    _studentsRepository.RemoveAStudent(studentsListBox.SelectedItem.ToString().OnlyNumbers());

                    MessageBox.Show("Ucenik uspjesno izbrisan! Time su sve knjige koje je ucenik posudio vracene!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillStudentsListBox();
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
