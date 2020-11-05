using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Form3 : Form
    {
        private Form1 mainForm1 = null;
        private Form4 mainForm4 = null;
        public Form3(Form callingForm1, Form callingForm4)
        {
            mainForm1 = callingForm1 as Form1;
            mainForm4 = callingForm4 as Form4;
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (this.mainForm1.radioButton1.Checked == true)
            {
                button1.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
