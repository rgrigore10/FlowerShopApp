using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Form_Clienti : Form
    {
       public Client cl;
        public List<Client> lista_clienti;
        public Form_Clienti()
        {
            InitializeComponent();
        }
        public Form_Clienti(Client c)//am facut un constructor cu parametru pentru a putea primi datele clientului introduse in form_creare_cont_client
        {
            InitializeComponent();
            cl = c;
            //Client client = new Client("Grigore", "Raluca", "raluca@mail", "0723211231", "parola");
            //ListViewItem lv1 = new ListViewItem(client.Nume);
            //lv1.SubItems.Add(client.Prenume);
            //lv1.SubItems.Add(client.Nr_telefon);
            //lv1.SubItems.Add(client.Email);
            //lv1.SubItems.Add(client.Parola);
            //lv1.Tag = client;
            //listViewClienti.Items.Add(lv1);
        }
     
        
        private void buttonSalvareClienti_Click(object sender, EventArgs e)//salvare clienti binar
        {


            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare clienti (*.clienti)|*.clienti";// se face o filtrare dupa ce se aflta in dreapta |
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Client> lista = listViewClienti.Items.Cast<ListViewItem>()
                    .Select(item => (Client)item.Tag)
                    .ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }
        
       public void crearecont() //adaugare client din form_creare_cont_client in listviewClienti
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "" });
            
            lvi.Tag = cl;
            listViewClienti.Items.Add(lvi);
            lvi.Selected = true;
            UpdateItems();
           
        }
        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listViewClienti.Items)
            {
                Client c = (Client)lvi.Tag;
                lvi.Text = c.Nume;
                lvi.SubItems[1].Text = c.Prenume;

                lvi.SubItems[2].Text = c.Nr_telefon;
                lvi.SubItems[3].Text = c.Email;
                lvi.SubItems[4].Text = c.Parola;

            }
        }
        public void verificare_date()
        {


            //OpenFileDialog fd = new OpenFileDialog();
            //fd.CheckFileExists = true;
            //fd.CheckPathExists = true;
            //fd.Filter = "fisiere binare clienti (*.clienti)|*.clienti";
            //if (fd.ShowDialog() == DialogResult.OK)
            //{

            //    Stream fb = File.OpenRead(fd.FileName);
            //    BinaryFormatter deserializator = new BinaryFormatter();
            //        List<Client> lista1 = (List<Client>)deserializator.Deserialize(fb);
            //        listViewClienti.Items.Clear();


            //        fb.Close();
            //}
            FileStream fileStream = new FileStream("clienti_florarie.clienti", FileMode.Open,FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Client> lista1 = (List<Client>)bf.Deserialize(fileStream);
            foreach (Client c in lista1)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "" });
                lvi.Tag = c;
                listViewClienti.Items.Add(lvi);
            }
            UpdateItems();
            List<Client> lista = listViewClienti.Items.Cast<ListViewItem>()
               .Select(item => (Client)item.Tag)
               .ToList();
            lista_clienti = lista;
            fileStream.Close();

        }
        public void buttonRestaurareClienti_Click(object sender, EventArgs e)//restaurare date binar
                {
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.CheckFileExists = true;
                    fd.CheckPathExists = true;
                    fd.Filter = "fisiere binare clienti (*.clienti)|*.clienti";
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        Stream fb = File.OpenRead(fd.FileName);
                        BinaryFormatter deserializator = new BinaryFormatter();
                        List<Client> lista = (List<Client>)deserializator.Deserialize(fb);
                        listViewClienti.Items.Clear();

                        foreach (Client c in lista)
                        {
                            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" ,""});
                            lvi.Tag = c;
                            listViewClienti.Items.Add(lvi);
                        }
                        UpdateItems();
                        fb.Close();
                    }
                }
                
            
        
    }
}