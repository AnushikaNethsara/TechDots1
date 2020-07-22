using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class ucUrineRatio : UserControl
    {
        private static ucUrineRatio _instance;
        public static ucUrineRatio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUrineRatio();
                return _instance;
            }
        }
        public ucUrineRatio()
        {
            InitializeComponent();
        }

        private void ucUrineRatio_Load(object sender, EventArgs e)
        {

        }
    }
}
