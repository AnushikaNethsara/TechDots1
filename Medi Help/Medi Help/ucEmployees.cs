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
    public partial class ucEmployees : UserControl
    {
        private static ucEmployees _instance;
        public static ucEmployees Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEmployees();
                return _instance;
            }
        }
        public ucEmployees()
        {
            InitializeComponent();
        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
