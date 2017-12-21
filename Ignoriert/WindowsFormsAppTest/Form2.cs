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
    public partial class Form2 : Form
    {


        int PW;
        bool Hided;

        public Form2()
        {
           


            InitializeComponent();
            PW = panelMENU.Width;
            this.WindowState = FormWindowState.Maximized;
            Hided = true;
            timer1.Start();

        }

        private void BtnMENU_Click(object sender, EventArgs e)
        {
          

            if (Hided) { btnMENU.Text = "Z\nU\nR\nÜ\nC\nK"; }

            else btnMENU.Text = " \n_______\n_______\n_______\n\n MENÜ ";
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (Hided)
            {

                panelMENU.Width = panelMENU.Width + 20;
                if (panelMENU.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }

            }
            else
            {

                panelMENU.Width = panelMENU.Width - 20;

                if (panelMENU.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }

        }

        private void BtnFAHRTEN_Click(object sender, EventArgs e)
        {
            if (!panel_USERS.Controls.Contains(UMSATZControl.Instance))
            {

                panel_USERS.Controls.Add(UMSATZControl.Instance);
                UMSATZControl.Instance.Dock = DockStyle.Fill;
                UMSATZControl.Instance.BringToFront();

            }
            else
                UMSATZControl.Instance.BringToFront();
            timer1.Start();
            btnMENU.Text = " \n_______\n_______\n_______\n MENÜ ";
        }

        private void BtnBUCHUNGEN_Click(object sender, EventArgs e)
        {
            if (!panel_USERS.Controls.Contains(BUCHUNGENControl.Instance))
            {

                panel_USERS.Controls.Add(BUCHUNGENControl.Instance);
                BUCHUNGENControl.Instance.Dock = DockStyle.Fill;
                BUCHUNGENControl.Instance.BringToFront();

            }
            else
                BUCHUNGENControl.Instance.BringToFront();
            timer1.Start();
            btnMENU.Text = " \n_______\n_______\n_______\n MENÜ ";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Wirklich schließen ?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirm == DialogResult.No)
            {

                Form2 F2 = new Form2();
                F2.Show();
                F2.WindowState = FormWindowState.Maximized;

                
            }
        }

        private void BtnUMSATZ_Click(object sender, EventArgs e)
        {
            if (!panel_USERS.Controls.Contains(GraphControl1.Instance))
            {

                panel_USERS.Controls.Add(GraphControl1.Instance);
                GraphControl1.Instance.Dock = DockStyle.Fill;
                GraphControl1.Instance.BringToFront();

            }
            else
                GraphControl1.Instance.BringToFront();
            timer1.Start();
            btnMENU.Text = " \n_______\n_______\n_______\n MENÜ ";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!panel_USERS.Controls.Contains(FAHRTENControl1.Instance))
            {

                panel_USERS.Controls.Add(FAHRTENControl1.Instance);
                FAHRTENControl1.Instance.Dock = DockStyle.Fill;
                FAHRTENControl1.Instance.BringToFront();

            }
            else
                GraphControl1.Instance.BringToFront();
            timer1.Start();
            btnMENU.Text = " \n_______\n_______\n_______\n MENÜ ";

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         

            if(label2.Left < this.Width)
            {
                label2.Left = label2.Left + 3;

            } else
            {
                label2.Left = 0;
            }

            if (label3.Left < this.Width)
            {
                label3.Left = label3.Left + 3;

            }
            else
            {
                label3.Left = 0;
            }


            Random rand = new Random();
            int A = rand.Next(0, 255); 
            int R = rand.Next(0, 255); 
            int G = rand.Next(0, 255); 
            int B = rand.Next(0, 255);
            //progressBar1.BackColor = Color.FromArgb(A, R, G, B);

        }

        private void panel_USERS_Paint(object sender, PaintEventArgs e)
        {

        }








        //  btnFAHRTEN.BackColor = Color.White;



    }
}
