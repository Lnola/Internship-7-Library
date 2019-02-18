namespace Library.Presentation.BooksForms
{
    partial class BookDetailsForm
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
            this.bookDetailsLbl = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.genreLbl = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorLbl = new System.Windows.Forms.Label();
            this.numberOfPagesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPagesLbl = new System.Windows.Forms.Label();
            this.openEditFormBtn = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.numberOfBooksTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBooksLbl = new System.Windows.Forms.Label();
            this.totalBooksTextBox = new System.Windows.Forms.TextBox();
            this.totalBookslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookDetailsLbl
            // 
            this.bookDetailsLbl.AutoSize = true;
            this.bookDetailsLbl.Location = new System.Drawing.Point(130, 25);
            this.bookDetailsLbl.Name = "bookDetailsLbl";
            this.bookDetailsLbl.Size = new System.Drawing.Size(67, 13);
            this.bookDetailsLbl.TabIndex = 0;
            this.bookDetailsLbl.Text = "Detalji knjige";
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Location = new System.Drawing.Point(29, 71);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(74, 13);
            this.bookTitleLbl.TabIndex = 1;
            this.bookTitleLbl.Text = "Naslov knjige:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(109, 68);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.ReadOnly = true;
            this.bookTitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.bookTitleTextBox.TabIndex = 2;
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(31, 189);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(32, 13);
            this.genreLbl.TabIndex = 4;
            this.genreLbl.Text = "Zanr:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(110, 186);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.ReadOnly = true;
            this.genreTextBox.Size = new System.Drawing.Size(193, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(109, 104);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(193, 20);
            this.authorTextBox.TabIndex = 9;
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(30, 107);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(35, 13);
            this.authorLbl.TabIndex = 8;
            this.authorLbl.Text = "Autor:";
            // 
            // numberOfPagesTextBox
            // 
            this.numberOfPagesTextBox.Location = new System.Drawing.Point(110, 224);
            this.numberOfPagesTextBox.Name = "numberOfPagesTextBox";
            this.numberOfPagesTextBox.ReadOnly = true;
            this.numberOfPagesTextBox.Size = new System.Drawing.Size(49, 20);
            this.numberOfPagesTextBox.TabIndex = 11;
            // 
            // numberOfPagesLbl
            // 
            this.numberOfPagesLbl.AutoSize = true;
            this.numberOfPagesLbl.Location = new System.Drawing.Point(31, 227);
            this.numberOfPagesLbl.Name = "numberOfPagesLbl";
            this.numberOfPagesLbl.Size = new System.Drawing.Size(68, 13);
            this.numberOfPagesLbl.TabIndex = 10;
            this.numberOfPagesLbl.Text = "Broj stranica:";
            // 
            // openEditFormBtn
            // 
            this.openEditFormBtn.Location = new System.Drawing.Point(33, 465);
            this.openEditFormBtn.Name = "openEditFormBtn";
            this.openEditFormBtn.Size = new System.Drawing.Size(111, 30);
            this.openEditFormBtn.TabIndex = 1;
            this.openEditFormBtn.Text = "Promijeni detalje";
            this.openEditFormBtn.UseVisualStyleBackColor = true;
            this.openEditFormBtn.Click += new System.EventHandler(this.ShowEditForm);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(192, 465);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(111, 30);
            this.closeFormBtn.TabIndex = 2;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // studentsLbl
            // 
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Location = new System.Drawing.Point(31, 303);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(145, 13);
            this.studentsLbl.TabIndex = 14;
            this.studentsLbl.Text = "Ucenici koji su posudili knjigu";
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(33, 331);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(270, 108);
            this.studentsListBox.TabIndex = 15;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(109, 145);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.ReadOnly = true;
            this.publisherTextBox.Size = new System.Drawing.Size(193, 20);
            this.publisherTextBox.TabIndex = 17;
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(30, 148);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(48, 13);
            this.publisherLbl.TabIndex = 16;
            this.publisherLbl.Text = "Izdavac:";
            // 
            // numberOfBooksTextBox
            // 
            this.numberOfBooksTextBox.Location = new System.Drawing.Point(176, 262);
            this.numberOfBooksTextBox.Name = "numberOfBooksTextBox";
            this.numberOfBooksTextBox.ReadOnly = true;
            this.numberOfBooksTextBox.Size = new System.Drawing.Size(49, 20);
            this.numberOfBooksTextBox.TabIndex = 19;
            // 
            // numberOfBooksLbl
            // 
            this.numberOfBooksLbl.AutoSize = true;
            this.numberOfBooksLbl.Location = new System.Drawing.Point(30, 265);
            this.numberOfBooksLbl.Name = "numberOfBooksLbl";
            this.numberOfBooksLbl.Size = new System.Drawing.Size(140, 13);
            this.numberOfBooksLbl.TabIndex = 18;
            this.numberOfBooksLbl.Text = "Broj neposudenih primjeraka";
            // 
            // totalBooksTextBox
            // 
            this.totalBooksTextBox.Location = new System.Drawing.Point(263, 224);
            this.totalBooksTextBox.Name = "totalBooksTextBox";
            this.totalBooksTextBox.ReadOnly = true;
            this.totalBooksTextBox.Size = new System.Drawing.Size(40, 20);
            this.totalBooksTextBox.TabIndex = 21;
            // 
            // totalBookslbl
            // 
            this.totalBookslbl.AutoSize = true;
            this.totalBookslbl.Location = new System.Drawing.Point(165, 227);
            this.totalBookslbl.Name = "totalBookslbl";
            this.totalBookslbl.Size = new System.Drawing.Size(99, 13);
            this.totalBookslbl.TabIndex = 20;
            this.totalBookslbl.Text = "Ukupno primjeraka:";
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 525);
            this.Controls.Add(this.totalBooksTextBox);
            this.Controls.Add(this.totalBookslbl);
            this.Controls.Add(this.numberOfBooksTextBox);
            this.Controls.Add(this.numberOfBooksLbl);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.openEditFormBtn);
            this.Controls.Add(this.numberOfPagesTextBox);
            this.Controls.Add(this.numberOfPagesLbl);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.bookDetailsLbl);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookDetailsLbl;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox numberOfPagesTextBox;
        private System.Windows.Forms.Label numberOfPagesLbl;
        private System.Windows.Forms.Button openEditFormBtn;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Label studentsLbl;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.TextBox numberOfBooksTextBox;
        private System.Windows.Forms.Label numberOfBooksLbl;
        private System.Windows.Forms.TextBox totalBooksTextBox;
        private System.Windows.Forms.Label totalBookslbl;
    }
}