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


        public static void Alert(string msg)
        {
            Alert frm = new Alert();
            frm.showAlert(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetTimer();
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
    }
}
