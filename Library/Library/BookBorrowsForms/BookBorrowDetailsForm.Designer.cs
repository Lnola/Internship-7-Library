namespace Library.Presentation.BookBorrowsForms
{
    partial class BookBorrowDetailsForm
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
            this.bookBorrowDetailsLbl = new System.Windows.Forms.Label();
            this.nameOfStudentTextBox = new System.Windows.Forms.TextBox();
            this.nameOfStudentLbl = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.nameOfBookLbl = new System.Windows.Forms.Label();
            this.dateOfBorrowTextBox = new System.Windows.Forms.TextBox();
            this.dateBorrowedLbl = new System.Windows.Forms.Label();
            this.dateOfReturnTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(198, 215);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 2;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // openEditFormBtn
            // 
            this.openEditFormBtn.Location = new System.Drawing.Point(33, 215);
            this.openEditFormBtn.Name = "openEditFormBtn";
            this.openEditFormBtn.Size = new System.Drawing.Size(119, 28);
            this.openEditFormBtn.TabIndex = 1;
            this.openEditFormBtn.Text = "Promjeni detalje";
            this.openEditFormBtn.UseVisualStyleBackColor = true;
            this.openEditFormBtn.Click += new System.EventHandler(this.ShowEditForm);
            // 
            // bookBorrowDetailsLbl
            // 
            this.bookBorrowDetailsLbl.AutoSize = true;
            this.bookBorrowDetailsLbl.Location = new System.Drawing.Point(124, 22);
            this.bookBorrowDetailsLbl.Name = "bookBorrowDetailsLbl";
            this.bookBorrowDetailsLbl.Size = new System.Drawing.Size(80, 13);
            this.bookBorrowDetailsLbl.TabIndex = 23;
            this.bookBorrowDetailsLbl.Text = "Detalji posudbe";
            // 
            // nameOfStudentTextBox
            // 
            this.nameOfStudentTextBox.Location = new System.Drawing.Point(127, 59);
            this.nameOfStudentTextBox.Name = "nameOfStudentTextBox";
            this.nameOfStudentTextBox.ReadOnly = true;
            this.nameOfStudentTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameOfStudentTextBox.TabIndex = 22;
            // 
            // nameOfStudentLbl
            // 
            this.nameOfStudentLbl.AutoSize = true;
            this.nameOfStudentLbl.Location = new System.Drawing.Point(30, 62);
            this.nameOfStudentLbl.Name = "nameOfStudentLbl";
            this.nameOfStudentLbl.Size = new System.Drawing.Size(74, 13);
            this.nameOfStudentLbl.TabIndex = 21;
            this.nameOfStudentLbl.Text = "Ime i prezime: ";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(127, 95);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.bookNameTextBox.TabIndex = 29;
            // 
            // nameOfBookLbl
            // 
            this.nameOfBookLbl.AutoSize = true;
            this.nameOfBookLbl.Location = new System.Drawing.Point(30, 98);
            this.nameOfBookLbl.Name = "nameOfBookLbl";
            this.nameOfBookLbl.Size = new System.Drawing.Size(61, 13);
            this.nameOfBookLbl.TabIndex = 28;
            this.nameOfBookLbl.Text = "Ime knjige: ";
            // 
            // dateOfBorrowTextBox
            // 
            this.dateOfBorrowTextBox.Location = new System.Drawing.Point(127, 130);
            this.dateOfBorrowTextBox.Name = "dateOfBorrowTextBox";
            this.dateOfBorrowTextBox.ReadOnly = true;
            this.dateOfBorrowTextBox.Size = new System.Drawing.Size(189, 20);
            this.dateOfBorrowTextBox.TabIndex = 31;
            // 
            // dateBorrowedLbl
            // 
            this.dateBorrowedLbl.AutoSize = true;
            this.dateBorrowedLbl.Location = new System.Drawing.Point(30, 133);
            this.dateBorrowedLbl.Name = "dateBorrowedLbl";
            this.dateBorrowedLbl.Size = new System.Drawing.Size(88, 13);
            this.dateBorrowedLbl.TabIndex = 30;
            this.dateBorrowedLbl.Text = "Datum posudbe: ";
            // 
            // dateOfReturnTextBox
            // 
            this.dateOfReturnTextBox.Location = new System.Drawing.Point(127, 165);
            this.dateOfReturnTextBox.Name = "dateOfReturnTextBox";
            this.dateOfReturnTextBox.ReadOnly = true;
            this.dateOfReturnTextBox.Size = new System.Drawing.Size(189, 20);
            this.dateOfReturnTextBox.TabIndex = 33;
            // 
            // dateReturnedLbl
            // 
            this.dateReturnedLbl.AutoSize = true;
            this.dateReturnedLbl.Location = new System.Drawing.Point(30, 168);
            this.dateReturnedLbl.Name = "dateReturnedLbl";
            this.dateReturnedLbl.Size = new System.Drawing.Size(88, 13);
            this.dateReturnedLbl.TabIndex = 32;
            this.dateReturnedLbl.Text = "Datum vracanja: ";
            // 
            // BookBorrowDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 266);
            this.Controls.Add(this.dateOfReturnTextBox);
            this.Controls.Add(this.dateReturnedLbl);
            this.Controls.Add(this.dateOfBorrowTextBox);
            this.Controls.Add(this.dateBorrowedLbl);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.nameOfBookLbl);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.openEditFormBtn);
            this.Controls.Add(this.bookBorrowDetailsLbl);
            this.Controls.Add(this.nameOfStudentTextBox);
            this.Controls.Add(this.nameOfStudentLbl);
            this.Name = "BookBorrowDetailsForm";
            this.Text = "BookBorrowDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button closeFormBtn;
        protected System.Windows.Forms.Button openEditFormBtn;
        protected System.Windows.Forms.Label bookBorrowDetailsLbl;
        protected System.Windows.Forms.TextBox nameOfStudentTextBox;
        protected System.Windows.Forms.Label nameOfStudentLbl;
        protected System.Windows.Forms.TextBox bookNameTextBox;
        protected System.Windows.Forms.Label nameOfBookLbl;
        protected System.Windows.Forms.TextBox dateOfBorrowTextBox;
        protected System.Windows.Forms.Label dateBorrowedLbl;
        protected System.Windows.Forms.TextBox dateOfReturnTextBox;
        protected System.Windows.Forms.Label dateReturnedLbl;
    }
}