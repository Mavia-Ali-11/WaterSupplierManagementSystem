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
            dataGridView1.MultiSelect = false;
            dataGridView2.MultiSelect = false;
            dataGridView3.MultiSelect = false;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void getRecords()
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); 
            f4.label13.Text = "- as customer";
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.label13.Text = "- as employee";
            f4.Show();
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

        
    }
}
