
namespace PROIECT_PAW
{
    partial class Form_Creare_Cont_Client
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
            this.components = new System.ComponentModel.Container();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNrTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxNrTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonSalvareBinar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonVerificare = new System.Windows.Forms.Button();
            this.buttonSalvareBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(101, 76);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "&Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(101, 122);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNrTelefon
            // 
            this.labelNrTelefon.AutoSize = true;
            this.labelNrTelefon.Location = new System.Drawing.Point(101, 175);
            this.labelNrTelefon.Name = "labelNrTelefon";
            this.labelNrTelefon.Size = new System.Drawing.Size(117, 17);
            this.labelNrTelefon.TabIndex = 2;
            this.labelNrTelefon.Text = "Numar de telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(101, 219);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Location = new System.Drawing.Point(101, 270);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(49, 17);
            this.labelParola.TabIndex = 4;
            this.labelParola.Text = "Parola";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(339, 76);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 5;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            this.textBoxNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNume_KeyDown);
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            this.textBoxNume.Validated += new System.EventHandler(this.textBoxNume_Validated);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(339, 122);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenume.TabIndex = 6;
            this.textBoxPrenume.TextChanged += new System.EventHandler(this.textBoxPrenume_TextChanged);
            this.textBoxPrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPrenume_KeyDown);
            this.textBoxPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrenume_Validating);
            this.textBoxPrenume.Validated += new System.EventHandler(this.textBoxPrenume_Validated);
            // 
            // textBoxNrTelefon
            // 
            this.textBoxNrTelefon.Location = new System.Drawing.Point(339, 169);
            this.textBoxNrTelefon.Name = "textBoxNrTelefon";
            this.textBoxNrTelefon.Size = new System.Drawing.Size(100, 22);
            this.textBoxNrTelefon.TabIndex = 7;
            this.textBoxNrTelefon.TextChanged += new System.EventHandler(this.textBoxNrTelefon_TextChanged);
            this.textBoxNrTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNrTelefon_KeyDown);
            this.textBoxNrTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNrTelefon_Validating);
            this.textBoxNrTelefon.Validated += new System.EventHandler(this.textBoxNrTelefon_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(339, 219);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(339, 270);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(100, 22);
            this.textBoxParola.TabIndex = 9;
            this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
            this.textBoxParola.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxParola_Validating);
            this.textBoxParola.Validated += new System.EventHandler(this.textBoxParola_Validated);
            // 
            // buttonSalvareBinar
            // 
            this.buttonSalvareBinar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSalvareBinar.Location = new System.Drawing.Point(134, 350);
            this.buttonSalvareBinar.Name = "buttonSalvareBinar";
            this.buttonSalvareBinar.Size = new System.Drawing.Size(188, 38);
            this.buttonSalvareBinar.TabIndex = 10;
            this.buttonSalvareBinar.Text = "Salveaza binar";
            this.buttonSalvareBinar.UseVisualStyleBackColor = true;
            this.buttonSalvareBinar.Click += new System.EventHandler(this.buttonSalvare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonVerificare
            // 
            this.buttonVerificare.Location = new System.Drawing.Point(564, 154);
            this.buttonVerificare.Name = "buttonVerificare";
            this.buttonVerificare.Size = new System.Drawing.Size(120, 37);
            this.buttonVerificare.TabIndex = 11;
            this.buttonVerificare.Text = "Verificare date";
            this.buttonVerificare.UseVisualStyleBackColor = true;
            this.buttonVerificare.Click += new System.EventHandler(this.buttonVerificare_Click);
            // 
            // buttonSalvareBD
            // 
            this.buttonSalvareBD.Location = new System.Drawing.Point(385, 350);
            this.buttonSalvareBD.Name = "buttonSalvareBD";
            this.buttonSalvareBD.Size = new System.Drawing.Size(245, 38);
            this.buttonSalvareBD.TabIndex = 12;
            this.buttonSalvareBD.Text = "Salveaza în baza de date";
            this.buttonSalvareBD.UseVisualStyleBackColor = true;
            this.buttonSalvareBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Creare_Cont_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalvareBD);
            this.Controls.Add(this.buttonVerificare);
            this.Controls.Add(this.buttonSalvareBinar);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNrTelefon);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNrTelefon);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "Form_Creare_Cont_Client";
            this.Text = "Form_Creare_Cont_Client";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNrTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Button buttonSalvareBinar;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxNume;
        public System.Windows.Forms.TextBox textBoxPrenume;
        public System.Windows.Forms.TextBox textBoxNrTelefon;
        public System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonVerificare;
        private System.Windows.Forms.Button buttonSalvareBD;
    }
}