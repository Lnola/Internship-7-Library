namespace Library.Presentation.StudentsForms
{
    partial class StudentAddForm
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
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.greadeLbl = new System.Windows.Forms.Label();
            this.dateOfBrithLbl = new System.Windows.Forms.Label();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.studentAddLbl = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.genderListBox = new System.Windows.Forms.ListBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(81, 211);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(35, 20);
            this.gradeTextBox.TabIndex = 5;
            // 
            // greadeLbl
            // 
            this.greadeLbl.AutoSize = true;
            this.greadeLbl.Location = new System.Drawing.Point(31, 218);
            this.greadeLbl.Name = "greadeLbl";
            this.greadeLbl.Size = new System.Drawing.Size(44, 13);
            this.greadeLbl.TabIndex = 31;
            this.greadeLbl.Text = "Razred:";
            // 
            // dateOfBrithLbl
            // 
            this.dateOfBrithLbl.AutoSize = true;
            this.dateOfBrithLbl.Location = new System.Drawing.Point(31, 138);
            this.dateOfBrithLbl.Name = "dateOfBrithLbl";
            this.dateOfBrithLbl.Size = new System.Drawing.Size(79, 13);
            this.dateOfBrithLbl.TabIndex = 27;
            this.dateOfBrithLbl.Text = "Datum rodenja:";
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(155, 207);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(145, 28);
            this.closeFormBtn.TabIndex = 7;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(155, 172);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(144, 29);
            this.saveChangesBtn.TabIndex = 6;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // studentAddLbl
            // 
            this.studentAddLbl.AutoSize = true;
            this.studentAddLbl.Location = new System.Drawing.Point(115, 23);
            this.studentAddLbl.Name = "studentAddLbl";
            this.studentAddLbl.Size = new System.Drawing.Size(100, 13);
            this.studentAddLbl.TabIndex = 24;
            this.studentAddLbl.Text = "Dodavanje ucenika";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(111, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(31, 65);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(27, 13);
            this.firstNameLbl.TabIndex = 22;
            this.firstNameLbl.Text = "Ime:";
            // 
            // dateOfBirthDTP
            // 
            this.dateOfBirthDTP.Location = new System.Drawing.Point(111, 132);
            this.dateOfBirthDTP.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthDTP.Name = "dateOfBirthDTP";
            this.dateOfBirthDTP.Size = new System.Drawing.Size(189, 20);
            this.dateOfBirthDTP.TabIndex = 3;
            this.dateOfBirthDTP.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // genderListBox
            // 
            this.genderListBox.FormattingEnabled = true;
            this.genderListBox.Location = new System.Drawing.Point(81, 179);
            this.genderListBox.Name = "genderListBox";
            this.genderListBox.Size = new System.Drawing.Size(35, 17);
            this.genderListBox.TabIndex = 4;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(31, 183);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(31, 13);
            this.genderLbl.TabIndex = 37;
            this.genderLbl.Text = "Spol:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(111, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(31, 100);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(47, 13);
            this.lastNameLbl.TabIndex = 39;
            this.lastNameLbl.Text = "Prezime:";
            // 
            // StudentAddForm
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
            this.Controls.Add(this.studentAddLbl);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLbl);
            this.Name = "StudentAddForm";
            this.Text = "StudentAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label greadeLbl;
        private System.Windows.Forms.Label dateOfBrithLbl;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Label studentAddLbl;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.ListBox genderListBox;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLbl;
    }
}