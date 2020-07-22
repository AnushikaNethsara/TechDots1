using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medi_Help
{
    public partial class ucViewEmployeeDetails : UserControl
    {
        private static ucViewEmployeeDetails _instance;
        public static ucViewEmployeeDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucViewEmployeeDetails();
                return _instance;
            }
        }
        public ucViewEmployeeDetails()
        {
            InitializeComponent();
        }

        private void ucViewEmployeeDetails_Load(object sender, EventArgs e)
        {
            displayEmployees();
        }

        public void displayEmployees()
        {
            DBconnection connection5 = new DBconnection();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(connection5.displayRegistredEmployees());
            da.Fill(dt);
            dataGrid.DataSource = dt;
            connection5.getConnection().Close();
        }
    }
}
