namespace Library.Presentation.StudentsForms
{
    partial class StudentsList
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
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.actionDescriptionLbl = new System.Windows.Forms.TextBox();
            this.nameOfStudentLbl = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.strudentDetailsBtn = new System.Windows.Forms.Button();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(15, 44);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(303, 225);
            this.studentsListBox.TabIndex = 25;
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
            // nameOfStudentLbl
            // 
            this.nameOfStudentLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.nameOfStudentLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfStudentLbl.Location = new System.Drawing.Point(17, 18);
            this.nameOfStudentLbl.Name = "nameOfStudentLbl";
            this.nameOfStudentLbl.ReadOnly = true;
            this.nameOfStudentLbl.Size = new System.Drawing.Size(147, 13);
            this.nameOfStudentLbl.TabIndex = 23;
            this.nameOfStudentLbl.Text = "Ime i prezime ucenika:";
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addStudentBtn.Location = new System.Drawing.Point(324, 93);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(196, 43);
            this.addStudentBtn.TabIndex = 2;
            this.addStudentBtn.Text = "Dodavanje ucenika";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.ShowStudentAddForm);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editStudentBtn.Location = new System.Drawing.Point(324, 142);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(196, 43);
            this.editStudentBtn.TabIndex = 3;
            this.editStudentBtn.Text = "Uredivanje podataka";
            this.editStudentBtn.UseVisualStyleBackColor = false;
            this.editStudentBtn.Click += new System.EventHandler(this.ShowStudentEditForm);
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteStudentBtn.Location = new System.Drawing.Point(324, 191);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(196, 43);
            this.deleteStudentBtn.TabIndex = 4;
            this.deleteStudentBtn.Text = "Brisanje ucenika";
            this.deleteStudentBtn.UseVisualStyleBackColor = false;
            this.deleteStudentBtn.Click += new System.EventHandler(this.ShowStudentDeleteForm);
            // 
            // strudentDetailsBtn
            // 
            this.strudentDetailsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strudentDetailsBtn.Location = new System.Drawing.Point(324, 44);
            this.strudentDetailsBtn.Name = "strudentDetailsBtn";
            this.strudentDetailsBtn.Size = new System.Drawing.Size(196, 43);
            this.strudentDetailsBtn.TabIndex = 1;
            this.strudentDetailsBtn.Text = "Pregled detalja";
            this.strudentDetailsBtn.UseVisualStyleBackColor = false;
            this.strudentDetailsBtn.Click += new System.EventHandler(this.ShowStudentDetailsForm);
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
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 286);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.actionDescriptionLbl);
            this.Controls.Add(this.nameOfStudentLbl);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.editStudentBtn);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.strudentDetailsBtn);
            this.Controls.Add(this.backToMenuBtn);
            this.Name = "StudentsList";
            this.Text = "StudentsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.TextBox actionDescriptionLbl;
        private System.Windows.Forms.TextBox nameOfStudentLbl;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button strudentDetailsBtn;
        private System.Windows.Forms.Button backToMenuBtn;
    }
}