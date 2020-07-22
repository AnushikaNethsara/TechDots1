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
using System.Windows.Forms.VisualStyles;

namespace Medi_Help
{
    public partial class ucUser : UserControl
    {
        private bool otherField=false;
        private static ucUser _instance;
        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUser();
                return _instance;
            }
        }
        public ucUser()
        {
            InitializeComponent();
            clearFileds();
        }

        private void User_Load(object sender, EventArgs e)
        {
            other.ReadOnly = true;
            userName.ReadOnly = true;
            password.ReadOnly = true;
            cPassword.ReadOnly = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void empType_SelectedValueChanged(object sender, EventArgs e)
        {
            string employeeType = empType.Text;
            if (employeeType == "Other")
            {
                other.ReadOnly = false;
                otherField = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {

            if (user.Checked)
            {
                userName.ReadOnly = false;
                cPassword.ReadOnly = false;
                password.ReadOnly = false;
            }
            else
            {
                userName.ReadOnly = true;
                cPassword.ReadOnly = true;
                password.ReadOnly = true;
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void other_TextChanged(object sender, EventArgs e)
        {

        }

        private void empType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter");
        }

        private void register_Click(object sender, EventArgs e)
        {
            DBconnection ui = new DBconnection();
            string type = empType.Text;

            if (name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Name Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nic.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty NIC Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dob.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty DOB Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (email.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Email Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (empType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Designation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //!type.Equals("MLT") || !type.Equals("Cashier") || !type.Equals("Admin") || !type.Equals("Other")
            else if (empType.Text.Trim() != string.Empty)
            {
                if (type.Equals("MLT"))
                {
                    
                }
                else if (type.Equals("Casheir"))
                {
                   
                }
                else if (type.Equals("Admin"))
                {
                   
                }
                else if (type.Equals("Other") )
                {
                    if(other.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Empty Other Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter valid Designation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            }
            else if (phone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Phone Number Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                return;
            }

            //else if (otherField && other.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Empty Other Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (user.Checked)
            {
                if (userName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Empty UserName Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (password.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Empty Password Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Empty Confirm Password Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (password.Text != cPassword.Text)
                {
                    MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ui.checkUserName(userName.Text))
                {
                    MessageBox.Show("Username Already Taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            DialogResult answer;
            answer = MessageBox.Show("Are you sure want to add Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //*************database**********************
            if (answer == DialogResult.Yes)
            {
                 
                try
                {
                    string Enic = "E" + nic.Text;
                    string Ename = name.Text;
                    string date = dob.Value.ToShortDateString();
                    string Eemail = email.Text;
                    int Ephone = Convert.ToInt32(phone.Text);
                    string eType = empType.Text;
                    string Eusername = userName.Text;
                    string Epassword = password.Text;
                    employee ox = new employee(Enic,Ename,date,Eemail,Ephone,eType,Eusername,Epassword);
                    
                    ui.addEmployees(ox);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("erro: \n" + ex);
                    Console.WriteLine("erro: \n"+ex);
                }


                clearFileds();
            }

        }
        private void clearFileds()
        {
            name.Text = "";
            nic.Text = "";
            email.Text = "";
            dob.Value = DateTime.Today;
            phone.Text = "";
            empType.Text = "";
            other.Text = "";
            if (user.Checked)
            {
                userName.Text = "";
                password.Text = "";
                cPassword.Text = "";
                user.Checked = false;
                empType.SelectedIndex = -1;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFileds();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
