namespace Library
{
    partial class library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(library));
            this.booksBtn = new System.Windows.Forms.Button();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.authorsBtn = new System.Windows.Forms.Button();
            this.publishersBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.bookBorrowsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksBtn
            // 
            this.booksBtn.Location = new System.Drawing.Point(26, 165);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(192, 49);
            this.booksBtn.TabIndex = 3;
            this.booksBtn.Text = "Knjige";
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.ShowBooksForm);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(23, 26);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(78, 13);
            this.descriptionLbl.TabIndex = 1;
            this.descriptionLbl.Text = "Odaberi model:";
            // 
            // authorsBtn
            // 
            this.authorsBtn.Location = new System.Drawing.Point(26, 55);
            this.authorsBtn.Name = "authorsBtn";
            this.authorsBtn.Size = new System.Drawing.Size(192, 49);
            this.authorsBtn.TabIndex = 1;
            this.authorsBtn.Text = "Autori";
            this.authorsBtn.UseVisualStyleBackColor = true;
            this.authorsBtn.Click += new System.EventHandler(this.ShowAuthorsForm);
            // 
            // publishersBtn
            // 
            this.publishersBtn.Location = new System.Drawing.Point(26, 220);
            this.publishersBtn.Name = "publishersBtn";
            this.publishersBtn.Size = new System.Drawing.Size(192, 49);
            this.publishersBtn.TabIndex = 4;
            this.publishersBtn.Text = "Izdavaci";
            this.publishersBtn.UseVisualStyleBackColor = true;
            this.publishersBtn.Click += new System.EventHandler(this.ShowPublishersForm);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(26, 275);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(192, 49);
            this.studentsBtn.TabIndex = 5;
            this.studentsBtn.Text = "Ucenici";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.ShowStudentsForm);
            // 
            // bookBorrowsBtn
            // 
            this.bookBorrowsBtn.Location = new System.Drawing.Point(26, 110);
            this.bookBorrowsBtn.Name = "bookBorrowsBtn";
            this.bookBorrowsBtn.Size = new System.Drawing.Size(192, 49);
            this.bookBorrowsBtn.TabIndex = 2;
            this.bookBorrowsBtn.Text = "Posudbe";
            this.bookBorrowsBtn.UseVisualStyleBackColor = true;
            this.bookBorrowsBtn.Click += new System.EventHandler(this.ShowBookBorrowsForm);
            // 
            // library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 347);
            this.Controls.Add(this.studentsBtn);
            this.Controls.Add(this.publishersBtn);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.bookBorrowsBtn);
            this.Controls.Add(this.authorsBtn);
            this.Controls.Add(this.descriptionLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "library";
            this.Text = "Knjiznica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Button authorsBtn;
        private System.Windows.Forms.Button publishersBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button bookBorrowsBtn;
    }
}