using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool permission = false ;
            if (uName.Text.Trim() != string.Empty && pWord.Text.Trim() != string.Empty)
            {
                try
                {

                    login ob = new login(uName.Text, pWord.Text);
                    DBconnection ox = new DBconnection();
                    permission = ox.adminLogin(ob);


                    if (permission == true)
                    {

                        thread = new Thread(openFront);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            
        }
        private void openFront(object obj)
        {
            Application.Run(new Front());
        }

    }
}
