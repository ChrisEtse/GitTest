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
    public partial class FAHRTENControl1 : UserControl
    {

        private static FAHRTENControl1 _instance;
        public static FAHRTENControl1 Instance
        {

            get
            {
                if (_instance == null)

                    _instance = new FAHRTENControl1();
                return _instance;

            }
        }


        public FAHRTENControl1()
        {
            InitializeComponent();
        }
    }
}
