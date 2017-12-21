using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 FM = new Form2();
            FM.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Hide();

            /*
            string name = "";
            string pass = "";
            name = txtB_Username.Text;
            pass = passwort.Text;
            passwort.Visible = false;
           
            if ( name== "Eco" && pass=="Busmpi" ) {
                Form2 FM = new Form2();
                FM.Show();
                this.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                MessageBox.Show(" falscher Name oder Passwort ");                
            }
            */
        }
    }
}
