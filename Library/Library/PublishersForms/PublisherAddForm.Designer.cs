namespace Library.Presentation.PublishersForms
{
    partial class PublisherAddForm
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
            this.booksCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.allBooksLbl = new System.Windows.Forms.Label();
            this.publisherDetailsLbl = new System.Windows.Forms.Label();
            this.nameOfPublisherTextBox = new System.Windows.Forms.TextBox();
            this.nameOfPublisherLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksCheckedListBox
            // 
            this.booksCheckedListBox.FormattingEnabled = true;
            this.booksCheckedListBox.Location = new System.Drawing.Point(34, 126);
            this.booksCheckedListBox.Name = "booksCheckedListBox";
            this.booksCheckedListBox.Size = new System.Drawing.Size(266, 154);
            this.booksCheckedListBox.TabIndex = 2;
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(182, 310);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 4;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(34, 310);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(119, 28);
            this.saveChangesBtn.TabIndex = 3;
            this.saveChangesBtn.Text = "Spremi promjene";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.SaveChanges);
            // 
            // allBooksLbl
            // 
            this.allBooksLbl.AutoSize = true;
            this.allBooksLbl.Location = new System.Drawing.Point(31, 101);
            this.allBooksLbl.Name = "allBooksLbl";
            this.allBooksLbl.Size = new System.Drawing.Size(126, 13);
            this.allBooksLbl.TabIndex = 32;
            this.allBooksLbl.Text = "Sve knjige bez izdavaca:";
            // 
            // publisherDetailsLbl
            // 
            this.publisherDetailsLbl.AutoSize = true;
            this.publisherDetailsLbl.Location = new System.Drawing.Point(114, 26);
            this.publisherDetailsLbl.Name = "publisherDetailsLbl";
            this.publisherDetailsLbl.Size = new System.Drawing.Size(105, 13);
            this.publisherDetailsLbl.TabIndex = 31;
            this.publisherDetailsLbl.Text = "Dodavanje izdavaca";
            // 
            // nameOfPublisherTextBox
            // 
            this.nameOfPublisherTextBox.Location = new System.Drawing.Point(67, 63);
            this.nameOfPublisherTextBox.Name = "nameOfPublisherTextBox";
            this.nameOfPublisherTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameOfPublisherTextBox.TabIndex = 1;
            // 
            // nameOfPublisherLbl
            // 
            this.nameOfPublisherLbl.AutoSize = true;
            this.nameOfPublisherLbl.Location = new System.Drawing.Point(31, 66);
            this.nameOfPublisherLbl.Name = "nameOfPublisherLbl";
            this.nameOfPublisherLbl.Size = new System.Drawing.Size(30, 13);
            this.nameOfPublisherLbl.TabIndex = 29;
            this.nameOfPublisherLbl.Text = "Ime: ";
            // 
            // PublisherAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.booksCheckedListBox);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.allBooksLbl);
            this.Controls.Add(this.publisherDetailsLbl);
            this.Controls.Add(this.nameOfPublisherTextBox);
            this.Controls.Add(this.nameOfPublisherLbl);
            this.Name = "PublisherAddForm";
            this.Text = "PublisherAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox booksCheckedListBox;
        protected System.Windows.Forms.Button closeFormBtn;
        protected System.Windows.Forms.Button saveChangesBtn;
        protected System.Windows.Forms.Label allBooksLbl;
        protected System.Windows.Forms.Label publisherDetailsLbl;
        protected System.Windows.Forms.TextBox nameOfPublisherTextBox;
        protected System.Windows.Forms.Label nameOfPublisherLbl;
    }
}