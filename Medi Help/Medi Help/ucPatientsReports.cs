﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Medi_Help
{
    public partial class ucPatientsReports : UserControl
    {
        private static ucPatientsReports _instance;
        public static ucPatientsReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPatientsReports();
                return _instance;
            }
        }
        public ucPatientsReports()
        {
            InitializeComponent();
        }

        private void ucPatientsReports_Load(object sender, EventArgs e)
        {
            PatientReports();
        }
        public void PatientReports()
        {

            //string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",CultureInfo.InvariantCulture)+ primaryKey.RandomString(5);
            //MessageBox.Show("time: " + timestamp);
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayAllPatientsReports());
                da.Fill(dt);
                dataGrid.DataSource = dt;
                connection5.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Displaying: \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error:\n" + ex);
            }
        }
    }
}
