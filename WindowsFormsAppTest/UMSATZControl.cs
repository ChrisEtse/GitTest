using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsAppTest
{
    public partial class UMSATZControl : UserControl
    {
        OleDbConnection connection = new OleDbConnection();

        private static UMSATZControl _instance;
        public static UMSATZControl Instance
        {

            get
            {
                if (_instance == null)

                    _instance = new UMSATZControl();
                return _instance;

            }
        }
        // CHART
        public void Populate()
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();

            }



            int sum = 0, A1 = 0;
            int sum2 = 0, A2 = 0;
            int sum3 = 0, A3 = 0;


            chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 1", sum3 = Convert.ToInt32(label4.Text));
            chart1.Series["BUCHUNGEN"].Points.AddXY("", A1 = Convert.ToInt32(label19.Text));


            chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 2", sum2 = Convert.ToInt32(label10.Text));
            chart1.Series["BUCHUNGEN"].Points.AddXY("", A2 = Convert.ToInt32(label20.Text));



            chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 3", sum = Convert.ToInt32(label9.Text));
            chart1.Series["BUCHUNGEN"].Points.AddXY("", A3 = Convert.ToInt32(label21.Text));
            
              

        }

        public UMSATZControl()
        {

            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LeRocher\Desktop\Datenbank21.accdb;
Persist Security Info=False;";

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
       


        public string Add(string lab, string lab1, string lab2)
        {
            int l = Convert.ToInt32(lab);
            int l1 = Convert.ToInt32(lab1);
            int l2 = Convert.ToInt32(lab2);
            return (l + l1 + l2).ToString();
        }

        private void btnSUMME_Click(object sender, EventArgs e)
        {


         


            tBoxChartSUM.Text = Add(label4.Text, label10.Text, label9.Text);

            // View1 wieder Laden

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                // alles anzeigen
                // string query = " select * from Tabelle1 ";

                // zeig nur
                //string query = " select Kosten from Tabelle1 ";

                string query = " select Name,Kosten from Tabelle1 ";


                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewFahrt.DataSource = dt;
                dataGridView_1.DataSource = dt;
                dataGridView_2.DataSource = dt;

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
            }


        }

    
        
        private void BtnSUCHENUmsatz_Click_1(object sender, EventArgs e)
        {
            

            connection.Open();
            OleDbCommand command = connection.CreateCommand();
          // string cmdText = "SELECT * FROM Tabelle1 " + "WHERE Datum BETWEEN ? AND ?";
         

            string cmdText = " select Name,Kosten,Istgefahren,Datum from Tabelle1 where Istgefahren = 'JA'  AND ( Datum BETWEEN ? AND ?)";

            // string cmdText = "  SELECT Istgefahren like 'JA' NOT EXISTS (SELECT * FROM Tabelle1 " + "WHERE Datum BETWEEN ? AND ?)";

            DateTime dt = this.dateTimePicker3.Value.Date;
            DateTime dt2 = this.dateTimePicker6.Value.Date.AddMinutes(1440);
            command.CommandText = cmdText;
            command.Parameters.AddWithValue("@p1", dt);
            command.Parameters.AddWithValue("@p2", dt2);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView_2.DataSource = ds.Tables[0];

            connection.Close();



            // zum addieren

            int A = 0, label3 = 0; int AnzahlKunden1 =0;
            for (A = 0; A < dataGridView_2.Rows.Count; ++A)
            {
              
                label3 += Convert.ToInt32(dataGridView_2.Rows[A].Cells[1].Value);
                AnzahlKunden1++ ;
            }
            label4.Text = label3.ToString();
         
             AnzahlKunden1 = AnzahlKunden1 -1;
            label19.Text = AnzahlKunden1.ToString();
           

            /*
            try { 
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            string cmdText = "SELECT * FROM Tabelle1 " +
                          "WHERE Datum BETWEEN ? AND ?";

            DateTime dt = this.dateTimePicker3.Value.Date;
            DateTime dt2 = this.dateTimePicker6.Value.Date.AddMinutes(1440);
            command.CommandText = cmdText;
            command.Parameters.AddWithValue("@p1", dt);
            command.Parameters.AddWithValue("@p2", dt2);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewFahrt.DataSource = ds.Tables[0];

            connection.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
            }

              // zum addieren

            int A = 0, label1 = 0;
            for (A = 0; A < dataGridViewFahrt.Rows.Count; ++A)
            {

                label1 += Convert.ToInt32(dataGridViewFahrt.Rows[A].Cells[6].Value);
            }
            label9.Text = label1.ToString();
            Label1 += label1;
            */

        }

        private void BtnSUCHENUmsatz_1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            //string cmdText = "SELECT * FROM Tabelle1 " + "WHERE Datum BETWEEN ? AND ?";
            string cmdText = " select Name,Kosten,Istgefahren,Datum from Tabelle1 where Istgefahren = 'JA'  AND ( Datum BETWEEN ? AND ?)";

            DateTime dt = this.dateTimePicker1.Value.Date;
            DateTime dt2 = this.dateTimePicker2.Value.Date.AddMinutes(1440);
            command.CommandText = cmdText;
            command.Parameters.AddWithValue("@p1", dt);
            command.Parameters.AddWithValue("@p2", dt2);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView_1.DataSource = ds.Tables[0];

            connection.Close();



            // zum addieren

            int A = 0, label2 = 0; int AnzahlKunden2 = 0;
            for (A = 0; A < dataGridView_1.Rows.Count; ++A)
            {
                
                label2 += Convert.ToInt32(dataGridView_1.Rows[A].Cells[1].Value);
                AnzahlKunden2 ++;
                
            }
            label10.Text = label2.ToString();

            AnzahlKunden2 = AnzahlKunden2-1;
            label20.Text = AnzahlKunden2.ToString();
           




        }

        private void BtnSUCHENUmsatz_2_Click_1(object sender, EventArgs e)
        {


            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
               // string cmdText = "SELECT * FROM Tabelle1 " + "WHERE Datum BETWEEN ? AND ?";
                string cmdText = " select Name,Kosten,Istgefahren,Datum from Tabelle1 where Istgefahren = 'JA'  AND ( Datum BETWEEN ? AND ?)";

                DateTime dt = this.dateTimePicker4.Value.Date;
                DateTime dt2 = this.dateTimePicker5.Value.Date.AddMinutes(1440);
                command.CommandText = cmdText;
                command.Parameters.AddWithValue("@p1", dt);
                command.Parameters.AddWithValue("@p2", dt2);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewFahrt.DataSource = ds.Tables[0];

                connection.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
            }

            // zum addieren

            int A = 0, label1 = 0, AnzahlKunden3 =0 ;
            for (A = 0; A < dataGridViewFahrt.Rows.Count; ++A)
            {
                
                label1 += Convert.ToInt32(dataGridViewFahrt.Rows[A].Cells[1].Value);
                AnzahlKunden3++;
            }
            label9.Text = label1.ToString();

            AnzahlKunden3 = AnzahlKunden3-1;
            label21.Text = AnzahlKunden3.ToString();
           



            /*
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            string cmdText = "SELECT * FROM Tabelle1 " +
                          "WHERE Datum BETWEEN ? AND ?";

            DateTime dt = this.dateTimePicker4.Value.Date;
            DateTime dt2 = this.dateTimePicker5.Value.Date.AddMinutes(1440);
            command.CommandText = cmdText;
            command.Parameters.AddWithValue("@p1", dt);
            command.Parameters.AddWithValue("@p2", dt2);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView_2.DataSource = ds.Tables[0];

            connection.Close();



            // zum addieren

            int A = 0, label3 = 0;
            for (A = 0; A < dataGridView_2.Rows.Count; ++A)
            {

                label3 += Convert.ToInt32(dataGridView_2.Rows[A].Cells[6].Value);
            }
            label4.Text = label3.ToString();
            Label3 += label3;

            */
        }

 

  

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
               // string query = " select Name,Kosten,Istgefahren from Tabelle1 ";
               // string query = " select * from Tabelle1 where Istgefahren like 'JA'  ";

                string query = " select Name,Kosten,Istgefahren,Datum from Tabelle1 where Istgefahren like 'JA' ";
               
                
                // alles anzeigen
                //string query = " select * from Tabelle1 ";

                // zeig nur
                // string query = " select Name from Tabelle1 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewFahrt.DataSource = dt;
                dataGridView_1.DataSource = dt;
                dataGridView_2.DataSource = dt;

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
            }
        }

        private void BtnLoad_Click_1(object sender, EventArgs e)
        {
            Populate();
            
            /*
            
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();

            }



                int sum = 0, A1 = 0;
                int sum2 = 0, A2 = 0;
                int sum3 = 0, A3 = 0;


                chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 1", sum3 = Convert.ToInt32(label4.Text));
                chart1.Series["BUCHUNGEN"].Points.AddXY("", A1 = Convert.ToInt32(label19.Text));


                chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 2", sum2 = Convert.ToInt32(label10.Text));
                chart1.Series["BUCHUNGEN"].Points.AddXY("", A2 = Convert.ToInt32(label20.Text));



                chart1.Series["UMSÄTZE"].Points.AddXY("Anzeige 3", sum = Convert.ToInt32(label9.Text));
                chart1.Series["BUCHUNGEN"].Points.AddXY("", A3 = Convert.ToInt32(label21.Text));
            
              */
        }

       

    }
}


