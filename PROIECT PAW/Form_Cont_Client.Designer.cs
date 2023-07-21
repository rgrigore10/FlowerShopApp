
namespace PROIECT_PAW
{
    partial class Form_Cont_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAccesareCont = new System.Windows.Forms.Button();
            this.buttonCreareCont = new System.Windows.Forms.Button();
            this.userControlParola1 = new PROIECT_PAW.UserControlParola();
            this.userControlEmail1 = new PROIECT_PAW.UserControlEmail();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 75);
            this.label3.MinimumSize = new System.Drawing.Size(100, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bine ați venit!";
            
            // 
            // buttonAccesareCont
            // 
            this.buttonAccesareCont.Location = new System.Drawing.Point(305, 300);
            this.buttonAccesareCont.Name = "buttonAccesareCont";
            this.buttonAccesareCont.Size = new System.Drawing.Size(156, 41);
            this.buttonAccesareCont.TabIndex = 5;
            this.buttonAccesareCont.Text = "Acceseaza cont";
            this.buttonAccesareCont.UseVisualStyleBackColor = true;
            this.buttonAccesareCont.Click += new System.EventHandler(this.buttonAccesareCont_Click);
            // 
            // buttonCreareCont
            // 
            this.buttonCreareCont.Location = new System.Drawing.Point(239, 371);
            this.buttonCreareCont.Name = "buttonCreareCont";
            this.buttonCreareCont.Size = new System.Drawing.Size(284, 40);
            this.buttonCreareCont.TabIndex = 6;
            this.buttonCreareCont.Text = "Nu am cont. Vreau sa creez unul";
            this.buttonCreareCont.UseVisualStyleBackColor = true;
            this.buttonCreareCont.Click += new System.EventHandler(this.buttonCreareCont_Click);
            // 
            // userControlParola1
            // 
            this.userControlParola1.Location = new System.Drawing.Point(239, 208);
            this.userControlParola1.Name = "userControlParola1";
            this.userControlParola1.Size = new System.Drawing.Size(251, 74);
            this.userControlParola1.TabIndex = 8;
            // 
            // userControlEmail1
            // 
            this.userControlEmail1.Location = new System.Drawing.Point(239, 130);
            this.userControlEmail1.Name = "userControlEmail1";
            this.userControlEmail1.Size = new System.Drawing.Size(251, 72);
            this.userControlEmail1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Cont_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlParola1);
            this.Controls.Add(this.userControlEmail1);
            this.Controls.Add(this.buttonCreareCont);
            this.Controls.Add(this.buttonAccesareCont);
            this.Controls.Add(this.label3);
            this.Name = "Form_Cont_Client";
            this.Text = "Form_Cont_Client";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAccesareCont;
        private System.Windows.Forms.Button buttonCreareCont;
        private UserControlEmail userControlEmail1;
        private UserControlParola userControlParola1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}