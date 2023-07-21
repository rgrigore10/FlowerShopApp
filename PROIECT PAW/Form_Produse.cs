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
    public partial class Form_Produse : Form
    {
        private int imageIndex;

        public Form_Produse()
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
                foreach(String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }catch(Exception e)
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
            listViewProduse.SmallImageList = imgs;
           listViewProduse.Items.Add("Buchet 15 trandafiri",0);
            listViewProduse.Items[0].Tag = p1;
            listViewProduse.Items.Add("ADELINA",1);
            listViewProduse.Items[1].Tag = p2;
            listViewProduse.Items.Add("BOX 74",2);
            listViewProduse.Items[2].Tag = p3;
            listViewProduse.Items.Add("Cufar cu flori",3);
            listViewProduse.Items[3].Tag = p4;
            listViewProduse.Items.Add("Buchet mixt",4);
            listViewProduse.Items[4].Tag = p5;
            listViewProduse.Items.Add("Buchet primavara",5);
            listViewProduse.Items[5].Tag = p6;
            listViewProduse.Items.Add("Buchet 15 lalele",6);
            listViewProduse.Items[6].Tag = p7;
        }

        private void listViewProduse_MouseClick(object sender, MouseEventArgs e)
        {
            Produs ppp = (Produs)listViewProduse.SelectedItems[0].Tag;
            MessageBox.Show("Produsul selectat costa " + ppp.Pret.ToString()+ " RON");
        }
    }
}
