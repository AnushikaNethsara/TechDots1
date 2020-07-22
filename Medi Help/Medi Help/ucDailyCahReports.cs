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
    public partial class ucDailyCahReports : UserControl
    {
        private static ucDailyCahReports _instance;
        public static ucDailyCahReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDailyCahReports();
                return _instance;
            }
        }
        public ucDailyCahReports()
        {
            InitializeComponent();
        }

        private void ucDailyCahReports_Load(object sender, EventArgs e)
        {

        }
    }
}
