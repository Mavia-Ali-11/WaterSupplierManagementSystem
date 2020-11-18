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
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace VP_Project
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Choices words = new Choices();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guide();
            voiceRecognition();
        }

        public void guide()
        {
            synthesizer.Volume = 100;
            synthesizer.SelectVoiceByHints(VoiceGender.Female);
            synthesizer.Speak("Welcome, select login type of your account");
        }

        public void voiceRecognition()
        {
            words.Add(new string[] { "admin", "employee", "client", "customer", "registeraccount", "exit" });
            Grammar grammer = new Grammar(new GrammarBuilder(words));
            try
            {
                recognizer.RequestRecognizerUpdate();
                recognizer.LoadGrammar(grammer);
                recognizer.SpeechRecognized += sre_speechRecognized;
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while detecting your voice due to " + ex.Message);
            }
        }

        public void sre_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit word in e.Result.Words)
            {
                if (word.Text ==  "admin") {
                    radioButton1.Checked = true;
                }

                else if (word.Text == "employee")
                {
                    radioButton2.Checked = true;
                }

                else if (word.Text == "client" || word.Text == "customer")
                {
                    radioButton3.Checked = true;
                }

                else if (word.Text == "registeraccount")
                {
                    this.linkLabel1_LinkClicked(sender,null);
                }

                else if (word.Text == "exit")
                {
                    button2.PerformClick();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Admin Login";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Employee Login";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Customer Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            if (radioButton1.Checked == true)
            {
                string conString = "server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem";
                string loginQuery = "SELECT * FROM AdminLogin WHERE Adminname='" + textBox1.Text + "' and Passcode='" + textBox2.Text + "'";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(loginQuery, con);
                MySqlDataReader reader;
                int count = 0;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count >= 1)
                    {
                        this.Hide();
                        f3.button1.Visible = true;
                        f3.button2.Visible = true;
                        f3.button3.Visible = true;
                        f3.button4.Visible = true;
                        f3.label2.Text = "Admin View";
                        f3.label10.Text = textBox1.Text;
                        f3.Show();
                    }
                    else
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;
                        MessageBox.Show("Invalid admin name or password", "Invalid details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.ForeColor = Color.Black;
                        textBox2.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get Value due to " + ex);
                }
            }
            else if (radioButton2.Checked == true)
            {
                string conString = "server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem";
                string loginQuery = "SELECT * FROM EmployeeLogin WHERE Employeename='" + textBox1.Text + "' and Passcode='" + textBox2.Text + "'";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(loginQuery, con);
                MySqlDataReader reader;
                int count = 0;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count >= 1)
                    {
                        this.Hide();
                        f3.label10.Text = textBox1.Text;
                        f3.label2.Text = "Employee View";
                        f3.Show();
                    }
                    else
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;
                        MessageBox.Show("Invalid employee name or password\nDon't have an account ? Register account first!", "Invalid details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.ForeColor = Color.Black;
                        textBox2.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get Value due to " + ex);
                }
            }
            else if (radioButton3.Checked == true)
            {
                string conString = "server=localhost;userid=root;password=mavyaali@795;database=ManagementSystem";
                string loginQuery = "SELECT * FROM CustomerLogin WHERE CustomerName='" + textBox1.Text + "' and Passcode='" + textBox2.Text + "'";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(loginQuery, con);
                MySqlDataReader reader;
                int count = 0;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count >= 1)
                    {
                        this.Hide();
                        f2.label66.Text = textBox1.Text;
                        f2.textBox14.Text = textBox1.Text;
                        f2.Show();
                    }
                    else
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;
                        MessageBox.Show("Invalid username or password\nDon't have an account ? Register account first!", "Invalid details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.ForeColor = Color.Black;
                        textBox2.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get Value due to " + ex);
                }
            }
            else
            {
                MessageBox.Show("Please, select login type first", "Select login type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
