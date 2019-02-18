namespace Library.Presentation.AuthorsForms
{
    partial class AuthorsList
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
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.actionDescriptionLbl = new System.Windows.Forms.TextBox();
            this.nameOfAuthorLbl = new System.Windows.Forms.TextBox();
            this.addAuthorBtn = new System.Windows.Forms.Button();
            this.editAuthorBtn = new System.Windows.Forms.Button();
            this.deleteAuthorBtn = new System.Windows.Forms.Button();
            this.authorDetailsBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.Location = new System.Drawing.Point(12, 42);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(303, 225);
            this.authorsListBox.TabIndex = 17;
            // 
            // actionDescriptionLbl
            // 
            this.actionDescriptionLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.actionDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.actionDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionDescriptionLbl.Location = new System.Drawing.Point(321, 16);
            this.actionDescriptionLbl.Name = "actionDescriptionLbl";
            this.actionDescriptionLbl.ReadOnly = true;
            this.actionDescriptionLbl.Size = new System.Drawing.Size(196, 16);
            this.actionDescriptionLbl.TabIndex = 16;
            this.actionDescriptionLbl.Text = "Odaberi Opciju";
            // 
            // nameOfAuthorLbl
            // 
            this.nameOfAuthorLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.nameOfAuthorLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfAuthorLbl.Location = new System.Drawing.Point(14, 16);
            this.nameOfAuthorLbl.Name = "nameOfAuthorLbl";
            this.nameOfAuthorLbl.ReadOnly = true;
            this.nameOfAuthorLbl.Size = new System.Drawing.Size(147, 13);
            this.nameOfAuthorLbl.TabIndex = 15;
            this.nameOfAuthorLbl.Text = "Ime i prezime autora:";
            // 
            // addAuthorBtn
            // 
            this.addAuthorBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addAuthorBtn.Location = new System.Drawing.Point(321, 91);
            this.addAuthorBtn.Name = "addAuthorBtn";
            this.addAuthorBtn.Size = new System.Drawing.Size(196, 43);
            this.addAuthorBtn.TabIndex = 2;
            this.addAuthorBtn.Text = "Dodavanje autora";
            this.addAuthorBtn.UseVisualStyleBackColor = false;
            this.addAuthorBtn.Click += new System.EventHandler(this.ShowAuthorAddForm);
            // 
            // editAuthorBtn
            // 
            this.editAuthorBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editAuthorBtn.Location = new System.Drawing.Point(321, 140);
            this.editAuthorBtn.Name = "editAuthorBtn";
            this.editAuthorBtn.Size = new System.Drawing.Size(196, 43);
            this.editAuthorBtn.TabIndex = 3;
            this.editAuthorBtn.Text = "Uredivanje podataka";
            this.editAuthorBtn.UseVisualStyleBackColor = false;
            this.editAuthorBtn.Click += new System.EventHandler(this.ShowAuthorEditForm);
            // 
            // deleteAuthorBtn
            // 
            this.deleteAuthorBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteAuthorBtn.Location = new System.Drawing.Point(321, 189);
            this.deleteAuthorBtn.Name = "deleteAuthorBtn";
            this.deleteAuthorBtn.Size = new System.Drawing.Size(196, 43);
            this.deleteAuthorBtn.TabIndex = 4;
            this.deleteAuthorBtn.Text = "Brisanje autora";
            this.deleteAuthorBtn.UseVisualStyleBackColor = false;
            this.deleteAuthorBtn.Click += new System.EventHandler(this.ShowAuthorDeleteForm);
            // 
            // authorDetailsBtn
            // 
            this.authorDetailsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.authorDetailsBtn.Location = new System.Drawing.Point(321, 42);
            this.authorDetailsBtn.Name = "authorDetailsBtn";
            this.authorDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.authorDetailsBtn.TabIndex = 1;
            this.authorDetailsBtn.Text = "Pregled detalja";
            this.authorDetailsBtn.UseVisualStyleBackColor = false;
            this.authorDetailsBtn.Click += new System.EventHandler(this.ShowAuthorDetailsForm);
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backToMenuBtn.Location = new System.Drawing.Point(429, 245);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(88, 22);
            this.backToMenuBtn.TabIndex = 5;
            this.backToMenuBtn.Text = "Back to Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = false;
            this.backToMenuBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // AuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 286);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.actionDescriptionLbl);
            this.Controls.Add(this.nameOfAuthorLbl);
            this.Controls.Add(this.addAuthorBtn);
            this.Controls.Add(this.editAuthorBtn);
            this.Controls.Add(this.deleteAuthorBtn);
            this.Controls.Add(this.authorDetailsBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "AuthorsList";
            this.Text = "AuthorsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.TextBox actionDescriptionLbl;
        private System.Windows.Forms.TextBox nameOfAuthorLbl;
        private System.Windows.Forms.Button addAuthorBtn;
        private System.Windows.Forms.Button editAuthorBtn;
        private System.Windows.Forms.Button deleteAuthorBtn;
        private System.Windows.Forms.Button authorDetailsBtn;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}