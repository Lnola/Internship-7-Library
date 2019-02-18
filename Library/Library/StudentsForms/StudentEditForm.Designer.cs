namespace Library.Presentation.StudentsForms
{
    partial class StudentEditForm
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
            this.studentEditLbl = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.genderListBox = new System.Windows.Forms.ListBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.greadeLbl = new System.Windows.Forms.Label();
            this.dateOfBrithLbl = new System.Windows.Forms.Label();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentEditLbl
            // 
            this.studentEditLbl.AutoSize = true;
            this.studentEditLbl.Location = new System.Drawing.Point(115, 24);
            this.studentEditLbl.Name = "studentEditLbl";
            this.studentEditLbl.Size = new System.Drawing.Size(85, 13);
            this.studentEditLbl.TabIndex = 41;
            this.studentEditLbl.Text = "Promjena detalja";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(114, 95);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(34, 98);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(47, 13);
            this.lastNameLbl.TabIndex = 52;
            this.lastNameLbl.Text = "Prezime:";
            // 
            // genderListBox
            // 
            this.genderListBox.FormattingEnabled = true;
            this.genderListBox.Location = new System.Drawing.Point(84, 177);
            this.genderListBox.Name = "genderListBox";
            this.genderListBox.Size = new System.Drawing.Size(35, 17);
            this.genderListBox.TabIndex = 4;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(34, 181);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(31, 13);
            this.genderLbl.TabIndex = 50;
            this.genderLbl.Text = "Spol:";
            // 
            // dateOfBirthDTP
            // 
            this.dateOfBirthDTP.Location = new System.Drawing.Point(114, 130);
            this.dateOfBirthDTP.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthDTP.Name = "dateOfBirthDTP";
            this.dateOfBirthDTP.Size = new System.Drawing.Size(189, 20);
            this.dateOfBirthDTP.TabIndex = 3;
            this.dateOfBirthDTP.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(84, 209);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(35, 20);
            this.gradeTextBox.TabIndex = 5;
            // 
            // greadeLbl
            // 
            this.greadeLbl.AutoSize = true;
            this.greadeLbl.Location = new System.Drawing.Point(34, 216);
            this.greadeLbl.Name = "greadeLbl";
            this.greadeLbl.Size = new System.Drawing.Size(44, 13);
            this.greadeLbl.TabIndex = 47;
            this.greadeLbl.Text = "Razred:";
            // 
            // dateOfBrithLbl
            // 
            this.dateOfBrithLbl.AutoSize = true;
            this.dateOfBrithLbl.Location = new System.Drawing.Point(34, 136);
            this.dateOfBrithLbl.Name = "dateOfBrithLbl";
            this.dateOfBrithLbl.Size = new System.Drawing.Size(79, 13);
            this.dateOfBrithLbl.TabIndex = 46;
            this.dateOfBrithLbl.Text = "Datum rodenja:";
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(158, 205);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(145, 28);
            this.closeFormBtn.TabIndex = 7;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(158, 170);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(144, 29);
            this.saveChangesBtn.TabIndex = 6;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(114, 60);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(34, 63);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(27, 13);
            this.firstNameLbl.TabIndex = 42;
            this.firstNameLbl.Text = "Ime:";
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 256);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.genderListBox);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.dateOfBirthDTP);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.greadeLbl);
            this.Controls.Add(this.dateOfBrithLbl);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.studentEditLbl);
            this.Name = "StudentEditForm";
            this.Text = "StudentEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label studentEditLbl;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.ListBox genderListBox;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label greadeLbl;
        private System.Windows.Forms.Label dateOfBrithLbl;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLbl;
    }
}