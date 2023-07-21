
namespace PROIECT_PAW
{
    partial class Form_Clienti
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
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvareClienti = new System.Windows.Forms.Button();
            this.buttonRestaurareClienti = new System.Windows.Forms.Button();
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderParola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewClienti
            // 
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderNrTelefon,
            this.columnHeaderEmail,
            this.columnHeaderParola});
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(12, 63);
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.Size = new System.Drawing.Size(615, 346);
            this.listViewClienti.TabIndex = 0;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 67;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 90;
            // 
            // columnHeaderNrTelefon
            // 
            this.columnHeaderNrTelefon.Text = "Numar telefon";
            this.columnHeaderNrTelefon.Width = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Clienti";
            // 
            // buttonSalvareClienti
            // 
            this.buttonSalvareClienti.Location = new System.Drawing.Point(659, 100);
            this.buttonSalvareClienti.Name = "buttonSalvareClienti";
            this.buttonSalvareClienti.Size = new System.Drawing.Size(111, 23);
            this.buttonSalvareClienti.TabIndex = 2;
            this.buttonSalvareClienti.Text = "Salveaza binar";
            this.buttonSalvareClienti.UseVisualStyleBackColor = true;
            this.buttonSalvareClienti.Click += new System.EventHandler(this.buttonSalvareClienti_Click);
            // 
            // buttonRestaurareClienti
            // 
            this.buttonRestaurareClienti.Location = new System.Drawing.Point(646, 159);
            this.buttonRestaurareClienti.Name = "buttonRestaurareClienti";
            this.buttonRestaurareClienti.Size = new System.Drawing.Size(142, 23);
            this.buttonRestaurareClienti.TabIndex = 3;
            this.buttonRestaurareClienti.Text = "Restaureaza date";
            this.buttonRestaurareClienti.UseVisualStyleBackColor = true;
            this.buttonRestaurareClienti.Click += new System.EventHandler(this.buttonRestaurareClienti_Click);
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            // 
            // columnHeaderParola
            // 
            this.columnHeaderParola.Text = "Parola";
            // 
            // Form_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRestaurareClienti);
            this.Controls.Add(this.buttonSalvareClienti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewClienti);
            this.Name = "Form_Clienti";
            this.Text = "Form_Clienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderNrTelefon;
        private System.Windows.Forms.Button buttonSalvareClienti;
        private System.Windows.Forms.Button buttonRestaurareClienti;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderParola;
    }
}