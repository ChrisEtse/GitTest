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

//using System.Data.SqlClient;


namespace WindowsFormsAppTest
{
       

    public partial class BUCHUNGENControl : UserControl{


        OleDbConnection connection = new OleDbConnection();



        public BUCHUNGENControl()
        {
            InitializeComponent();
           

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LeRocher\Desktop\Datenbank21.accdb;
Persist Security Info=False;";

         
            
        }
       

        // FÜR UserControls
        private static BUCHUNGENControl _instance;

        public static BUCHUNGENControl Instance
        {

            get
            {
                if (_instance == null)

                    _instance = new BUCHUNGENControl();
                return _instance;

            }
        }

       

        private void btnInsert_Click(object sender, EventArgs e)
        {


            SidePanel.BackColor = Color.DodgerBlue;
            panelA.BackColor = Color.DodgerBlue;
            panelB.BackColor = Color.MidnightBlue;
            panelL.BackColor = Color.DodgerBlue;
            panelN.BackColor = Color.DodgerBlue;
            panelU.BackColor = Color.DodgerBlue;
            try{

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into Tabelle1 (AuftragID,Name,Vorname,von,bis,Bus, Kosten,Datum,Geschlecht,Istgefahren)values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox9.Text + "','" + dateTimePickerBuch.Text + "','" + geschlecht + "','" + istgefahren + "')";
            command.ExecuteNonQuery();

            
            MessageBox.Show(" Gespeichert ");
            connection.Close();

            } catch(OleDbException){

                MessageBox.Show("Buchung Daten eingeben Bitte");
                connection.Close();
            }
        }

        

        private void BUCHUNGENControl_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                // alles anzeigen
                string query = " select * from Tabelle1 ";

                // zeig nur
                //string query = " select Name from Tabelle1 ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Buchungsview.DataSource = dt;

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
            }
             * */
        }

       





        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.DodgerBlue;
            panelA.BackColor = Color.DodgerBlue;
            panelB.BackColor = Color.DodgerBlue;
            panelL.BackColor = Color.DodgerBlue;
            panelN.BackColor = Color.DodgerBlue;
            panelU.BackColor = Color.MidnightBlue;
            try
            {
             
               
  
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;            
                command.CommandText = "UPDATE Tabelle1 SET Name = @Name , Vorname = @Vorname  WHERE [AuftragID] = @AuftragID";  

                command.Parameters.AddWithValue("@Name", textBox2.Text);
                command.Parameters.AddWithValue("@Vorname", textBox3.Text);
                command.Parameters.AddWithValue("@AuftragID", int.Parse(textBox1.Text));
                command.Connection = connection;
                command.ExecuteNonQuery();
              
                connection.Close();
                MessageBox.Show(" actualisiert ");
                

            }
            catch (FormatException)
            {

                MessageBox.Show(" zuerst AuftragID eingeben bitte");

                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.DodgerBlue;
            panelA.BackColor = Color.DodgerBlue;
            panelB.BackColor = Color.DodgerBlue;
            panelL.BackColor = Color.MidnightBlue;
            panelN.BackColor = Color.DodgerBlue;
            panelU.BackColor = Color.DodgerBlue;


           // DialogResult confirm = MessageBox.Show("Wirklich löschen ?", "Exit", MessageBoxButtons.YesNo);
           



                try
                {
                    DialogResult confirm = MessageBox.Show("Wirklich löschen ?", "Exit", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        string query = "delete from Tabelle1 where AuftragID=" + textBox1.Text + "";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        MessageBox.Show(" gelöscht ");
                        connection.Close();
                    }
                    else if (confirm == DialogResult.No)
                    {

                    }
                }

                catch (OleDbException)
                {

                    MessageBox.Show(" AuftragID eingeben");
                    connection.Close();
                }
            }

           
        
        private void btnAnzeige_Click(object sender, EventArgs e)
        {
           
            SidePanel.BackColor = Color.MidnightBlue;
            panelA.BackColor = Color.DodgerBlue;
            panelB.BackColor = Color.DodgerBlue;
            panelL.BackColor = Color.DodgerBlue;
            panelN.BackColor = Color.DodgerBlue;
            panelU.BackColor = Color.DodgerBlue;
            
            try
            {
                
               

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                // alles anzeigen
                string query = " select * from Tabelle1 ";

                // zeig nur
                //string query = " select Name from Tabelle1 ";

                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Buchungsview.DataSource = dt;
             
                connection.Close();
           

            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error" + ex);
                connection.Close();
                
            }
        }
     
       

        private void btnDateUmsatz_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.DodgerBlue;
            panelA.BackColor = Color.DodgerBlue;
            panelB.BackColor = Color.DodgerBlue;
            panelL.BackColor = Color.DodgerBlue;
            panelN.BackColor = Color.MidnightBlue;
            panelU.BackColor = Color.DodgerBlue;
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
           // string cmdText = "SELECT * FROM Tabelle1 " + "WHERE Datum BETWEEN ? AND ?";
            string cmdText = " select  AuftragID,Name,von,bis,Bus,Kosten,Istgefahren,Datum from Tabelle1 where Istgefahren = 'JA'  AND ( Datum BETWEEN ? AND ?)";

            DateTime dt = this.dateBuch1.Value.Date;
            DateTime dt2 = this.dateBuch2.Value.Date.AddMinutes(1440);
            command.CommandText = cmdText;
            command.Parameters.AddWithValue("@p1", dt);
            command.Parameters.AddWithValue("@p2", dt2);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Buchungsview.DataSource = ds.Tables[0];

            connection.Close();
        }

        private void btnSuchID_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.DodgerBlue;
            panelA.BackColor = Color.MidnightBlue;
            panelB.BackColor = Color.DodgerBlue;
            panelL.BackColor = Color.DodgerBlue;
            panelN.BackColor = Color.DodgerBlue;
            panelU.BackColor = Color.DodgerBlue;
            try
            {
                // string query = " select *from Tabelle1 where AuftragID =" + textBox1.Text + "";



                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string query = " select *from Tabelle1 where AuftragID =" + textBox1.Text + "";
               
                

                command.CommandText = query;
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Buchungsview.DataSource = dt;
                connection.Close();


            }
            catch (OleDbException) {
                MessageBox.Show("AuftragNr nicht gefunden \n  Bitte geben Sie eine gültige AuftragNr ein " );
                connection.Close();
            } 
          
        
            
        }

        string geschlecht;     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            geschlecht = " Weiblich";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            geschlecht = " Männlich";
        }

        string istgefahren;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            istgefahren = "JA";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            istgefahren = "NEIN";
        }
   
    }
}
