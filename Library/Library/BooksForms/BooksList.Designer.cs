namespace Library.Presentation.BooksForms
{
    partial class BooksList
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
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.actionDescriptionLbl = new System.Windows.Forms.TextBox();
            this.nameOfBookLbl = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.bookDetailsBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(15, 44);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(303, 225);
            this.booksListBox.TabIndex = 25;
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
            // nameOfBookLbl
            // 
            this.nameOfBookLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.nameOfBookLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfBookLbl.Location = new System.Drawing.Point(17, 18);
            this.nameOfBookLbl.Name = "nameOfBookLbl";
            this.nameOfBookLbl.ReadOnly = true;
            this.nameOfBookLbl.Size = new System.Drawing.Size(147, 13);
            this.nameOfBookLbl.TabIndex = 23;
            this.nameOfBookLbl.Text = "Naslov knjige:";
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addBookBtn.Location = new System.Drawing.Point(324, 93);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(196, 43);
            this.addBookBtn.TabIndex = 2;
            this.addBookBtn.Text = "Dodavanje knjige";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.ShowBookAddForm);
            // 
            // editBookBtn
            // 
            this.editBookBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editBookBtn.Location = new System.Drawing.Point(324, 142);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(196, 43);
            this.editBookBtn.TabIndex = 3;
            this.editBookBtn.Text = "Uredivanje podataka";
            this.editBookBtn.UseVisualStyleBackColor = false;
            this.editBookBtn.Click += new System.EventHandler(this.ShowBookEditForm);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBookBtn.Location = new System.Drawing.Point(324, 191);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(196, 43);
            this.deleteBookBtn.TabIndex = 4;
            this.deleteBookBtn.Text = "Brisanje knjige";
            this.deleteBookBtn.UseVisualStyleBackColor = false;
            this.deleteBookBtn.Click += new System.EventHandler(this.ShowBookDeleteForm);
            // 
            // bookDetailsBtn
            // 
            this.bookDetailsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookDetailsBtn.Location = new System.Drawing.Point(324, 44);
            this.bookDetailsBtn.Name = "bookDetailsBtn";
            this.bookDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.bookDetailsBtn.TabIndex = 1;
            this.bookDetailsBtn.Text = "Pregled detalja";
            this.bookDetailsBtn.UseVisualStyleBackColor = false;
            this.bookDetailsBtn.Click += new System.EventHandler(this.ShowBookDetailsForm);
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backToMenuBtn.Location = new System.Drawing.Point(432, 247);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(88, 22);
            this.backToMenuBtn.TabIndex = 5;
            this.backToMenuBtn.Text = "Back to Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = false;
            this.backToMenuBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // BooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 286);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.actionDescriptionLbl);
            this.Controls.Add(this.nameOfBookLbl);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.bookDetailsBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "BooksList";
            this.Text = "BooksList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.TextBox actionDescriptionLbl;
        private System.Windows.Forms.TextBox nameOfBookLbl;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button bookDetailsBtn;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}