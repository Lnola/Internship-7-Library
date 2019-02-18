namespace Library.Presentation.BooksForms
{
    partial class BookAddForm
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
            this.genresListBox = new System.Windows.Forms.ListBox();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.numberOfPagesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPagesLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.booEditLbl = new System.Windows.Forms.Label();
            this.publishersListBox = new System.Windows.Forms.ListBox();
            this.publishersLbl = new System.Windows.Forms.Label();
            this.totalBooksTextBox = new System.Windows.Forms.TextBox();
            this.totalBooksLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genresListBox
            // 
            this.genresListBox.FormattingEnabled = true;
            this.genresListBox.Location = new System.Drawing.Point(32, 361);
            this.genresListBox.Name = "genresListBox";
            this.genresListBox.Size = new System.Drawing.Size(270, 82);
            this.genresListBox.TabIndex = 4;
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.Location = new System.Drawing.Point(33, 130);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(268, 82);
            this.authorsListBox.TabIndex = 2;
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(191, 505);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(111, 30);
            this.closeFormBtn.TabIndex = 8;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(32, 505);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(111, 30);
            this.saveChangesBtn.TabIndex = 7;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // numberOfPagesTextBox
            // 
            this.numberOfPagesTextBox.Location = new System.Drawing.Point(109, 459);
            this.numberOfPagesTextBox.Name = "numberOfPagesTextBox";
            this.numberOfPagesTextBox.Size = new System.Drawing.Size(49, 20);
            this.numberOfPagesTextBox.TabIndex = 5;
            // 
            // numberOfPagesLbl
            // 
            this.numberOfPagesLbl.AutoSize = true;
            this.numberOfPagesLbl.Location = new System.Drawing.Point(30, 462);
            this.numberOfPagesLbl.Name = "numberOfPagesLbl";
            this.numberOfPagesLbl.Size = new System.Drawing.Size(68, 13);
            this.numberOfPagesLbl.TabIndex = 32;
            this.numberOfPagesLbl.Text = "Broj stranica:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(30, 106);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(37, 13);
            this.authorLbl.TabIndex = 31;
            this.authorLbl.Text = "Autori:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(30, 336);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(32, 13);
            this.genreLbl.TabIndex = 30;
            this.genreLbl.Text = "Zanr:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(109, 67);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.bookTitleTextBox.TabIndex = 1;
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Location = new System.Drawing.Point(29, 70);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(74, 13);
            this.bookTitleLbl.TabIndex = 28;
            this.bookTitleLbl.Text = "Naslov knjige:";
            // 
            // booEditLbl
            // 
            this.booEditLbl.AutoSize = true;
            this.booEditLbl.Location = new System.Drawing.Point(116, 26);
            this.booEditLbl.Name = "booEditLbl";
            this.booEditLbl.Size = new System.Drawing.Size(90, 13);
            this.booEditLbl.TabIndex = 27;
            this.booEditLbl.Text = "Dodavanje knjige";
            // 
            // publishersListBox
            // 
            this.publishersListBox.FormattingEnabled = true;
            this.publishersListBox.Location = new System.Drawing.Point(32, 243);
            this.publishersListBox.Name = "publishersListBox";
            this.publishersListBox.Size = new System.Drawing.Size(268, 82);
            this.publishersListBox.TabIndex = 3;
            // 
            // publishersLbl
            // 
            this.publishersLbl.AutoSize = true;
            this.publishersLbl.Location = new System.Drawing.Point(29, 219);
            this.publishersLbl.Name = "publishersLbl";
            this.publishersLbl.Size = new System.Drawing.Size(50, 13);
            this.publishersLbl.TabIndex = 38;
            this.publishersLbl.Text = "Izdavaci:";
            // 
            // totalBooksTextBox
            // 
            this.totalBooksTextBox.Location = new System.Drawing.Point(253, 459);
            this.totalBooksTextBox.Name = "totalBooksTextBox";
            this.totalBooksTextBox.Size = new System.Drawing.Size(49, 20);
            this.totalBooksTextBox.TabIndex = 6;
            // 
            // totalBooksLbl
            // 
            this.totalBooksLbl.AutoSize = true;
            this.totalBooksLbl.Location = new System.Drawing.Point(168, 462);
            this.totalBooksLbl.Name = "totalBooksLbl";
            this.totalBooksLbl.Size = new System.Drawing.Size(79, 13);
            this.totalBooksLbl.TabIndex = 54;
            this.totalBooksLbl.Text = "Broj primjeraka:";
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 553);
            this.Controls.Add(this.totalBooksTextBox);
            this.Controls.Add(this.totalBooksLbl);
            this.Controls.Add(this.publishersListBox);
            this.Controls.Add(this.publishersLbl);
            this.Controls.Add(this.genresListBox);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.numberOfPagesTextBox);
            this.Controls.Add(this.numberOfPagesLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.booEditLbl);
            this.Name = "BookAddForm";
            this.Text = "BookAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox genresListBox;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.TextBox numberOfPagesTextBox;
        private System.Windows.Forms.Label numberOfPagesLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.Label booEditLbl;
        private System.Windows.Forms.ListBox publishersListBox;
        private System.Windows.Forms.Label publishersLbl;
        private System.Windows.Forms.TextBox totalBooksTextBox;
        private System.Windows.Forms.Label totalBooksLbl;
    }
}