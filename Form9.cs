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
    public partial class Form9 : Form
    {
        int c = 0;
        public Form9()
        {
            InitializeComponent();
        }

        bool check_win()
        {

            if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") || (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") || (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))
            { return true; }
            else if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") || (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") || (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))
            { return true; }
            else if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") || (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            { return true; }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                refresh();
                MessageBox.Show("Draw");
                c--;
                return false;
            }
            else
            { return false; }
        }
        void refresh()
        {
            c = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void button10_Click(object sender, EventArgs e)
        {

            refresh();


        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button9.Text = "X";
            }
            else
                button9.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button1.Text = "X";
            }
            else
                button1.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button2.Text = "X";
            }
            else
                button2.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button3.Text = "X";
            }
            else
                button3.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button4.Text = "X";
            }
            else
                button4.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button5.Text = "X";
            }
            else
                button5.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button6.Text = "X";
            }
            else
                button6.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button7.Text = "X";
            }
            else
                button7.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
            {
                button8.Text = "X";
            }
            else
                button8.Text = "O";
            if (check_win())
            {
                if (c % 2 == 0)
                    MessageBox.Show("Player 1 wins");
                else
                    MessageBox.Show("Player 2 wins");
                refresh();
            }
            c++;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newform = new Form5();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
