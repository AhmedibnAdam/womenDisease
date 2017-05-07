/*using System;
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
*/

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
        // String biopsy; 
        string strCheckValue = "";
        private void button1_Click(object sender, EventArgs e)
        {

            con.OpenConection();


            if (chkCervical.Checked)
            {

                strCheckValue = strCheckValue + "," + chkCervical.Text;

            }

            if (chkEndocervical.Checked)
            {

                strCheckValue = strCheckValue + "," + chkEndocervical.Text;

            }
            if (chkEndometrial.Checked)
            {
                strCheckValue = strCheckValue + "," + chkEndometrial.Text;
            }

            strCheckValue = strCheckValue.TrimStart(',');



            SqlCommand cmd = new SqlCommand("Add_Hysteroscopy", con.con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("t",txt_visit_id.Text );
                cmd.Parameters.AddWithValue("Indication", txtIND.Text);
                cmd.Parameters.AddWithValue("Cervical_canal", txtCervical.Text);
                cmd.Parameters.AddWithValue("Isthmus", txtLsthmus.Text);
                cmd.Parameters.AddWithValue("Cavity", txtCuvity.Text);
                cmd.Parameters.AddWithValue("Mucosa", txtMucos.Text);
                cmd.Parameters.AddWithValue("Tubal_Orifices", txtTubal.Text);
                cmd.Parameters.AddWithValue("Biopsy", strCheckValue);
                cmd.Parameters.AddWithValue("Suggested_Management", txtSuggested.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم بنجاح");


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_visit_id.Text = "";
            txtIND.Text = "";
            txtCervical.Text = "";
            txtLsthmus.Text = "";
            txtCuvity.Text = "";
            txtMucos.Text = "";
            txtTubal.Text = "";
            txtSuggested.Text = "";
        }

        private void txtIND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام صحيحة فقط");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        //
        private void txt_visit_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام صحيحة فقط");
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtCervical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show(" من فضلك ادخل حروف فقط");
            }

        }

        private void txtLsthmus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show(" من فضلك ادخل حروف فقط");
            }

        }

        private void txtCuvity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show(" من فضلك ادخل حروف فقط");
            }

        }

        private void txtMucos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show(" من فضلك ادخل حروف فقط");
            }

        }

        private void txtTubal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show(" من فضلك ادخل حروف فقط");
            }

        }

        






    }
}

      
  

      
  
