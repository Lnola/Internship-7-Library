namespace Library.Presentation.BookBorrowsForms
{
    partial class BookBorrowEditForm
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
            this.allStudentsListBox = new System.Windows.Forms.ListBox();
            this.bookEditLbl = new System.Windows.Forms.Label();
            this.allStudentsLbl = new System.Windows.Forms.Label();
            this.allBooksLbl = new System.Windows.Forms.Label();
            this.allBooksListBox = new System.Windows.Forms.ListBox();
            this.dateOfBorrowDTP = new System.Windows.Forms.DateTimePicker();
            this.dateOfBorrowLbl = new System.Windows.Forms.Label();
            this.dateOfReturnLbl = new System.Windows.Forms.Label();
            this.dateOfReturnDTP = new System.Windows.Forms.DateTimePicker();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.addReturnDateCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // allStudentsListBox
            // 
            this.allStudentsListBox.FormattingEnabled = true;
            this.allStudentsListBox.Location = new System.Drawing.Point(28, 84);
            this.allStudentsListBox.Name = "allStudentsListBox";
            this.allStudentsListBox.Size = new System.Drawing.Size(278, 134);
            this.allStudentsListBox.TabIndex = 1;
            // 
            // bookEditLbl
            // 
            this.bookEditLbl.AutoSize = true;
            this.bookEditLbl.Location = new System.Drawing.Point(114, 21);
            this.bookEditLbl.Name = "bookEditLbl";
            this.bookEditLbl.Size = new System.Drawing.Size(95, 13);
            this.bookEditLbl.TabIndex = 1;
            this.bookEditLbl.Text = "Promjena posudbe";
            // 
            // allStudentsLbl
            // 
            this.allStudentsLbl.AutoSize = true;
            this.allStudentsLbl.Location = new System.Drawing.Point(25, 58);
            this.allStudentsLbl.Name = "allStudentsLbl";
            this.allStudentsLbl.Size = new System.Drawing.Size(95, 13);
            this.allStudentsLbl.TabIndex = 2;
            this.allStudentsLbl.Text = "Lista svih ucenika:";
            // 
            // allBooksLbl
            // 
            this.allBooksLbl.AutoSize = true;
            this.allBooksLbl.Location = new System.Drawing.Point(25, 231);
            this.allBooksLbl.Name = "allBooksLbl";
            this.allBooksLbl.Size = new System.Drawing.Size(85, 13);
            this.allBooksLbl.TabIndex = 4;
            this.allBooksLbl.Text = "Lista svih knjiga:";
            // 
            // allBooksListBox
            // 
            this.allBooksListBox.FormattingEnabled = true;
            this.allBooksListBox.Location = new System.Drawing.Point(28, 257);
            this.allBooksListBox.Name = "allBooksListBox";
            this.allBooksListBox.Size = new System.Drawing.Size(278, 134);
            this.allBooksListBox.TabIndex = 2;
            // 
            // dateOfBorrowDTP
            // 
            this.dateOfBorrowDTP.Location = new System.Drawing.Point(128, 410);
            this.dateOfBorrowDTP.MinDate = new System.DateTime(2019, 2, 17, 0, 0, 0, 0);
            this.dateOfBorrowDTP.Name = "dateOfBorrowDTP";
            this.dateOfBorrowDTP.Size = new System.Drawing.Size(178, 20);
            this.dateOfBorrowDTP.TabIndex = 3;
            // 
            // dateOfBorrowLbl
            // 
            this.dateOfBorrowLbl.AutoSize = true;
            this.dateOfBorrowLbl.Location = new System.Drawing.Point(25, 416);
            this.dateOfBorrowLbl.Name = "dateOfBorrowLbl";
            this.dateOfBorrowLbl.Size = new System.Drawing.Size(85, 13);
            this.dateOfBorrowLbl.TabIndex = 6;
            this.dateOfBorrowLbl.Text = "Datum posudbe:";
            // 
            // dateOfReturnLbl
            // 
            this.dateOfReturnLbl.AutoSize = true;
            this.dateOfReturnLbl.Location = new System.Drawing.Point(25, 490);
            this.dateOfReturnLbl.Name = "dateOfReturnLbl";
            this.dateOfReturnLbl.Size = new System.Drawing.Size(85, 13);
            this.dateOfReturnLbl.TabIndex = 8;
            this.dateOfReturnLbl.Text = "Datum vracanja:";
            // 
            // dateOfReturnDTP
            // 
            this.dateOfReturnDTP.Location = new System.Drawing.Point(128, 484);
            this.dateOfReturnDTP.MinDate = new System.DateTime(2019, 2, 17, 0, 0, 0, 0);
            this.dateOfReturnDTP.Name = "dateOfReturnDTP";
            this.dateOfReturnDTP.Size = new System.Drawing.Size(178, 20);
            this.dateOfReturnDTP.TabIndex = 5;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(38, 527);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(109, 29);
            this.saveChangesBtn.TabIndex = 6;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(181, 527);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(109, 29);
            this.closeFormBtn.TabIndex = 7;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // addReturnDateCB
            // 
            this.addReturnDateCB.AutoSize = true;
            this.addReturnDateCB.Location = new System.Drawing.Point(28, 452);
            this.addReturnDateCB.Name = "addReturnDateCB";
            this.addReturnDateCB.Size = new System.Drawing.Size(185, 17);
            this.addReturnDateCB.TabIndex = 4;
            this.addReturnDateCB.Text = "Zelim spremiti dan vracanja knjige";
            this.addReturnDateCB.UseVisualStyleBackColor = true;
            // 
            // BookBorrowEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 580);
            this.Controls.Add(this.addReturnDateCB);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.dateOfReturnLbl);
            this.Controls.Add(this.dateOfReturnDTP);
            this.Controls.Add(this.dateOfBorrowLbl);
            this.Controls.Add(this.dateOfBorrowDTP);
            this.Controls.Add(this.allBooksLbl);
            this.Controls.Add(this.allBooksListBox);
            this.Controls.Add(this.allStudentsLbl);
            this.Controls.Add(this.bookEditLbl);
            this.Controls.Add(this.allStudentsListBox);
            this.Name = "BookBorrowEditForm";
            this.Text = "BookBorrowEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allStudentsListBox;
        private System.Windows.Forms.Label bookEditLbl;
        private System.Windows.Forms.Label allStudentsLbl;
        private System.Windows.Forms.Label allBooksLbl;
        private System.Windows.Forms.ListBox allBooksListBox;
        private System.Windows.Forms.DateTimePicker dateOfBorrowDTP;
        private System.Windows.Forms.Label dateOfBorrowLbl;
        private System.Windows.Forms.Label dateOfReturnLbl;
        private System.Windows.Forms.DateTimePicker dateOfReturnDTP;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.CheckBox addReturnDateCB;
    }
}