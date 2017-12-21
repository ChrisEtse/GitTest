using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class GraphControl1 : UserControl
    {

        private static GraphControl1 _instance;
        public static GraphControl1 Instance
        {

            get
            {
                if (_instance == null)

                    _instance = new GraphControl1();
                return _instance;

            }
        }


        public GraphControl1()
        {
            InitializeComponent();
        }
    }
}
