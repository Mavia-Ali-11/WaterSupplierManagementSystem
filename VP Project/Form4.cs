using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VP_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
         private bool Isvalid()
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty 
            || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please fulfill all the requirements for registeration", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == textBox5.Text)
            {
                if (Isvalid())
                {
                    if(label13.Text == "- as customer")
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem");
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO CustomerLogin (customername, emailid, phonenumber,passcode) VALUES(@customername, @emailid, @phonenumber, @passcode)", con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@customername", textBox1.Text);
                            cmd.Parameters.AddWithValue("@emailid", textBox2.Text);
                            cmd.Parameters.AddWithValue("@phonenumber", textBox3.Text);
                            cmd.Parameters.AddWithValue("@passcode", textBox5.Text);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Account Registered Succesfully As Client / Customer", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Registeration unsuccesfull due to " + ex);
                        }
                    }
                    else
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem");
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO EmployeeLogin (employeename, emailid, phonenumber,passcode) VALUES(@employeename, @emailid, @phonenumber, @passcode)", con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@employeename", textBox1.Text);
                            cmd.Parameters.AddWithValue("@emailid", textBox2.Text);
                            cmd.Parameters.AddWithValue("@phonenumber", textBox3.Text);
                            cmd.Parameters.AddWithValue("@passcode", textBox5.Text);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Account Registered Succesfully As Employee", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Registeration unsuccesfull due to " + ex);
                        }
                    }
                    
                }
            }
            else if (textBox4.Text != textBox5.Text)
            {
                textBox4.ForeColor = Color.Red;
                textBox5.ForeColor = Color.Red;
                MessageBox.Show("Password doesn't match in both fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.ForeColor = Color.Black;
                textBox5.ForeColor = Color.Black;
            }
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
