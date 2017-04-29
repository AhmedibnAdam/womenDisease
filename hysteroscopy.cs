using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace womenDisease
{
    public partial class hysteroscopy : Form
    {
        Connection con = new Connection();
        public hysteroscopy()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.OpenConection();
            SqlCommand cmd = new SqlCommand("Add_", con.con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IN", textBox1.Text);
                cmd.Parameters.AddWithValue("CC", textBox2.Text);
                cmd.Parameters.AddWithValue("L", textBox3.Text);
                cmd.Parameters.AddWithValue("C", textBox4.Text);
                cmd.Parameters.AddWithValue("M", textBox5.Text);
                cmd.Parameters.AddWithValue("TO", textBox6.Text);
                cmd.Parameters.AddWithValue("SM", textBox7.Text);
                MessageBox.Show("تم بنجاح");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch
            {

            }

        }
    }
}

      
  
