namespace WindowsFormsAppTest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMENU = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pa_Men_Hide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_USERS = new System.Windows.Forms.Panel();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUMSATZ = new System.Windows.Forms.Button();
            this.btnBUCHUNGEN = new System.Windows.Forms.Button();
            this.btnFAHRTEN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_USERS.SuspendLayout();
            this.panelMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnMENU);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 148);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(120, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 146);
            this.panel4.TabIndex = 29;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1082, 46);
            this.progressBar1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(475, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 95);
            this.label3.TabIndex = 29;
            this.label3.Text = "EcoBUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 95);
            this.label2.TabIndex = 28;
            this.label2.Text = "EcoBUS";
            // 
            // btnMENU
            // 
            this.btnMENU.BackColor = System.Drawing.Color.Black;
            this.btnMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMENU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMENU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMENU.Location = new System.Drawing.Point(0, 0);
            this.btnMENU.Name = "btnMENU";
            this.btnMENU.Size = new System.Drawing.Size(120, 148);
            this.btnMENU.TabIndex = 0;
            this.btnMENU.Text = "_______\r\n_______\r\n_______\r\n\r\nMENÜ";
            this.btnMENU.UseVisualStyleBackColor = false;
            this.btnMENU.Click += new System.EventHandler(this.BtnMENU_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1202, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 148);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pa_Men_Hide
            // 
            this.pa_Men_Hide.BackColor = System.Drawing.Color.Black;
            this.pa_Men_Hide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa_Men_Hide.Location = new System.Drawing.Point(0, 148);
            this.pa_Men_Hide.Name = "pa_Men_Hide";
            this.pa_Men_Hide.Size = new System.Drawing.Size(23, 569);
            this.pa_Men_Hide.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(23, 682);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 35);
            this.panel2.TabIndex = 2;
            // 
            // panel_USERS
            // 
            this.panel_USERS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_USERS.Controls.Add(this.panelMENU);
            this.panel_USERS.Controls.Add(this.panel3);
            this.panel_USERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_USERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_USERS.Location = new System.Drawing.Point(23, 148);
            this.panel_USERS.Name = "panel_USERS";
            this.panel_USERS.Size = new System.Drawing.Size(1279, 534);
            this.panel_USERS.TabIndex = 3;
            this.panel_USERS.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_USERS_Paint);
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.White;
            this.panelMENU.Controls.Add(this.label1);
            this.panelMENU.Controls.Add(this.button5);
            this.panelMENU.Controls.Add(this.button4);
            this.panelMENU.Controls.Add(this.button3);
            this.panelMENU.Controls.Add(this.btnUMSATZ);
            this.panelMENU.Controls.Add(this.btnBUCHUNGEN);
            this.panelMENU.Controls.Add(this.btnFAHRTEN);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(0, 0);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(474, 534);
            this.panelMENU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "___________________________";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 281);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(201, 94);
            this.button5.TabIndex = 12;
            this.button5.Text = "Leer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 281);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 94);
            this.button4.TabIndex = 11;
            this.button4.Text = "Leer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 94);
            this.button3.TabIndex = 10;
            this.button3.Text = "FAHRTEN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnUMSATZ
            // 
            this.btnUMSATZ.BackColor = System.Drawing.Color.Cyan;
            this.btnUMSATZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMSATZ.Location = new System.Drawing.Point(229, 169);
            this.btnUMSATZ.Margin = new System.Windows.Forms.Padding(4);
            this.btnUMSATZ.Name = "btnUMSATZ";
            this.btnUMSATZ.Size = new System.Drawing.Size(201, 94);
            this.btnUMSATZ.TabIndex = 9;
            this.btnUMSATZ.Text = "  GRAPH \r\nANALYSE ";
            this.btnUMSATZ.UseVisualStyleBackColor = false;
            this.btnUMSATZ.Click += new System.EventHandler(this.BtnUMSATZ_Click);
            // 
            // btnBUCHUNGEN
            // 
            this.btnBUCHUNGEN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBUCHUNGEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUCHUNGEN.Location = new System.Drawing.Point(229, 23);
            this.btnBUCHUNGEN.Margin = new System.Windows.Forms.Padding(4);
            this.btnBUCHUNGEN.Name = "btnBUCHUNGEN";
            this.btnBUCHUNGEN.Size = new System.Drawing.Size(201, 94);
            this.btnBUCHUNGEN.TabIndex = 8;
            this.btnBUCHUNGEN.Text = "AUFTRÄGE";
            this.btnBUCHUNGEN.UseVisualStyleBackColor = false;
            this.btnBUCHUNGEN.Click += new System.EventHandler(this.BtnBUCHUNGEN_Click);
            // 
            // btnFAHRTEN
            // 
            this.btnFAHRTEN.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnFAHRTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFAHRTEN.Location = new System.Drawing.Point(4, 23);
            this.btnFAHRTEN.Margin = new System.Windows.Forms.Padding(4);
            this.btnFAHRTEN.Name = "btnFAHRTEN";
            this.btnFAHRTEN.Size = new System.Drawing.Size(193, 94);
            this.btnFAHRTEN.TabIndex = 7;
            this.btnFAHRTEN.Text = "UMSÄTZE";
            this.btnFAHRTEN.UseVisualStyleBackColor = false;
            this.btnFAHRTEN.Click += new System.EventHandler(this.BtnFAHRTEN_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1254, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 534);
            this.panel3.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 717);
            this.Controls.Add(this.panel_USERS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pa_Men_Hide);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_USERS.ResumeLayout(false);
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pa_Men_Hide;
        private System.Windows.Forms.Button btnMENU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_USERS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUMSATZ;
        private System.Windows.Forms.Button btnBUCHUNGEN;
        private System.Windows.Forms.Button btnFAHRTEN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}