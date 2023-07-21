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
namespace PROIECT_PAW
{
    public partial class Form_Cont_Client : Form
    {
       
       public Cos_Cumparaturi cos =new Cos_Cumparaturi();
        public Client client=new Client();
        public Form_Cont_Client()
        {
            InitializeComponent();
            
        }

      
      

        private void buttonCreareCont_Click(object sender, EventArgs e)
        {
           
            Form_Creare_Cont_Client fccc = new Form_Creare_Cont_Client();
            fccc.Show();
        }

        private void buttonAccesareCont_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raluc\source\repos\PROIECT PAW\PROIECT PAW\DB_1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select * from Clienti where Email=@Email and Parola=@Parola", sq);
                cmd.Parameters.AddWithValue("@Email", userControlEmail1.GetEmail);
            cmd.Parameters.AddWithValue("@Parola", userControlParola1.GetParola);
            sq.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            //sq.Close();
            int count = ds.Tables[0].Rows.Count;
            bool ok = true;
            if (count == 1)
            {
                SqlCommand cmd1 = new SqlCommand("select Nume,Prenume,Nr_Telefon,Email,Parola from Clienti where Email=@Email and Parola=@Parola", sq);
                cmd1.Parameters.AddWithValue("@Email", userControlEmail1.GetEmail);
                cmd1.Parameters.AddWithValue("@Parola", userControlParola1.GetParola);
                SqlDataReader sdr = cmd1.ExecuteReader();
                while (sdr.Read())
                {
                    client.Nume = sdr.GetValue(0).ToString();
                    client.Prenume = sdr.GetValue(1).ToString();
                    client.Nr_telefon = sdr.GetValue(2).ToString();
                    client.Email = sdr.GetValue(3).ToString();
                    client.Parola = sdr.GetValue(4).ToString();
                }
                cos.ShowDialog();
                ok = false;
                cos.Close();
            }
            else
                MessageBox.Show("Emailul sau parola sunt introduse gresit");
            
          
            if (ok == false&& cos.p==false){

               
                   
                    Comanda c = new Comanda();
                    c.data_comenzii = DateTime.Now;
                    c.produse = cos.lista_produse_cos;
                    c.client = client;
                  
                    Form_Comenzi f = new Form_Comenzi(c);
                    f.generarecomanda();
                    MessageBox.Show("Comanda a fost plasata cu succes!");
                    f.ShowDialog();
                    this.Close();
                    

          

            }
            sq.Close();
        }
    }
}
