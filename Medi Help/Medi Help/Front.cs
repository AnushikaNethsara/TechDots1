using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
            DBconnection ox = new DBconnection();
            //Console.WriteLine("me me: " + global.UserID);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ob = new Admin();
            ob.ShowDialog();

        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mLTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mlt ob = new Mlt();
            ob.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cashier ob = new Cashier();
            ob.ShowDialog();
        }

        private void chemicalAndEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChemicalAndEquipment ob = new ChemicalAndEquipment();
            ob.ShowDialog();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure want to Logout?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Front_Load(object sender, EventArgs e)
        {
            log.Text = global.UserID;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
