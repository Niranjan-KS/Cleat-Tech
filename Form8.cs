using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sports_Information
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        int pr = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "select * from football_turf";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
             
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;  
                dataGridView1.DataSource = bindingSource;
                database.close_db();
                   
            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }
        public void insertData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                var name = textBox3.Text;
                var phone = textBox1.Text;
                if (radioButton1.Checked == true)
                {
                    var court_type = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    var court_type = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    var court_type = radioButton3.Text;
                }
                if (radioButton4.Checked == true)
                {
                    var court_type = radioButton4.Text;
                }
                if (radioButton5.Checked == true)
                {
                    var court_type = radioButton5.Text;
                }
                var crt_type = radioButton1.Text;
                var daydate = dateTimePicker1.Value;
                var timing = numericUpDown4.Value;
                var price = textBox2.Text;
                string query = "INSERT INTO football_turf VALUES('"+name+"','"+phone+"','"+crt_type+"','"+daydate+"','"+timing+"','"+price+"');";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                MessageBox.Show("Turf Booked...");

                /*
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                dataGridView1.DataSource = bindingSource;
                */
                database.close_db();

            }
            else
            {
                MessageBox.Show("Database Error");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            loadData();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pr = 0;
                pr = pr + 1200;
            }
            if (radioButton2.Checked == true)
            {
                pr = 0;
                pr = pr + 1500;
            }
            if (radioButton3.Checked== true)
            {
                pr = 0;
                pr = pr + 1700;
            }
            if (radioButton4.Checked== true)
            {
                pr = 0;
                pr = pr + 2000;
            }
            if (radioButton5.Checked== true)
            {
                pr = 0;
                pr = pr + 3000;
            }
            textBox2.Text = pr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection2 = "datasource = localhost ; port = 3306 ; username = root ; database = book_turf";
                var name = textBox3.Text;
                var phone = textBox1.Text;
                if (radioButton1.Checked == true)
                {
                    var court_type = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    var court_type = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    var court_type = radioButton3.Text;
                }
                if (radioButton4.Checked == true)
                {
                    var court_type = radioButton4.Text;
                }
                if (radioButton5.Checked == true)
                {
                    var court_type = radioButton5.Text;
                }
                var crt_type = radioButton1.Text;
                var daydate = dateTimePicker1.Value;
                var timing = numericUpDown4.Value;
                var price = textBox2.Text;
                string query = "INSERT INTO football_turf VALUES('" + name + "','" + phone + "','" + crt_type + "','" + daydate + "','" + timing + "','" + price + "');";
                MySqlConnection myConn2 = new MySqlConnection(myConnection2);
                MySqlCommand myCommand2 = new MySqlCommand(query, myConn2);
                MySqlDataReader myReader2;
                myConn2.Open();
                myReader2 = myCommand2.ExecuteReader();
                MessageBox.Show("Turf Booked Successfully...");
                while (myReader2.Read())
                {

                }
                myConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 newform = new Form10();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            //Form3 anewform = new Form3();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 newform = new Form11();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            //Form3 anewform = new Form3();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            //Form3 anewform = new Form3();
            this.Close();
        }
    }
}
