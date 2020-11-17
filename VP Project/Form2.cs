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
using Tulpep.NotificationWindow;
using System.Windows.Forms.VisualStyles;

namespace VP_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                textBox1.Enabled = false;
                textBox1.Text = "Rs " + 0;
                numericUpDown1.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox1.Text = "Rs " + (10 * numericUpDown1.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown2.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                textBox2.Enabled = false;
                textBox2.Text = "Rs " + 0;
                numericUpDown2.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox2.Text = "Rs " + (15 * numericUpDown2.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown3.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 0)
            {
                textBox3.Enabled = false;
                textBox3.Text = "Rs " + 0;
                numericUpDown3.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox3.Text = "Rs " + (20 * numericUpDown3.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown4.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 0)
            {
                textBox4.Enabled = false;
                textBox4.Text = "Rs " + 0;
                numericUpDown4.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox4.Text = "Rs " + (30 * numericUpDown4.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            numericUpDown5.Enabled = true;
            numericUpDown5.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value == 0)
            {
                textBox5.Enabled = false;
                textBox5.Text = "Rs " + 0;
                numericUpDown5.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox5.Text = "Rs " + (60 * numericUpDown5.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            numericUpDown6.Enabled = true;
            numericUpDown6.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value == 0)
            {
                textBox6.Enabled = false;
                textBox6.Text = "Rs " + 0;
                numericUpDown6.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox6.Text = "Rs " + (140 * numericUpDown6.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            numericUpDown7.Enabled = true;
            numericUpDown7.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown7.Value == 0)
            {
                textBox7.Enabled = false;
                textBox7.Text = "Rs " + 0;
                numericUpDown7.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox7.Text = "Rs " + (260 * numericUpDown7.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            numericUpDown8.Enabled = true;
            numericUpDown8.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown8.Value == 0)
            {
                textBox8.Enabled = false;
                textBox8.Text = "Rs " + 0;
                numericUpDown8.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox8.Text = "Rs " + (500 * numericUpDown8.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            numericUpDown9.Enabled = true;
            numericUpDown9.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown9.Value == 0)
            {
                textBox9.Enabled = false;
                textBox9.Text = "Rs " + 0;
                numericUpDown9.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox9.Text = "Rs " + (240 * numericUpDown9.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Enabled = true;
            numericUpDown10.Enabled = true;
            numericUpDown10.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown10.Value == 0)
            {
                textBox10.Enabled = false;
                textBox10.Text = "Rs " + 0;
                numericUpDown10.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox10.Text = "Rs " + (480 * numericUpDown10.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox11.Enabled = true;
            numericUpDown11.Enabled = true;
            numericUpDown11.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown11.Value == 0)
            {
                textBox11.Enabled = false;
                textBox11.Text = "Rs " + 0;
                numericUpDown11.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox11.Text = "Rs " + (360 * numericUpDown11.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox12.Enabled = true;
            numericUpDown12.Enabled = true;
            numericUpDown12.Value = 1;
            MessageBox.Show("This item has been saved in your order below", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown12.Value == 0)
            {
                textBox12.Enabled = false;
                textBox12.Text = "Rs " + 0;
                numericUpDown12.Enabled = false;
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
            else
            {
                textBox12.Text = "Rs " + (1000 * numericUpDown12.Value);
                decimal totalAmount = (10 * numericUpDown1.Value) + (15 * numericUpDown2.Value) + (20 * numericUpDown3.Value) + (30 * numericUpDown4.Value) + (60 * numericUpDown5.Value) + (140 * numericUpDown6.Value)
                + (260 * numericUpDown7.Value) + (500 * numericUpDown8.Value) + (240 * numericUpDown9.Value) + (480 * numericUpDown10.Value) + (360 * numericUpDown11.Value) + (1000 * numericUpDown12.Value);
                label53.Text = "Rs : " + totalAmount.ToString() + " /-";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numericUpDown4.Value = 0;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            numericUpDown6.Value = 0;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            numericUpDown7.Value = 0;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            numericUpDown8.Value = 0;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            numericUpDown9.Value = 0;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            numericUpDown10.Value = 0;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            numericUpDown11.Value = 0;
        }

        private bool mandatory()
        {
            if(numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0 && numericUpDown4.Value == 0 && numericUpDown5.Value == 0 && numericUpDown6.Value == 0
                 && numericUpDown7.Value == 0 && numericUpDown8.Value == 0 && numericUpDown9.Value == 0 && numericUpDown10.Value == 0 && numericUpDown11.Value == 0 && numericUpDown12.Value == 0)
            {
                MessageBox.Show("You didn't have ordered any item yet.\nPlease select any item first then submit your order!", "Select First", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox14.Text == string.Empty || textBox13.Text == string.Empty || textBox15.Text == string.Empty || textBox16.Text == string.Empty)
            {
                MessageBox.Show("Please provide all the information above in mandatory fields.", "Mandatory Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (mandatory())
            {
                try
                {
                    DateTime now = DateTime.Now;
                    string dateTime = now.Day + "-" + now.Month + "-" + now.Year + " " + now.Hour + ":" + now.Minute + ":" + now.Second;
                    MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO CustomerOrder(customername, phonenumber, emailid, deliveryaddress, datetimeoforder, quantity_250ml, quantity_300ml, quantity_500ml, quantity_1litre," +
                    " quantity_2litre, quantity_5litre, quantity_10litre, quantity_20litre, quantityofpack_250ml, quantityofpack_500ml, quantityofpack_1litre, quantityofpack_allsizes, totalamount)" +
                    " VALUES(@customername, @phonenumber, @emailid, @deliveryaddress, @datetimeoforder, @quantity_250ml, @quantity_300ml, @quantity_500ml, @quantity_1litre, @quantity_2litre, @quantity_5litre, @quantity_10litre," +
                    " @quantity_20litre, @quantityofpack_250ml, @quantityofpack_500ml, @quantityofpack_1litre, @quantityofpack_allsizes, @totalamount)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@customername", textBox14.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", textBox13.Text);
                    cmd.Parameters.AddWithValue("@emailid", textBox15.Text);
                    cmd.Parameters.AddWithValue("@deliveryaddress", textBox16.Text);
                    cmd.Parameters.AddWithValue("@datetimeoforder", dateTime);
                    cmd.Parameters.AddWithValue("@quantity_250ml", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@quantity_300ml", numericUpDown2.Value);
                    cmd.Parameters.AddWithValue("@quantity_500ml", numericUpDown3.Value);
                    cmd.Parameters.AddWithValue("@quantity_1litre", numericUpDown4.Value);
                    cmd.Parameters.AddWithValue("@quantity_2litre", numericUpDown5.Value);
                    cmd.Parameters.AddWithValue("@quantity_5litre", numericUpDown6.Value);
                    cmd.Parameters.AddWithValue("@quantity_10litre", numericUpDown7.Value);
                    cmd.Parameters.AddWithValue("@quantity_20litre", numericUpDown8.Value);
                    cmd.Parameters.AddWithValue("@quantityofpack_250ml", numericUpDown9.Value);
                    cmd.Parameters.AddWithValue("@quantityofpack_500ml", numericUpDown10.Value);
                    cmd.Parameters.AddWithValue("@quantityofpack_1litre", numericUpDown11.Value);
                    cmd.Parameters.AddWithValue("@quantityofpack_allsizes", numericUpDown12.Value);
                    cmd.Parameters.AddWithValue("@totalamount", label53.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.info;
                    popup.TitleText = "\nSubmitted!";
                    popup.ContentText = "\n\nYour order has been submitted successfully";
                    popup.Popup();
                    textBox1.Text = "Rs 0"; textBox1.Enabled = false;
                    textBox2.Text = "Rs 0"; textBox2.Enabled = false;
                    textBox3.Text = "Rs 0"; textBox3.Enabled = false;
                    textBox4.Text = "Rs 0"; textBox4.Enabled = false;
                    textBox5.Text = "Rs 0"; textBox5.Enabled = false;
                    textBox6.Text = "Rs 0"; textBox6.Enabled = false;
                    textBox7.Text = "Rs 0"; textBox7.Enabled = false;
                    textBox8.Text = "Rs 0"; textBox8.Enabled = false;
                    textBox9.Text = "Rs 0"; textBox9.Enabled = false;
                    textBox10.Text = "Rs 0"; textBox10.Enabled = false;
                    textBox11.Text = "Rs 0"; textBox11.Enabled = false;
                    textBox12.Text = "Rs 0"; textBox12.Enabled = false;
                    numericUpDown1.Value = 0; numericUpDown1.Enabled = false;
                    numericUpDown2.Value = 0; numericUpDown2.Enabled = false;
                    numericUpDown3.Value = 0; numericUpDown3.Enabled = false;
                    numericUpDown4.Value = 0; numericUpDown4.Enabled = false;
                    numericUpDown5.Value = 0; numericUpDown5.Enabled = false;
                    numericUpDown6.Value = 0; numericUpDown6.Enabled = false;
                    numericUpDown7.Value = 0; numericUpDown7.Enabled = false;
                    numericUpDown8.Value = 0; numericUpDown8.Enabled = false;
                    numericUpDown9.Value = 0; numericUpDown9.Enabled = false;
                    numericUpDown10.Value = 0; numericUpDown10.Enabled = false;
                    numericUpDown11.Value = 0; numericUpDown11.Enabled = false;
                    numericUpDown12.Value = 0; numericUpDown12.Enabled = false;
                    textBox13.Text = string.Empty; textBox14.Text = string.Empty;
                    textBox15.Text = string.Empty; textBox16.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Order not accepted due to:\n" + ex);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            numericUpDown12.Value = 0;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
