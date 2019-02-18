namespace Library.Presentation.StudentsForms
{
    partial class StudentDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.openEditFormBtn = new System.Windows.Forms.Button();
            this.studentDetailsLbl = new System.Windows.Forms.Label();
            this.nameOfStudentTextBox = new System.Windows.Forms.TextBox();
            this.nameOfStudentLbl = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBrithLbl = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.greadeLbl = new System.Windows.Forms.Label();
            this.borrowedBooksLbl = new System.Windows.Forms.Label();
            this.borrowedBooksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(182, 309);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 2;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // openEditFormBtn
            // 
            this.openEditFormBtn.Location = new System.Drawing.Point(34, 309);
            this.openEditFormBtn.Name = "openEditFormBtn";
            this.openEditFormBtn.Size = new System.Drawing.Size(119, 28);
            this.openEditFormBtn.TabIndex = 1;
            this.openEditFormBtn.Text = "Promjeni detalje";
            this.openEditFormBtn.UseVisualStyleBackColor = true;
            this.openEditFormBtn.Click += new System.EventHandler(this.ShowEditForm);
            // 
            // studentDetailsLbl
            // 
            this.studentDetailsLbl.AutoSize = true;
            this.studentDetailsLbl.Location = new System.Drawing.Point(119, 27);
            this.studentDetailsLbl.Name = "studentDetailsLbl";
            this.studentDetailsLbl.Size = new System.Drawing.Size(86, 13);
            this.studentDetailsLbl.TabIndex = 9;
            this.studentDetailsLbl.Text = "Detalji o uceniku";
            // 
            // nameOfStudentTextBox
            // 
            this.nameOfStudentTextBox.Location = new System.Drawing.Point(111, 62);
            this.nameOfStudentTextBox.Name = "nameOfStudentTextBox";
            this.nameOfStudentTextBox.ReadOnly = true;
            this.nameOfStudentTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameOfStudentTextBox.TabIndex = 8;
            // 
            // nameOfStudentLbl
            // 
            this.nameOfStudentLbl.AutoSize = true;
            this.nameOfStudentLbl.Location = new System.Drawing.Point(31, 65);
            this.nameOfStudentLbl.Name = "nameOfStudentLbl";
            this.nameOfStudentLbl.Size = new System.Drawing.Size(74, 13);
            this.nameOfStudentLbl.TabIndex = 7;
            this.nameOfStudentLbl.Text = "Ime i prezime: ";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(111, 100);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.ReadOnly = true;
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(189, 20);
            this.dateOfBirthTextBox.TabIndex = 15;
            // 
            // dateOfBrithLbl
            // 
            this.dateOfBrithLbl.AutoSize = true;
            this.dateOfBrithLbl.Location = new System.Drawing.Point(31, 103);
            this.dateOfBrithLbl.Name = "dateOfBrithLbl";
            this.dateOfBrithLbl.Size = new System.Drawing.Size(79, 13);
            this.dateOfBrithLbl.TabIndex = 14;
            this.dateOfBrithLbl.Text = "Datum rodenja:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(174, 138);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(41, 20);
            this.genderTextBox.TabIndex = 17;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(137, 141);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(31, 13);
            this.genderLbl.TabIndex = 16;
            this.genderLbl.Text = "Spol:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(265, 138);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(35, 20);
            this.gradeTextBox.TabIndex = 19;
            // 
            // greadeLbl
            // 
            this.greadeLbl.AutoSize = true;
            this.greadeLbl.Location = new System.Drawing.Point(221, 141);
            this.greadeLbl.Name = "greadeLbl";
            this.greadeLbl.Size = new System.Drawing.Size(44, 13);
            this.greadeLbl.TabIndex = 18;
            this.greadeLbl.Text = "Razred:";
            // 
            // borrowedBooksLbl
            // 
            this.borrowedBooksLbl.AutoSize = true;
            this.borrowedBooksLbl.Location = new System.Drawing.Point(31, 141);
            this.borrowedBooksLbl.Name = "borrowedBooksLbl";
            this.borrowedBooksLbl.Size = new System.Drawing.Size(89, 13);
            this.borrowedBooksLbl.TabIndex = 20;
            this.borrowedBooksLbl.Text = "Posudene knjige:";
            // 
            // borrowedBooksListBox
            // 
            this.borrowedBooksListBox.FormattingEnabled = true;
            this.borrowedBooksListBox.Location = new System.Drawing.Point(34, 172);
            this.borrowedBooksListBox.Name = "borrowedBooksListBox";
            this.borrowedBooksListBox.Size = new System.Drawing.Size(265, 108);
            this.borrowedBooksListBox.TabIndex = 21;
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.borrowedBooksListBox);
            this.Controls.Add(this.borrowedBooksLbl);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.greadeLbl);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.dateOfBrithLbl);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.openEditFormBtn);
            this.Controls.Add(this.studentDetailsLbl);
            this.Controls.Add(this.nameOfStudentTextBox);
            this.Controls.Add(this.nameOfStudentLbl);
            this.Name = "StudentDetailsForm";
            this.Text = "StudentDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button openEditFormBtn;
        private System.Windows.Forms.Label studentDetailsLbl;
        private System.Windows.Forms.TextBox nameOfStudentTextBox;
        private System.Windows.Forms.Label nameOfStudentLbl;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.Label dateOfBrithLbl;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label greadeLbl;
        private System.Windows.Forms.Label borrowedBooksLbl;
        private System.Windows.Forms.ListBox borrowedBooksListBox;
    }
}