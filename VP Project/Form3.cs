using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySqlX.XDevAPI.Common;

namespace VP_Project
{
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection(@"server=localhost;userid=root;password=mavyaali@795;database=managementsystem");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            getRecords();
            panel1.Select();
        }

        public void getRecords()
        {
            MySqlConnection connection = new MySqlConnection(@"server=localhost;userid=root;password=mavyaali@795;database=managementsystem");
            MySqlCommand cmd1 = new MySqlCommand("SELECT CustomerId, CustomerName, EmailId, PhoneNumber FROM CustomerLogin", connection);
            DataTable dataTable1 = new DataTable();
            connection.Open();
            MySqlDataReader sdr1 = cmd1.ExecuteReader();
            dataTable1.Load(sdr1);
            connection.Close();
            dataGridView1.DataSource = dataTable1;

            MySqlCommand cmd2 = new MySqlCommand("SELECT EmployeeId, Employeename, EmailId, PhoneNumber FROM EmployeeLogin", connection);
            DataTable dataTable2 = new DataTable();
            connection.Open();
            MySqlDataReader sdr2 = cmd2.ExecuteReader();
            dataTable2.Load(sdr2);
            connection.Close();
            dataGridView2.DataSource = dataTable2;

            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM CustomerOrder;", connection);
            DataTable dataTable3 = new DataTable();
            connection.Open();
            MySqlDataReader sdr3 = cmd3.ExecuteReader();
            dataTable3.Load(sdr3);
            connection.Close();
            dataGridView3.DataSource = dataTable3;

            label16.Text = dataGridView1.Rows.Count.ToString();
            label18.Text = dataGridView2.Rows.Count.ToString();
            label20.Text = dataGridView3.Rows.Count.ToString();

            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); 
            f4.label13.Text = "- as customer";
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete the registeration of this customer ?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int CustomerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM CustomerLogin WHERE CustomerId = @CustomerId", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    getRecords();
                    MessageBox.Show("Registeration of (Customer Id: " + CustomerId + ") has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please, Select row record first to delete.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.label13.Text = "- as employee";
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete the registeration of this employee ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int EmployeeId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM EmployeeLogin WHERE EmployeeId = @EmployeeId", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    getRecords();
                    MessageBox.Show("Registeration of (Employee Id: " + EmployeeId + ") has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int totalRows2 = dataGridView2.Rows.Count;
                    label18.Text = totalRows2.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please, Select row record first to delete.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this order ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int OrderId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM CustomerOrder WHERE OrderId = @OrderId", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@OrderId", OrderId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    getRecords();
                    MessageBox.Show("Order with (Order Id: " + OrderId + ") has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please, Select row record first to delete.", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getRecords();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                e.Cancel = true;
                panel1.Select();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
