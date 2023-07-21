using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Cos_Cumparaturi : Form
    {
        private int imageIndex;
        public List<Produs> lista_produse_cos;
        public Cos_Cumparaturi()
        {

            InitializeComponent();

            populare();
        }
        private void populare()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);
            String[] paths = { };
            paths = Directory.GetFiles("flori");
            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Produs p1 = new Produs("Trandafiri 15", 200, 17);
            Produs p2 = new Produs("ADELINA", 145.99, 11);
            Produs p3 = new Produs("Box 74", 199.99, 71);
            Produs p4 = new Produs("Cufar cu flori", 200.12, 11);
            Produs p5 = new Produs("Buchet mixt", 165.29, 17);
            Produs p6 = new Produs("Buchet primavara", 99.99, 12);
            Produs p7 = new Produs("Buchet 15 lalele", 140, 51);
            listView1.SmallImageList = imgs;
            listView2.SmallImageList = imgs;
            listView1.Items.Add("Buchet 15 trandafiri", 0);
            listView1.Items[0].Tag = p1;
            listView1.Items.Add("ADELINA", 1);
            listView1.Items[1].Tag = p2;
            listView1.Items.Add("BOX 74", 2);
            listView1.Items[2].Tag = p3;
            listView1.Items.Add("Cufar cu flori", 3);
            listView1.Items[3].Tag = p4;
            listView1.Items.Add("Buchet mixt", 4);
            listView1.Items[4].Tag = p5;
            listView1.Items.Add("Buchet primavara", 5);
            listView1.Items[5].Tag = p6;
            listView1.Items.Add("Buchet 15 lalele", 6);
            listView1.Items[6].Tag = p7;
        }

       

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Produs ppp = (Produs)listView1.SelectedItems[0].Tag;
            MessageBox.Show("Produsul selectat costa " + ppp.Pret.ToString() + " RON");
        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                listView1.DoDragDrop(listView1.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;

            }
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            
            if (e!=null)
            {
               
                Produs p = (Produs)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag;
                ListViewItem lv = new ListViewItem(p.Denumire);
                lv.SubItems.Add(p.Pret.ToString());
                listView2.Items.Add(lv);
                lv.Tag = p;
            }
           
        }
       public bool p = true;//bool declarat pt a vedea daca se doreste plasarea comenzii
        private void button1_Click(object sender, EventArgs e)
        {
            double suma_totala=0;
           
            List<Produs> lista = listView2.Items.Cast<ListViewItem>()
                    .Select(item => (Produs)item.Tag)
                    .ToList();
            lista_produse_cos = lista;
            foreach (Produs p in lista)
            {
                suma_totala += p.Pret;
                

            }
            string mesaj = "Aveti de achitat " + suma_totala + " RON.Continuati?";
            DialogResult dialogResult = MessageBox.Show(mesaj, "Plasare comanda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                p = false;
            }
                
        }

        private void buttonRenuntare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
