namespace Library.Presentation.BooksForms
{
    partial class BookEditForm
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
            this.bookEditLbl = new System.Windows.Forms.Label();
            this.publishersListBox = new System.Windows.Forms.ListBox();
            this.publishersLbl = new System.Windows.Forms.Label();
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
            this.totalBooksLbl = new System.Windows.Forms.Label();
            this.totalBooksTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bookEditLbl
            // 
            this.bookEditLbl.AutoSize = true;
            this.bookEditLbl.Location = new System.Drawing.Point(119, 27);
            this.bookEditLbl.Name = "bookEditLbl";
            this.bookEditLbl.Size = new System.Drawing.Size(85, 13);
            this.bookEditLbl.TabIndex = 14;
            this.bookEditLbl.Text = "Promjena detalja";
            // 
            // publishersListBox
            // 
            this.publishersListBox.FormattingEnabled = true;
            this.publishersListBox.Location = new System.Drawing.Point(33, 241);
            this.publishersListBox.Name = "publishersListBox";
            this.publishersListBox.Size = new System.Drawing.Size(268, 82);
            this.publishersListBox.TabIndex = 3;
            // 
            // publishersLbl
            // 
            this.publishersLbl.AutoSize = true;
            this.publishersLbl.Location = new System.Drawing.Point(30, 217);
            this.publishersLbl.Name = "publishersLbl";
            this.publishersLbl.Size = new System.Drawing.Size(50, 13);
            this.publishersLbl.TabIndex = 50;
            this.publishersLbl.Text = "Izdavaci:";
            // 
            // genresListBox
            // 
            this.genresListBox.FormattingEnabled = true;
            this.genresListBox.Location = new System.Drawing.Point(33, 359);
            this.genresListBox.Name = "genresListBox";
            this.genresListBox.Size = new System.Drawing.Size(270, 82);
            this.genresListBox.TabIndex = 4;
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.Location = new System.Drawing.Point(34, 128);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(268, 82);
            this.authorsListBox.TabIndex = 2;
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(192, 503);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(111, 30);
            this.closeFormBtn.TabIndex = 8;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(33, 503);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(111, 30);
            this.saveChangesBtn.TabIndex = 7;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // numberOfPagesTextBox
            // 
            this.numberOfPagesTextBox.Location = new System.Drawing.Point(110, 457);
            this.numberOfPagesTextBox.Name = "numberOfPagesTextBox";
            this.numberOfPagesTextBox.Size = new System.Drawing.Size(49, 20);
            this.numberOfPagesTextBox.TabIndex = 5;
            // 
            // numberOfPagesLbl
            // 
            this.numberOfPagesLbl.AutoSize = true;
            this.numberOfPagesLbl.Location = new System.Drawing.Point(31, 460);
            this.numberOfPagesLbl.Name = "numberOfPagesLbl";
            this.numberOfPagesLbl.Size = new System.Drawing.Size(68, 13);
            this.numberOfPagesLbl.TabIndex = 44;
            this.numberOfPagesLbl.Text = "Broj stranica:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(31, 104);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(37, 13);
            this.authorLbl.TabIndex = 43;
            this.authorLbl.Text = "Autori:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(31, 334);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(32, 13);
            this.genreLbl.TabIndex = 42;
            this.genreLbl.Text = "Zanr:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(110, 65);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.bookTitleTextBox.TabIndex = 1;
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Location = new System.Drawing.Point(30, 68);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(74, 13);
            this.bookTitleLbl.TabIndex = 40;
            this.bookTitleLbl.Text = "Naslov knjige:";
            // 
            // totalBooksLbl
            // 
            this.totalBooksLbl.AutoSize = true;
            this.totalBooksLbl.Location = new System.Drawing.Point(168, 460);
            this.totalBooksLbl.Name = "totalBooksLbl";
            this.totalBooksLbl.Size = new System.Drawing.Size(79, 13);
            this.totalBooksLbl.TabIndex = 52;
            this.totalBooksLbl.Text = "Broj primjeraka:";
            // 
            // totalBooksTextBox
            // 
            this.totalBooksTextBox.Location = new System.Drawing.Point(253, 457);
            this.totalBooksTextBox.Name = "totalBooksTextBox";
            this.totalBooksTextBox.Size = new System.Drawing.Size(49, 20);
            this.totalBooksTextBox.TabIndex = 6;
            // 
            // BookEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 550);
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
            this.Controls.Add(this.bookEditLbl);
            this.Name = "BookEditForm";
            this.Text = "BookEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bookEditLbl;
        private System.Windows.Forms.ListBox publishersListBox;
        private System.Windows.Forms.Label publishersLbl;
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
        private System.Windows.Forms.Label totalBooksLbl;
        private System.Windows.Forms.TextBox totalBooksTextBox;
    }
}