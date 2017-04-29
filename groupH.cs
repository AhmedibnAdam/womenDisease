using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace womenDisease
{
    public partial class groupH : Form
    {
        public groupH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void childbearingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
        }

        private void perimenopausalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void postmenopausalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox5.Show();
        }

        private void amenorrheaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

       

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox4.Visible = true;

            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
