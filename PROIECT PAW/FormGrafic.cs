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
using System.Windows.Forms.DataVisualization.Charting;

namespace PROIECT_PAW
{
    public partial class FormGrafic : Form
    {
        string connection=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raluc\source\repos\PROIECT PAW\PROIECT PAW\DB_1.mdf;Integrated Security=True;Connect Timeout=30";
        public FormGrafic()
        {
            InitializeComponent();
        }

        private void buttonPopulare_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connection))
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from comenzi",sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //var objchart = chart1.ChartAreas[0];
            //objchart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            ////pe axa x aveam zilele dintr o saptamana
            //objchart.AxisX.Minimum = 1;
            //objchart.AxisX.Maximum = 7;

            //objchart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //objchart.AxisY.Minimum = 0;
            //objchart.AxisY.Maximum = 2000;

            //chart1.Series.Clear();
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
           
            
            
            
            double suma1=0, suma2=0,suma3=0,suma4=0,suma5=0,suma6=0,suma7=0;
           
            SqlCommand cmd1 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=cast(getdate() as date)", sqlcon);
            

            cmd1.ExecuteNonQuery();
            
            SqlDataReader sdr = cmd1.ExecuteReader();
            while (sdr.Read())
            {
                try
                {
                    suma7 = (double)sdr.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma7 = 0;
                }
               
            }
            sdr.Close();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-1, cast(getdate() as date))", sqlcon);


            cmd2.ExecuteNonQuery();

            SqlDataReader sdr1 = cmd2.ExecuteReader();
            while (sdr1.Read())
            {
                try
                {
                    suma6 = (double)sdr1.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma6 = 0;
                }
                
                    
               
            }
            sdr1.Close();
            SqlCommand cmd3= new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-2, cast(getdate() as date))", sqlcon);


            cmd3.ExecuteNonQuery();

            SqlDataReader sdr2 = cmd3.ExecuteReader();
            while (sdr2.Read())
            {
                try
                {
                    suma5 = (double)sdr2.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma5 = 0;
                }

            }
            sdr2.Close();
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-3, cast(getdate() as date))", sqlcon);


            cmd4.ExecuteNonQuery();

            SqlDataReader sdr3 = cmd4.ExecuteReader();
            while (sdr3.Read())
            {
                try
                {
                    suma4 = (double)sdr3.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma4 = 0;
                }

            }
            sdr3.Close();
            SqlCommand cmd5 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-4, cast(getdate() as date))", sqlcon);


            cmd5.ExecuteNonQuery();

            SqlDataReader sdr4 = cmd5.ExecuteReader();
            while (sdr4.Read())
            {
                try
                {
                    suma3 = (double)sdr4.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma3 = 0;
                }

            }
            sdr4.Close();
            SqlCommand cmd6 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-5, cast(getdate() as date))", sqlcon);


            cmd6.ExecuteNonQuery();

            SqlDataReader sdr5 = cmd6.ExecuteReader();
            while (sdr5.Read())
            {
                try
                {
                    suma2 = (double)sdr5.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma2 = 0;
                }

            }
            sdr5.Close();
            SqlCommand cmd7 = new SqlCommand("SELECT SUM(Pret_total) as total FROM Comenzi WHERE CAST(Data_comenzii AS DATE)=dateadd(day,-6, cast(getdate() as date))", sqlcon);


            cmd7.ExecuteNonQuery();

            SqlDataReader sdr6 = cmd7.ExecuteReader();
            while (sdr6.Read())
            {
                try
                {
                    suma1 = (double)sdr6.GetValue(0);//pune id ul din bd in listview(am nev de el pt imprimare)
                }
                catch
                {
                    suma1 = 0;
                }

            }
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("1", suma1);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("2", suma2);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("3", suma3);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("4", suma4);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("5", suma5);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("6", suma6);
            chart1.Series["Venituri_zilnice_din_comenzi"].Points.AddXY("7", suma7);

        }

      
    }
}
