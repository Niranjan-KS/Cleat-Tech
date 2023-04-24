using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Sports_Information
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Form5 newform = new Form5();
                this.Hide();
                newform.ShowDialog();
                this.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid E-Mail!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 newform = new Form6();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();  

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            string pword = textBox2.Text;
            string pwordc = textBox4.Text;
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success && pword == pwordc && pword != null && pword.Length >= 8 && checkBox1.Checked) 
            {
                try
                {
                    string myConnection2 = "datasource = localhost ; port = 3306 ; username = root ; database = cleat_tech";
                    var mail = textBox3.Text;
                    var passwd = textBox2.Text;
                    var confirmpw = textBox4.Text;
                    string query = "INSERT INTO sign_up (mail, passwd, confirm_passwd) VALUES('" + mail + "','" + passwd + "','" + confirmpw + "');";
                    MySqlConnection myConn2 = new MySqlConnection(myConnection2);
                    MySqlCommand myCommand2 = new MySqlCommand(query, myConn2);
                    MySqlDataReader myReader2;
                    myConn2.Open();
                    myReader2 = myCommand2.ExecuteReader();
                    MessageBox.Show("User Registered...");
                    while (myReader2.Read())
                    {

                    }
                    myConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Form5 newform = new Form5();
                this.Hide();
                newform.ShowDialog();
                this.Show();
                this.Close();

            }
            else if (match.Success==false)
            {
                MessageBox.Show("Invalid E-Mail!");
            }
            else if (pword == null)
            {
                MessageBox.Show("Password cannot be empty!");
            }
            else if (pword.Length < 8)
            {
                MessageBox.Show("Password should be greater than 8 characters...");
            }
            else if (pword != pwordc)
            {
                MessageBox.Show("Enter the same password to confirm!");
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Please read the terms and privacy policy...");
            }
            else
            {
                MessageBox.Show("!!!SORRY!!!\nSERVER ERROR... \nPLEASE COME BACK LATER...");
            }



        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 newform = new Form6();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            //Form3 anewform = new Form3();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form8 newform = new Form8();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            //Form3 anewform = new Form3();
            this.Close();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }
    }
}
