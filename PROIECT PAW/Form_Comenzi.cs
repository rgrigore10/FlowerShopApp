using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing.Printing;
namespace PROIECT_PAW
{
    public partial class Form_Comenzi : Form
    {
        public Comanda com;
        public Form_Comenzi(Comanda c)
        {
            InitializeComponent();
            com = c;
        }
        public void generarecomanda()
        {
            double suma = 0;
            List<string> denumiri = new List<string>();
            ListViewItem lvi = new ListViewItem(new string[] { "", "" , "", "","" ,"",""});
            lvi.Tag = com;
            listViewComenzi.Items.Add(lvi);
            lvi.Selected = true;
            SqlConnection sq = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raluc\source\repos\PROIECT PAW\PROIECT PAW\DB_1.mdf;Integrated Security=True;Connect Timeout=30");
            sq.Open();
            foreach (ListViewItem lv1 in listViewComenzi.Items)
            {
                Comanda c = (Comanda)lv1.Tag;
                //lv1.Text = c.client.Email;
                foreach (Produs p in c.produse)
                {
                    denumiri.Add(p.Denumire);
                    suma += p.Pret;
                }
                
                lv1.SubItems[1].Text = c.data_comenzii.ToString();
                string s = string.Join(",", denumiri.ToArray());//transforma o lista de stringuri intr un string
                lv1.SubItems[2].Text = s;

                lv1.SubItems[3].Text = c.client.Email;
                
                lv1.SubItems[4].Text = suma.ToString();
                

               
                SqlCommand cmd1 = new SqlCommand("INSERT INTO  Comenzi(Data_comenzii,Lista_de_produse,Email_client,Pret_total) VALUES(@Data, @Lista,  @Email,@Pret) ", sq);
                cmd1.Parameters.Add("@Data", DateTime.Now.ToString());
                cmd1.Parameters.Add("@Lista", s);
                cmd1.Parameters.Add("@Email", c.client.Email);
                cmd1.Parameters.Add("@Pret", suma.ToString());
                
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select ident_current('Comenzi')", sq);//selecteaza ultimul id introdus
                SqlDataReader sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    lv1.Text = sdr.GetValue(0).ToString();//pune id ul din bd in listview(am nev de el pt imprimare)
                }
            }
            sq.Close();
           
            
            Comanda comanda = new Comanda();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
    
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            
            
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Am creat un Bitmap de aceeasi marime ca si Form ul
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Am copiat aria pe care panel ul o converteste
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            //Arata Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}
