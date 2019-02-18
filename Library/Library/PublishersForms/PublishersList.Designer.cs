namespace Library.Presentation.PublishersForms
{
    partial class PublishersList
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
            this.publishersListBox = new System.Windows.Forms.ListBox();
            this.actionDescriptionLbl = new System.Windows.Forms.TextBox();
            this.nameOfPublisherLbl = new System.Windows.Forms.TextBox();
            this.addPublisherBtn = new System.Windows.Forms.Button();
            this.editPublisherBtn = new System.Windows.Forms.Button();
            this.deletePublisherBtn = new System.Windows.Forms.Button();
            this.publisherDetailsBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publishersListBox
            // 
            this.publishersListBox.FormattingEnabled = true;
            this.publishersListBox.Location = new System.Drawing.Point(15, 44);
            this.publishersListBox.Name = "publishersListBox";
            this.publishersListBox.Size = new System.Drawing.Size(303, 225);
            this.publishersListBox.TabIndex = 25;
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
            // nameOfPublisherLbl
            // 
            this.nameOfPublisherLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.nameOfPublisherLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfPublisherLbl.Location = new System.Drawing.Point(17, 18);
            this.nameOfPublisherLbl.Name = "nameOfPublisherLbl";
            this.nameOfPublisherLbl.ReadOnly = true;
            this.nameOfPublisherLbl.Size = new System.Drawing.Size(147, 13);
            this.nameOfPublisherLbl.TabIndex = 23;
            this.nameOfPublisherLbl.Text = "Naziv izdavaca:";
            // 
            // addPublisherBtn
            // 
            this.addPublisherBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addPublisherBtn.Location = new System.Drawing.Point(324, 93);
            this.addPublisherBtn.Name = "addPublisherBtn";
            this.addPublisherBtn.Size = new System.Drawing.Size(196, 43);
            this.addPublisherBtn.TabIndex = 2;
            this.addPublisherBtn.Text = "Dodavanje izdavaca";
            this.addPublisherBtn.UseVisualStyleBackColor = false;
            this.addPublisherBtn.Click += new System.EventHandler(this.ShowPublisherAddForm);
            // 
            // editPublisherBtn
            // 
            this.editPublisherBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editPublisherBtn.Location = new System.Drawing.Point(324, 142);
            this.editPublisherBtn.Name = "editPublisherBtn";
            this.editPublisherBtn.Size = new System.Drawing.Size(196, 43);
            this.editPublisherBtn.TabIndex = 3;
            this.editPublisherBtn.Text = "Uredivanje podataka";
            this.editPublisherBtn.UseVisualStyleBackColor = false;
            this.editPublisherBtn.Click += new System.EventHandler(this.ShowPublisherEditForm);
            // 
            // deletePublisherBtn
            // 
            this.deletePublisherBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deletePublisherBtn.Location = new System.Drawing.Point(324, 191);
            this.deletePublisherBtn.Name = "deletePublisherBtn";
            this.deletePublisherBtn.Size = new System.Drawing.Size(196, 43);
            this.deletePublisherBtn.TabIndex = 4;
            this.deletePublisherBtn.Text = "Brisanje izdavaca";
            this.deletePublisherBtn.UseVisualStyleBackColor = false;
            this.deletePublisherBtn.Click += new System.EventHandler(this.ShowPublisherDeleteForm);
            // 
            // publisherDetailsBtn
            // 
            this.publisherDetailsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.publisherDetailsBtn.Location = new System.Drawing.Point(324, 44);
            this.publisherDetailsBtn.Name = "publisherDetailsBtn";
            this.publisherDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.publisherDetailsBtn.TabIndex = 1;
            this.publisherDetailsBtn.Text = "Pregled detalja";
            this.publisherDetailsBtn.UseVisualStyleBackColor = false;
            this.publisherDetailsBtn.Click += new System.EventHandler(this.ShowPublisherDetailsForm);
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
            // PublishersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 286);
            this.Controls.Add(this.publishersListBox);
            this.Controls.Add(this.actionDescriptionLbl);
            this.Controls.Add(this.nameOfPublisherLbl);
            this.Controls.Add(this.addPublisherBtn);
            this.Controls.Add(this.editPublisherBtn);
            this.Controls.Add(this.deletePublisherBtn);
            this.Controls.Add(this.publisherDetailsBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "PublishersList";
            this.Text = "PublishersList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox publishersListBox;
        private System.Windows.Forms.TextBox actionDescriptionLbl;
        private System.Windows.Forms.TextBox nameOfPublisherLbl;
        private System.Windows.Forms.Button addPublisherBtn;
        private System.Windows.Forms.Button editPublisherBtn;
        private System.Windows.Forms.Button deletePublisherBtn;
        private System.Windows.Forms.Button publisherDetailsBtn;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}