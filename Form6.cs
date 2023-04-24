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

namespace Sports_Information
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Invalid E-Mail!");
            }

            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            string pword = textBox3.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;database=cleat_tech";
                //Display query
                string Query = "select mail from sign_up;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                for (int i=0; i<dTable.Rows.Count; i++)
                {

                }

                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                /*
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                */
                // here i have assign dTable object to the dataGridView1 object to display data.
                //MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (match.Success && pword != null && pword.Length >= 8)
            {

                Form5 newform = new Form5();
                this.Hide();
                newform.ShowDialog();
                this.Show();
                this.Close();

            }
            else if (match.Success == false) 
            {
                MessageBox.Show("Invalid E-Mail!");
            }
            else if (pword == null)
            {
                MessageBox.Show("Enter Password...");
            }
            else if (pword.Length < 8)
            {
                MessageBox.Show("Invalid Password...");
            }


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 newform = new Form3();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }
    }
}
