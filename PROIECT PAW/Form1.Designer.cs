﻿
namespace PROIECT_PAW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plasareComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolutieComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizuToolStripMenuItem,
            this.plasareComandaToolStripMenuItem,
            this.evolutieComenziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizuToolStripMenuItem
            // 
            this.vizuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem});
            this.vizuToolStripMenuItem.Name = "vizuToolStripMenuItem";
            this.vizuToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.vizuToolStripMenuItem.Text = "Vizualizare produse";
            this.vizuToolStripMenuItem.Click += new System.EventHandler(this.vizuToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            // 
            // plasareComandaToolStripMenuItem
            // 
            this.plasareComandaToolStripMenuItem.Name = "plasareComandaToolStripMenuItem";
            this.plasareComandaToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.plasareComandaToolStripMenuItem.Text = "Plasare Comanda";
            this.plasareComandaToolStripMenuItem.Click += new System.EventHandler(this.plasareComandaToolStripMenuItem_Click);
            // 
            // evolutieComenziToolStripMenuItem
            // 
            this.evolutieComenziToolStripMenuItem.Name = "evolutieComenziToolStripMenuItem";
            this.evolutieComenziToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.evolutieComenziToolStripMenuItem.Text = "Evolutie comenzi";
            this.evolutieComenziToolStripMenuItem.Click += new System.EventHandler(this.evolutieComenziToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1023, 536);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plasareComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolutieComenziToolStripMenuItem;
    }
}

