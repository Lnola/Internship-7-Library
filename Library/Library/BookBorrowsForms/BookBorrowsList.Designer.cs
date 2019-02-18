namespace Library.Presentation.BookBorrowsForms
{
    partial class BookBorrowsList
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
            this.bookBorrowsListBox = new System.Windows.Forms.ListBox();
            this.actionDescriptionLbl = new System.Windows.Forms.TextBox();
            this.bookBorrowLbl = new System.Windows.Forms.TextBox();
            this.addBookBorrowBtn = new System.Windows.Forms.Button();
            this.editBookBorrowBtn = new System.Windows.Forms.Button();
            this.deleteBookBorrowBtn = new System.Windows.Forms.Button();
            this.bookBorrowDetailsBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.totalBooksTextBox = new System.Windows.Forms.TextBox();
            this.totalBooksLbl = new System.Windows.Forms.Label();
            this.borrowedBooksLbl = new System.Windows.Forms.Label();
            this.borrowedBooksTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bookBorrowsListBox
            // 
            this.bookBorrowsListBox.FormattingEnabled = true;
            this.bookBorrowsListBox.Location = new System.Drawing.Point(15, 44);
            this.bookBorrowsListBox.Name = "bookBorrowsListBox";
            this.bookBorrowsListBox.Size = new System.Drawing.Size(303, 290);
            this.bookBorrowsListBox.TabIndex = 25;
            // 
            // actionDescriptionLbl
            // 
            this.actionDescriptionLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.actionDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actionDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionDescriptionLbl.Location = new System.Drawing.Point(324, 18);
            this.actionDescriptionLbl.Name = "actionDescriptionLbl";
            this.actionDescriptionLbl.ReadOnly = true;
            this.actionDescriptionLbl.Size = new System.Drawing.Size(196, 16);
            this.actionDescriptionLbl.TabIndex = 24;
            this.actionDescriptionLbl.Text = "Odaberi Opciju";
            // 
            // bookBorrowLbl
            // 
            this.bookBorrowLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.bookBorrowLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookBorrowLbl.Location = new System.Drawing.Point(17, 18);
            this.bookBorrowLbl.Name = "bookBorrowLbl";
            this.bookBorrowLbl.ReadOnly = true;
            this.bookBorrowLbl.Size = new System.Drawing.Size(147, 13);
            this.bookBorrowLbl.TabIndex = 23;
            this.bookBorrowLbl.Text = "Ime ucenika i knjige:";
            // 
            // addBookBorrowBtn
            // 
            this.addBookBorrowBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addBookBorrowBtn.Location = new System.Drawing.Point(324, 93);
            this.addBookBorrowBtn.Name = "addBookBorrowBtn";
            this.addBookBorrowBtn.Size = new System.Drawing.Size(196, 43);
            this.addBookBorrowBtn.TabIndex = 2;
            this.addBookBorrowBtn.Text = "Dodavanje posudbe";
            this.addBookBorrowBtn.UseVisualStyleBackColor = false;
            this.addBookBorrowBtn.Click += new System.EventHandler(this.ShowBookBorrowAddForm);
            // 
            // editBookBorrowBtn
            // 
            this.editBookBorrowBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editBookBorrowBtn.Location = new System.Drawing.Point(324, 142);
            this.editBookBorrowBtn.Name = "editBookBorrowBtn";
            this.editBookBorrowBtn.Size = new System.Drawing.Size(196, 43);
            this.editBookBorrowBtn.TabIndex = 3;
            this.editBookBorrowBtn.Text = "Uredivanje podataka";
            this.editBookBorrowBtn.UseVisualStyleBackColor = false;
            this.editBookBorrowBtn.Click += new System.EventHandler(this.ShowBookBorrowEditForm);
            // 
            // deleteBookBorrowBtn
            // 
            this.deleteBookBorrowBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBookBorrowBtn.Location = new System.Drawing.Point(324, 191);
            this.deleteBookBorrowBtn.Name = "deleteBookBorrowBtn";
            this.deleteBookBorrowBtn.Size = new System.Drawing.Size(196, 43);
            this.deleteBookBorrowBtn.TabIndex = 4;
            this.deleteBookBorrowBtn.Text = "Brisanje posudbe";
            this.deleteBookBorrowBtn.UseVisualStyleBackColor = false;
            this.deleteBookBorrowBtn.Click += new System.EventHandler(this.ShowBookBorrowDeleteForm);
            // 
            // bookBorrowDetailsBtn
            // 
            this.bookBorrowDetailsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookBorrowDetailsBtn.Location = new System.Drawing.Point(324, 44);
            this.bookBorrowDetailsBtn.Name = "bookBorrowDetailsBtn";
            this.bookBorrowDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.bookBorrowDetailsBtn.TabIndex = 1;
            this.bookBorrowDetailsBtn.Text = "Pregled detalja";
            this.bookBorrowDetailsBtn.UseVisualStyleBackColor = false;
            this.bookBorrowDetailsBtn.Click += new System.EventHandler(this.ShowBookBorrowDetailsForm);
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backToMenuBtn.Location = new System.Drawing.Point(432, 312);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(88, 22);
            this.backToMenuBtn.TabIndex = 5;
            this.backToMenuBtn.Text = "Back to Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = false;
            this.backToMenuBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // totalBooksTextBox
            // 
            this.totalBooksTextBox.Location = new System.Drawing.Point(421, 244);
            this.totalBooksTextBox.Name = "totalBooksTextBox";
            this.totalBooksTextBox.ReadOnly = true;
            this.totalBooksTextBox.Size = new System.Drawing.Size(99, 20);
            this.totalBooksTextBox.TabIndex = 21;
            // 
            // totalBooksLbl
            // 
            this.totalBooksLbl.AutoSize = true;
            this.totalBooksLbl.Location = new System.Drawing.Point(324, 247);
            this.totalBooksLbl.Name = "totalBooksLbl";
            this.totalBooksLbl.Size = new System.Drawing.Size(88, 13);
            this.totalBooksLbl.TabIndex = 27;
            this.totalBooksLbl.Text = "Knjiga u knjiznici:";
            // 
            // borrowedBooksLbl
            // 
            this.borrowedBooksLbl.AutoSize = true;
            this.borrowedBooksLbl.Location = new System.Drawing.Point(324, 273);
            this.borrowedBooksLbl.Name = "borrowedBooksLbl";
            this.borrowedBooksLbl.Size = new System.Drawing.Size(91, 13);
            this.borrowedBooksLbl.TabIndex = 29;
            this.borrowedBooksLbl.Text = "Posudenih knjiga:";
            // 
            // borrowedBooksTextBox
            // 
            this.borrowedBooksTextBox.Location = new System.Drawing.Point(421, 270);
            this.borrowedBooksTextBox.Name = "borrowedBooksTextBox";
            this.borrowedBooksTextBox.ReadOnly = true;
            this.borrowedBooksTextBox.Size = new System.Drawing.Size(99, 20);
            this.borrowedBooksTextBox.TabIndex = 22;
            // 
            // BookBorrowsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 351);
            this.Controls.Add(this.borrowedBooksLbl);
            this.Controls.Add(this.borrowedBooksTextBox);
            this.Controls.Add(this.totalBooksLbl);
            this.Controls.Add(this.totalBooksTextBox);
            this.Controls.Add(this.bookBorrowsListBox);
            this.Controls.Add(this.actionDescriptionLbl);
            this.Controls.Add(this.bookBorrowLbl);
            this.Controls.Add(this.addBookBorrowBtn);
            this.Controls.Add(this.editBookBorrowBtn);
            this.Controls.Add(this.deleteBookBorrowBtn);
            this.Controls.Add(this.bookBorrowDetailsBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "BookBorrowsList";
            this.Text = "BookBorrowsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookBorrowsListBox;
        private System.Windows.Forms.TextBox actionDescriptionLbl;
        private System.Windows.Forms.TextBox bookBorrowLbl;
        private System.Windows.Forms.Button addBookBorrowBtn;
        private System.Windows.Forms.Button editBookBorrowBtn;
        private System.Windows.Forms.Button deleteBookBorrowBtn;
        private System.Windows.Forms.Button bookBorrowDetailsBtn;
        private System.Windows.Forms.Button backToMenuBtn;
        private System.Windows.Forms.TextBox totalBooksTextBox;
        private System.Windows.Forms.Label totalBooksLbl;
        private System.Windows.Forms.Label borrowedBooksLbl;
        private System.Windows.Forms.TextBox borrowedBooksTextBox;
    }
}