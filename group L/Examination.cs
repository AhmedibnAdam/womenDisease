using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace womenDisease
{
    public partial class Examination_ultrasound_group_L : Form
    {
        public Examination_ultrasound_group_L()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
                groupBox2.Visible = true;
            else
                groupBox2.Visible = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
                groupBox4.Visible = true;
            else
                groupBox4.Visible = false;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
                groupBox5.Visible = true;
            else
                groupBox5.Visible = false;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
                groupBox6.Visible = true;
            else
                groupBox6.Visible = false;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
                groupBox7.Visible = true;
            else
                groupBox7.Visible = false;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Examination_ultrasound_group_L_Load(object sender, EventArgs e)
        {

        }
    }
}
