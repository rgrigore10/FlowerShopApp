using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }



        private void vizuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Produse fp = new Form_Produse();
            fp.ShowDialog();
        }

        private void plasareComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cont_Client fcc = new Form_Cont_Client();
            fcc.ShowDialog();
        }

        private void evolutieComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic fg = new FormGrafic();
            fg.ShowDialog();
        }
    }
}
