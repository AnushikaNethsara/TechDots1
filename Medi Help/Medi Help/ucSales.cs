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
    public partial class ucSales : UserControl
    {
        private static ucSales _instance;
        public static ucSales Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSales();
                return _instance;
            }
        }
        public ucSales()
        {
            InitializeComponent();
        }

        private void ucSales_Load(object sender, EventArgs e)
        {

        }
    }
}
