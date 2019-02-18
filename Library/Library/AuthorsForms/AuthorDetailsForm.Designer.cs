namespace Library.Presentation.AuthorsForms
{
    partial class AuthorDetailsForm
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
            this.nameOfAuthorLbl = new System.Windows.Forms.Label();
            this.nameOfAuthorTextBox = new System.Windows.Forms.TextBox();
            this.authorDetailsLbl = new System.Windows.Forms.Label();
            this.booksByAuthorLbl = new System.Windows.Forms.Label();
            this.booksByAuthorListBox = new System.Windows.Forms.ListBox();
            this.editAuthorBtn = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameOfAuthorLbl
            // 
            this.nameOfAuthorLbl.AutoSize = true;
            this.nameOfAuthorLbl.Location = new System.Drawing.Point(28, 66);
            this.nameOfAuthorLbl.Name = "nameOfAuthorLbl";
            this.nameOfAuthorLbl.Size = new System.Drawing.Size(74, 13);
            this.nameOfAuthorLbl.TabIndex = 0;
            this.nameOfAuthorLbl.Text = "Ime i prezime: ";
            // 
            // nameOfAuthorTextBox
            // 
            this.nameOfAuthorTextBox.Location = new System.Drawing.Point(108, 63);
            this.nameOfAuthorTextBox.Name = "nameOfAuthorTextBox";
            this.nameOfAuthorTextBox.ReadOnly = true;
            this.nameOfAuthorTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameOfAuthorTextBox.TabIndex = 1;
            // 
            // authorDetailsLbl
            // 
            this.authorDetailsLbl.AutoSize = true;
            this.authorDetailsLbl.Location = new System.Drawing.Point(116, 28);
            this.authorDetailsLbl.Name = "authorDetailsLbl";
            this.authorDetailsLbl.Size = new System.Drawing.Size(78, 13);
            this.authorDetailsLbl.TabIndex = 2;
            this.authorDetailsLbl.Text = "Detalji o autoru";
            // 
            // booksByAuthorLbl
            // 
            this.booksByAuthorLbl.AutoSize = true;
            this.booksByAuthorLbl.Location = new System.Drawing.Point(28, 101);
            this.booksByAuthorLbl.Name = "booksByAuthorLbl";
            this.booksByAuthorLbl.Size = new System.Drawing.Size(84, 13);
            this.booksByAuthorLbl.TabIndex = 3;
            this.booksByAuthorLbl.Text = "Autorove knjige:";
            // 
            // booksByAuthorListBox
            // 
            this.booksByAuthorListBox.FormattingEnabled = true;
            this.booksByAuthorListBox.Location = new System.Drawing.Point(31, 126);
            this.booksByAuthorListBox.Name = "booksByAuthorListBox";
            this.booksByAuthorListBox.Size = new System.Drawing.Size(266, 160);
            this.booksByAuthorListBox.TabIndex = 4;
            // 
            // editAuthorBtn
            // 
            this.editAuthorBtn.Location = new System.Drawing.Point(31, 310);
            this.editAuthorBtn.Name = "editAuthorBtn";
            this.editAuthorBtn.Size = new System.Drawing.Size(119, 28);
            this.editAuthorBtn.TabIndex = 1;
            this.editAuthorBtn.Text = "Promjeni detalje";
            this.editAuthorBtn.UseVisualStyleBackColor = true;
            this.editAuthorBtn.Click += new System.EventHandler(this.ShowAuthorEditForm);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(179, 310);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 2;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // AuthorDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.editAuthorBtn);
            this.Controls.Add(this.booksByAuthorListBox);
            this.Controls.Add(this.booksByAuthorLbl);
            this.Controls.Add(this.authorDetailsLbl);
            this.Controls.Add(this.nameOfAuthorTextBox);
            this.Controls.Add(this.nameOfAuthorLbl);
            this.Name = "AuthorDetailsForm";
            this.Text = "AuthorsDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfAuthorLbl;
        private System.Windows.Forms.TextBox nameOfAuthorTextBox;
        private System.Windows.Forms.Label authorDetailsLbl;
        private System.Windows.Forms.Label booksByAuthorLbl;
        private System.Windows.Forms.ListBox booksByAuthorListBox;
        private System.Windows.Forms.Button editAuthorBtn;
        private System.Windows.Forms.Button closeFormBtn;
    }
}