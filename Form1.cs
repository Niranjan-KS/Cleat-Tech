using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        public static class Dlg1
        {
            public static string ShowDialog(string text, string caption)
            {
                Form dlg1 = new Form()
                {
                    Width = 500,
                    Height = 500,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabelDialog = new Label()
                {
                    Left = 50,
                    Top = 20,
                    Text = text
                };

                /*
                TextBox textBoxDialog = new TextBox()
                {
                    Left = 50,
                    Top = 20,
                    Width = 400,
                };
                */

                Button confirmation = new Button() { Text = "OK", Left = 350, Top = 70, Width = 100, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { dlg1.Close(); };

                //dlg1.Controls.Add(textBoxDialog);

                dlg1.Controls.Add(confirmation);
                dlg1.Controls.Add(textLabelDialog);
                dlg1.AcceptButton = confirmation;
                return dlg1.ShowDialog() == DialogResult.OK ? textLabelDialog.Text : "";

            }
        }
        string[] id = new string[10];
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter your register number...");
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter your name...");
                return;

            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please enter your department...");
                return;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please enter your course name...");
                return;

            }
            string email = textBox6.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Invalid E-Mail!");
            }

            string newItem = textBox1.Text;
            for(int i=0; i < 10; i++)
            {
                id[i] = newItem;
            }

            MessageBox.Show("SUCCESSFULLY REGISTERED...");
            //string dlg1Value = Dlg1.ShowDialog("REGISTERED", "123");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;


            if (checkBox1.Checked == true) 
            {
                total = total + 1500;
            }
            if (checkBox2.Checked == true)
            {
                total = total + 1000;
            }
            if (checkBox3.Checked == true)
            {
                total = total + 500;
            }
            if (checkBox4.Checked == true)
            {
                total = total + 400;
            }
            textBox5.Text = total.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("http://www.christuniversity.in");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < id.Length; i++)
            {
                richTextBox2.Text = id[i];
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
