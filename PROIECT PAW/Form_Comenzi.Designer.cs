
namespace PROIECT_PAW
{
    partial class Form_Comenzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Comenzi));
            this.listViewComenzi = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataComenzii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProduse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFactura = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelFurnizor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewComenzi
            // 
            this.listViewComenzi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDataComenzii,
            this.columnHeaderProduse,
            this.columnHeaderClient,
            this.columnHeaderSuma});
            this.listViewComenzi.HideSelection = false;
            resources.ApplyResources(this.listViewComenzi, "listViewComenzi");
            this.listViewComenzi.Name = "listViewComenzi";
            this.listViewComenzi.UseCompatibleStateImageBehavior = false;
            this.listViewComenzi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            resources.ApplyResources(this.columnHeaderID, "columnHeaderID");
            // 
            // columnHeaderDataComenzii
            // 
            resources.ApplyResources(this.columnHeaderDataComenzii, "columnHeaderDataComenzii");
            // 
            // columnHeaderProduse
            // 
            resources.ApplyResources(this.columnHeaderProduse, "columnHeaderProduse");
            // 
            // columnHeaderClient
            // 
            resources.ApplyResources(this.columnHeaderClient, "columnHeaderClient");
            // 
            // columnHeaderSuma
            // 
            resources.ApplyResources(this.columnHeaderSuma, "columnHeaderSuma");
            // 
            // labelFactura
            // 
            resources.ApplyResources(this.labelFactura, "labelFactura");
            this.labelFactura.Name = "labelFactura";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // buttonPrint
            // 
            resources.ApplyResources(this.buttonPrint, "buttonPrint");
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelFurnizor
            // 
            resources.ApplyResources(this.labelFurnizor, "labelFurnizor");
            this.labelFurnizor.Name = "labelFurnizor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form_Comenzi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFurnizor);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelFactura);
            this.Controls.Add(this.listViewComenzi);
            this.Name = "Form_Comenzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewComenzi;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderDataComenzii;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.ColumnHeader columnHeaderProduse;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelFurnizor;
        private System.Windows.Forms.ColumnHeader columnHeaderSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}