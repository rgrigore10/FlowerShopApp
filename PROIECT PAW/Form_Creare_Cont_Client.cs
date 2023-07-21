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
    
    public partial class Form_Creare_Cont_Client : Form
    {
        public Client client;

       
        ListViewItem lv1;
        SqlConnection sqlc;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Form_Creare_Cont_Client(Client c)
        {
            InitializeComponent();
            client = c ;
            this.ActiveControl = textBoxNume;
            textBoxNume.Focus();
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;

        }
        public Form_Creare_Cont_Client()
        {
            InitializeComponent();
            this.ActiveControl = textBoxNume;
            textBoxNume.Focus();
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            
            
            Client c = new Client();
            c.Nume = textBoxNume.Text;
            c.Prenume = textBoxPrenume.Text;
            c.Nr_telefon = textBoxNrTelefon.Text;
            c.Email = textBoxEmail.Text;
            c.Parola = textBoxParola.Text;
            client = c;
            Form_Clienti f = new Form_Clienti(client);
            f.crearecont();
            f.ShowDialog();
            this.Close();

           
        }
        //acceleratori
        private void textBoxNume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxPrenume.Focus();
        }

        private void textBoxPrenume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxNrTelefon.Focus();
        }

        private void textBoxNrTelefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxEmail.Focus();
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxParola.Focus();
        }
        //validari
        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNume.Text))
            {
                e.Cancel = true;
                textBoxNume.Focus();
                errorProvider1.SetError(textBoxNume, "Acest camp nu poate fi gol");
            }
        }

        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNume, "");
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPrenume.Text))
            {
                e.Cancel = true;
                textBoxPrenume.Focus();
                errorProvider1.SetError(textBoxPrenume, "Acest camp nu poate fi gol");
            }
        }

        private void textBoxPrenume_Validated(object sender, EventArgs e)
        {
           
                errorProvider1.SetError(textBoxPrenume, "");
            
        }
        bool o;
        private void textBoxNrTelefon_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxNrTelefon.Text.Substring(0, 1) != "0" && textBoxNrTelefon.Text.Substring(1, 1) != "7")
            {

                e.Cancel = true;
                textBoxNrTelefon.Focus();
                errorProvider1.SetError(textBoxNrTelefon, "Numarul de telefon trebuie sa inceapa cu prefixul 07 ");


            }


            else if (textBoxNrTelefon.Text.Length != 10)
            {
                e.Cancel = true;
                textBoxNrTelefon.Focus();
                errorProvider1.SetError(textBoxNrTelefon, "Numarul de telefon trebuie sa contina 10 cifre");
            }
            else if(textBoxNrTelefon.Text.Length == 10)
            {
                //bool ok = true;
                o = true;

                foreach (char c in textBoxNrTelefon.Text)
                {
                    if (c < '0' || c > '9')
                        o = false;//nr de telefon contine un caracter care nu e cifra
                }
                if (o == false)
                {
                   
                    e.Cancel = true;
                    textBoxNrTelefon.Focus();
                    errorProvider1.SetError(textBoxNrTelefon, "Acest camp poate contine doar cifre");
                }
                
            }
           

                    
        }
           

        

        private void textBoxNrTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNrTelefon, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                e.Cancel = true;
                textBoxEmail.Focus();
                errorProvider1.SetError(textBoxEmail, "Acest camp nu poate fi gol");
            }
           
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }

        private void textBoxParola_Validating(object sender, CancelEventArgs e)
        {
            

            if (textBoxParola.Text.Length<5)
            {
                e.Cancel = true;
                textBoxParola.Focus();
                errorProvider1.SetError(textBoxParola, "Parola este prea scurta. Trebuie sa contina cel putin 5 caractere");
                
            }
           
        }
        private void textBoxParola_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxParola, "");
        }
        //functie care verifica  //sa nu se poata salva datele modificate pana cand acestea nu sunt verificate
        public void verifica()
        {
            if (textBoxParola.Text.Length >= 5 && string.IsNullOrEmpty(textBoxNume.Text) == false && string.IsNullOrEmpty(textBoxPrenume.Text) == false
              && string.IsNullOrEmpty(textBoxEmail.Text) == false && o == true && textBoxNrTelefon.Text.Substring(0, 1) == "0"
              && textBoxNrTelefon.Text.Substring(1, 1) == "7" && textBoxNrTelefon.Text.Length == 10)
            {
                buttonSalvareBinar.Enabled = true;
                buttonSalvareBD.Enabled = true;
            }
            else
            {
                buttonSalvareBinar.Enabled = false;
                buttonSalvareBD.Enabled = false;
            }
        }
        private void buttonVerificare_Click(object sender, EventArgs e)
        {
            verifica();
            
        }

       

        
       
        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void textBoxPrenume_TextChanged(object sender, EventArgs e)
        {
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void textBoxNrTelefon_TextChanged(object sender, EventArgs e)
        {
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            buttonSalvareBinar.Enabled = false;
            buttonSalvareBD.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           sqlc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raluc\source\repos\PROIECT PAW\PROIECT PAW\DB_1.mdf;Integrated Security=True;Connect Timeout=30");
            sqlc.Open();
            SqlCommand cmd1 = new SqlCommand("select Nume,Prenume,Nr_Telefon,Email,Parola from Clienti where Email=@Email ", sqlc);
            cmd1.Parameters.AddWithValue("@Email", textBoxEmail.Text);
          
            SqlDataAdapter adpt = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                cmd = new SqlCommand("INSERT INTO  Clienti (Nume, Prenume,Nr_Telefon,Email,Parola) VALUES(@Nume,@Prenume,@Nr_Telefon,@Email,@Parola)", sqlc);
                cmd.Parameters.Add("@Nume", textBoxNume.Text);
                cmd.Parameters.Add("@Prenume", textBoxPrenume.Text);
                cmd.Parameters.Add("@Nr_Telefon", textBoxNrTelefon.Text);
                cmd.Parameters.Add("@Email", textBoxEmail.Text);
                cmd.Parameters.Add("@Parola", textBoxParola.Text);
                cmd.ExecuteNonQuery();
            }
            else
                MessageBox.Show("Acest email este deja asociat unui cont existent");
        }
    }
}
