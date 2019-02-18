namespace Library.Presentation.BookBorrowsForms
{
    partial class BookBorrowAddForm
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
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.dateOfBorrowLbl = new System.Windows.Forms.Label();
            this.dateOfBorrowDTP = new System.Windows.Forms.DateTimePicker();
            this.allBooksLbl = new System.Windows.Forms.Label();
            this.allBooksListBox = new System.Windows.Forms.ListBox();
            this.allStudentsLbl = new System.Windows.Forms.Label();
            this.bookAddLbl = new System.Windows.Forms.Label();
            this.allStudentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(182, 461);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(109, 29);
            this.closeFormBtn.TabIndex = 5;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseFrom);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(39, 461);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(109, 29);
            this.saveChangesBtn.TabIndex = 4;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // dateOfBorrowLbl
            // 
            this.dateOfBorrowLbl.AutoSize = true;
            this.dateOfBorrowLbl.Location = new System.Drawing.Point(25, 418);
            this.dateOfBorrowLbl.Name = "dateOfBorrowLbl";
            this.dateOfBorrowLbl.Size = new System.Drawing.Size(85, 13);
            this.dateOfBorrowLbl.TabIndex = 17;
            this.dateOfBorrowLbl.Text = "Datum posudbe:";
            // 
            // dateOfBorrowDTP
            // 
            this.dateOfBorrowDTP.Location = new System.Drawing.Point(128, 412);
            this.dateOfBorrowDTP.MinDate = new System.DateTime(2019, 2, 17, 0, 0, 0, 0);
            this.dateOfBorrowDTP.Name = "dateOfBorrowDTP";
            this.dateOfBorrowDTP.Size = new System.Drawing.Size(178, 20);
            this.dateOfBorrowDTP.TabIndex = 3;
            // 
            // allBooksLbl
            // 
            this.allBooksLbl.AutoSize = true;
            this.allBooksLbl.Location = new System.Drawing.Point(25, 233);
            this.allBooksLbl.Name = "allBooksLbl";
            this.allBooksLbl.Size = new System.Drawing.Size(85, 13);
            this.allBooksLbl.TabIndex = 15;
            this.allBooksLbl.Text = "Lista svih knjiga:";
            // 
            // allBooksListBox
            // 
            this.allBooksListBox.FormattingEnabled = true;
            this.allBooksListBox.Location = new System.Drawing.Point(28, 259);
            this.allBooksListBox.Name = "allBooksListBox";
            this.allBooksListBox.Size = new System.Drawing.Size(278, 134);
            this.allBooksListBox.TabIndex = 2;
            // 
            // allStudentsLbl
            // 
            this.allStudentsLbl.AutoSize = true;
            this.allStudentsLbl.Location = new System.Drawing.Point(25, 60);
            this.allStudentsLbl.Name = "allStudentsLbl";
            this.allStudentsLbl.Size = new System.Drawing.Size(95, 13);
            this.allStudentsLbl.TabIndex = 13;
            this.allStudentsLbl.Text = "Lista svih ucenika:";
            // 
            // bookAddLbl
            // 
            this.bookAddLbl.AutoSize = true;
            this.bookAddLbl.Location = new System.Drawing.Point(114, 23);
            this.bookAddLbl.Name = "bookAddLbl";
            this.bookAddLbl.Size = new System.Drawing.Size(103, 13);
            this.bookAddLbl.TabIndex = 12;
            this.bookAddLbl.Text = "Dodavanje posudbe";
            // 
            // allStudentsListBox
            // 
            this.allStudentsListBox.FormattingEnabled = true;
            this.allStudentsListBox.Location = new System.Drawing.Point(28, 86);
            this.allStudentsListBox.Name = "allStudentsListBox";
            this.allStudentsListBox.Size = new System.Drawing.Size(278, 134);
            this.allStudentsListBox.TabIndex = 1;
            // 
            // BookBorrowAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 515);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.dateOfBorrowLbl);
            this.Controls.Add(this.dateOfBorrowDTP);
            this.Controls.Add(this.allBooksLbl);
            this.Controls.Add(this.allBooksListBox);
            this.Controls.Add(this.allStudentsLbl);
            this.Controls.Add(this.bookAddLbl);
            this.Controls.Add(this.allStudentsListBox);
            this.Name = "BookBorrowAddForm";
            this.Text = "BookBorrowAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Label dateOfBorrowLbl;
        private System.Windows.Forms.DateTimePicker dateOfBorrowDTP;
        private System.Windows.Forms.Label allBooksLbl;
        private System.Windows.Forms.ListBox allBooksListBox;
        private System.Windows.Forms.Label allStudentsLbl;
        private System.Windows.Forms.Label bookAddLbl;
        private System.Windows.Forms.ListBox allStudentsListBox;
    }
}