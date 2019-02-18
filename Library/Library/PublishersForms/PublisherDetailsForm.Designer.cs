namespace Library.Presentation.PublishersForms
{
    partial class PublisherDetailsForm
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
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.openEditFormBtn = new System.Windows.Forms.Button();
            this.allBooksListBox = new System.Windows.Forms.ListBox();
            this.allBooksLbl = new System.Windows.Forms.Label();
            this.publisherDetailsLbl = new System.Windows.Forms.Label();
            this.nameOfPublisherTextBox = new System.Windows.Forms.TextBox();
            this.nameOfPublisherLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.Location = new System.Drawing.Point(182, 311);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(118, 28);
            this.closeFormBtn.TabIndex = 2;
            this.closeFormBtn.Text = "Odustani";
            this.closeFormBtn.UseVisualStyleBackColor = true;
            this.closeFormBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // openEditFormBtn
            // 
            this.openEditFormBtn.Location = new System.Drawing.Point(34, 311);
            this.openEditFormBtn.Name = "openEditFormBtn";
            this.openEditFormBtn.Size = new System.Drawing.Size(119, 28);
            this.openEditFormBtn.TabIndex = 1;
            this.openEditFormBtn.Text = "Promjeni detalje";
            this.openEditFormBtn.UseVisualStyleBackColor = true;
            this.openEditFormBtn.Click += new System.EventHandler(this.ShowEditForm);
            // 
            // allBooksListBox
            // 
            this.allBooksListBox.FormattingEnabled = true;
            this.allBooksListBox.Location = new System.Drawing.Point(34, 127);
            this.allBooksListBox.Name = "allBooksListBox";
            this.allBooksListBox.Size = new System.Drawing.Size(266, 160);
            this.allBooksListBox.TabIndex = 18;
            // 
            // allBooksLbl
            // 
            this.allBooksLbl.AutoSize = true;
            this.allBooksLbl.Location = new System.Drawing.Point(31, 102);
            this.allBooksLbl.Name = "allBooksLbl";
            this.allBooksLbl.Size = new System.Drawing.Size(106, 13);
            this.allBooksLbl.TabIndex = 17;
            this.allBooksLbl.Text = "Sve knjige izdavaca:";
            // 
            // publisherDetailsLbl
            // 
            this.publisherDetailsLbl.AutoSize = true;
            this.publisherDetailsLbl.Location = new System.Drawing.Point(120, 28);
            this.publisherDetailsLbl.Name = "publisherDetailsLbl";
            this.publisherDetailsLbl.Size = new System.Drawing.Size(82, 13);
            this.publisherDetailsLbl.TabIndex = 16;
            this.publisherDetailsLbl.Text = "Detalji izdavaca";
            // 
            // nameOfPublisherTextBox
            // 
            this.nameOfPublisherTextBox.Location = new System.Drawing.Point(67, 64);
            this.nameOfPublisherTextBox.Name = "nameOfPublisherTextBox";
            this.nameOfPublisherTextBox.ReadOnly = true;
            this.nameOfPublisherTextBox.Size = new System.Drawing.Size(233, 20);
            this.nameOfPublisherTextBox.TabIndex = 15;
            // 
            // nameOfPublisherLbl
            // 
            this.nameOfPublisherLbl.AutoSize = true;
            this.nameOfPublisherLbl.Location = new System.Drawing.Point(31, 67);
            this.nameOfPublisherLbl.Name = "nameOfPublisherLbl";
            this.nameOfPublisherLbl.Size = new System.Drawing.Size(30, 13);
            this.nameOfPublisherLbl.TabIndex = 14;
            this.nameOfPublisherLbl.Text = "Ime: ";
            // 
            // PublisherDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.openEditFormBtn);
            this.Controls.Add(this.allBooksListBox);
            this.Controls.Add(this.allBooksLbl);
            this.Controls.Add(this.publisherDetailsLbl);
            this.Controls.Add(this.nameOfPublisherTextBox);
            this.Controls.Add(this.nameOfPublisherLbl);
            this.Name = "PublisherDetailsForm";
            this.Text = "PublisherDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button closeFormBtn;
        protected System.Windows.Forms.Button openEditFormBtn;
        protected System.Windows.Forms.ListBox allBooksListBox;
        protected System.Windows.Forms.Label allBooksLbl;
        protected System.Windows.Forms.Label publisherDetailsLbl;
        protected System.Windows.Forms.TextBox nameOfPublisherTextBox;
        protected System.Windows.Forms.Label nameOfPublisherLbl;
    }
}