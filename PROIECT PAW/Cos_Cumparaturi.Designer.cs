
namespace PROIECT_PAW
{
    partial class Cos_Cumparaturi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderProduse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderProduseSelectate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPreturi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVizualizareComanda = new System.Windows.Forms.Button();
            this.buttonRenuntare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProduse});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 337);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeaderProduse
            // 
            this.columnHeaderProduse.Text = "PRODUSE";
            this.columnHeaderProduse.Width = 100;
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProduseSelectate,
            this.columnHeaderPreturi});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(520, 82);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(483, 312);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            this.listView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView2_DragEnter);
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
            // 
            // columnHeaderProduseSelectate
            // 
            this.columnHeaderProduseSelectate.Text = "Produse selectate";
            this.columnHeaderProduseSelectate.Width = 302;
            // 
            // columnHeaderPreturi
            // 
            this.columnHeaderPreturi.Text = "Pret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coș";
            // 
            // buttonVizualizareComanda
            // 
            this.buttonVizualizareComanda.Location = new System.Drawing.Point(376, 437);
            this.buttonVizualizareComanda.Name = "buttonVizualizareComanda";
            this.buttonVizualizareComanda.Size = new System.Drawing.Size(335, 74);
            this.buttonVizualizareComanda.TabIndex = 3;
            this.buttonVizualizareComanda.Text = "Am terminat de adăugat în coș. Doresc să achit";
            this.buttonVizualizareComanda.UseVisualStyleBackColor = true;
            this.buttonVizualizareComanda.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRenuntare
            // 
            this.buttonRenuntare.Location = new System.Drawing.Point(809, 437);
            this.buttonRenuntare.Name = "buttonRenuntare";
            this.buttonRenuntare.Size = new System.Drawing.Size(305, 74);
            this.buttonRenuntare.TabIndex = 4;
            this.buttonRenuntare.Text = "Renunț la această comandă";
            this.buttonRenuntare.UseVisualStyleBackColor = true;
            this.buttonRenuntare.Click += new System.EventHandler(this.buttonRenuntare_Click);
            // 
            // Cos_Cumparaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 540);
            this.Controls.Add(this.buttonRenuntare);
            this.Controls.Add(this.buttonVizualizareComanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Cos_Cumparaturi";
            this.Text = "Cos_Cumparaturi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderProduse;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderProduseSelectate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderPreturi;
        private System.Windows.Forms.Button buttonVizualizareComanda;
        private System.Windows.Forms.Button buttonRenuntare;
    }
}