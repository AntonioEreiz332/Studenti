namespace radSaViseForma
{
    partial class frmStudenti
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
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisiStudent = new System.Windows.Forms.Button();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.Location = new System.Drawing.Point(12, 80);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(281, 173);
            this.listBoxStudenti.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 28);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(141, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj novog studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnObrisiStudent
            // 
            this.btnObrisiStudent.Location = new System.Drawing.Point(299, 167);
            this.btnObrisiStudent.Name = "btnObrisiStudent";
            this.btnObrisiStudent.Size = new System.Drawing.Size(111, 23);
            this.btnObrisiStudent.TabIndex = 2;
            this.btnObrisiStudent.Text = "Obrisi studenta";
            this.btnObrisiStudent.UseVisualStyleBackColor = true;
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(12, 279);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(141, 23);
            this.btnObrisiSve.TabIndex = 3;
            this.btnObrisiSve.Text = "Obrisi sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 331);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnObrisiStudent);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listBoxStudenti);
            this.Name = "frmStudenti";
            this.Text = "frmStudenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisiStudent;
        private System.Windows.Forms.Button btnObrisiSve;
    }
}

