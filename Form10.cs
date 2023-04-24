using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_Information
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;database=book_turf";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
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

                string Query = "update football_turf set Name='" + name + "', Phone='" + phone + "',Court_type='" + crt_type + "',Date='" + daydate + "',Start_time='" + timing + "',Price='" + price + "' where Name='" + this.textBox5.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int pr = 0;

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
            if (radioButton3.Checked == true)
            {
                pr = 0;
                pr = pr + 1700;
            }
            if (radioButton4.Checked == true)
            {
                pr = 0;
                pr = pr + 2000;
            }
            if (radioButton5.Checked == true)
            {
                pr = 0;
                pr = pr + 3000;
            }
            textBox2.Text = pr.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 newform = new Form8();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 newform = new Form11();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
