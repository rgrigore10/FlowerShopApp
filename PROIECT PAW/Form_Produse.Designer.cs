
namespace PROIECT_PAW
{
    partial class Form_Produse
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
            this.listViewProduse = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeaderFLORI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProduse
            // 
            this.listViewProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFLORI});
            this.listViewProduse.HideSelection = false;
            this.listViewProduse.Location = new System.Drawing.Point(125, 76);
            this.listViewProduse.Name = "listViewProduse";
            this.listViewProduse.Size = new System.Drawing.Size(511, 362);
            this.listViewProduse.TabIndex = 0;
            this.listViewProduse.UseCompatibleStateImageBehavior = false;
            this.listViewProduse.View = System.Windows.Forms.View.Details;
            this.listViewProduse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProduse_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de produse";
            // 
            // columnHeaderFLORI
            // 
            this.columnHeaderFLORI.Text = "PRODUSE";
            this.columnHeaderFLORI.Width = 168;
            // 
            // Form_Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProduse);
            this.Name = "Form_Produse";
            this.Text = "Form_Produse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderFLORI;
    }
}