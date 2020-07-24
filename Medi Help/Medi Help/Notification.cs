using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }


        public void Alert(string msg)
        {
            Alert frm = new Alert();
            frm.showAlert(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Alert ob = new Alert();
            
            
            if (type.Text.Equals("Breakdown"))
            {
                ob.BackColor = Color.Red;
            }
            else if (type.Text.Equals("Message"))
            {
                ob.BackColor = Color.SeaGreen;
            }
            this.Alert(notifi.Text);
            this.Alert(notifi.Text);
        }
    }
}
