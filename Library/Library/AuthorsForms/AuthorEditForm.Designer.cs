namespace Library.Presentation.AuthorsForms
{
    partial class AuthorEditForm
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
            this.authorEditLbl = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.CheckedListBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.allBooksLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorEditLbl
            // 
            this.authorEditLbl.AutoSize = true;
            this.authorEditLbl.Location = new System.Drawing.Point(96, 25);
            this.authorEditLbl.Name = "authorEditLbl";
            this.authorEditLbl.Size = new System.Drawing.Size(127, 13);
            this.authorEditLbl.TabIndex = 9;
            this.authorEditLbl.Text = "Promjena detalja o autoru";
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(34, 155);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(266, 154);
            this.booksListBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 52);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 89);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(31, 92);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(47, 13);
            this.lastNameLbl.TabIndex = 33;
            this.lastNameLbl.Text = "Prezime:";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(31, 55);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(27, 13);
            this.firstNameLbl.TabIndex = 31;
            this.firstNameLbl.Text = "Ime:";
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(182, 337);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 5;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(34, 337);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(119, 28);
            this.saveChangesBtn.TabIndex = 4;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // allBooksLbl
            // 
            this.allBooksLbl.AutoSize = true;
            this.allBooksLbl.Location = new System.Drawing.Point(31, 128);
            this.allBooksLbl.Name = "allBooksLbl";
            this.allBooksLbl.Size = new System.Drawing.Size(113, 13);
            this.allBooksLbl.TabIndex = 28;
            this.allBooksLbl.Text = "Sve knjige bez autora:";
            // 
            // AuthorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 384);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.allBooksLbl);
            this.Controls.Add(this.authorEditLbl);
            this.Name = "AuthorEditForm";
            this.Text = "AuthorsEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label authorEditLbl;
        private System.Windows.Forms.CheckedListBox booksListBox;
        protected System.Windows.Forms.TextBox firstNameTextBox;
        protected System.Windows.Forms.TextBox lastNameTextBox;
        protected System.Windows.Forms.Label lastNameLbl;
        protected System.Windows.Forms.Label firstNameLbl;
        protected System.Windows.Forms.Button closeFormBtn;
        protected System.Windows.Forms.Button saveChangesBtn;
        protected System.Windows.Forms.Label allBooksLbl;
    }
}