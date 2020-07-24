using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace Medi_Help
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }


        public static void AlertSend(string msg, Alert.enmType type)
        {
            Alert frm = new Alert();
            frm.showAlert(msg,type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(notifi.Text.Trim() != string.Empty && nType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selected = this.nType.GetItemText(this.nType.SelectedItem);
                if (selected.Equals("Success Alert"))
                {
                    AlertSend("Success Alert", Alert.enmType.Success);
                }
                else if (selected.Equals("Warning Alert"))
                {
                    AlertSend("Warning Alert", Alert.enmType.Warning);
                }
                else if (selected.Equals("Error Alert"))
                {
                    AlertSend("Error Alert", Alert.enmType.Error);
                }
                else if (selected.Equals("Info Alert"))
                {
                    AlertSend("Info Alert", Alert.enmType.Info);
                }
                else
                {
                    MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        //timer
        private static System.Timers.Timer aTimer;
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(5000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Alert ob = new Alert();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlertSend("Info Alert", Alert.enmType.Info);
        }
    }
}
