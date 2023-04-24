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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 newform = new Form7();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 newform = new Form9();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form9 newform = new Form9();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                panel1.Font = fontDialog1.Font;
                button1.Font = fontDialog1.Font;
                button2.Font = fontDialog1.Font;
                statusStrip1.Font = fontDialog1.Font;
                button4.Font = fontDialog1.Font;
                button5.Font = fontDialog1.Font;
                toolStrip1.Font = fontDialog1.Font;
            }
        }

        private void toolStripSplitButton7_ButtonClick(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newform = new Form6();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 newform = new Form7();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 newform = new Form8();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
