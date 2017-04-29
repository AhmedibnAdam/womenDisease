using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace womenDisease
{
    public partial class تنظيم_الأسرة_والصحة_الانجابية : Form
    {
        //Connection con = new Connection();
        public تنظيم_الأسرة_والصحة_الانجابية()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            //string[] s1 = new string[] {"@visit_id","@Date","@Visit_reason","@Out_Method" ,
            //                           "@quantity","@Next_visit_date","@Notes" };
            //string[] s4 = new string[] { textBox2.Text, dateTimePicker1.Text, comboBox1.Text, textBox7.Text, textBox6.Text, dateTimePicker2.Text, textBox4.Text };
            //SqlDbType[] s5 = new SqlDbType[] { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            //con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_Clinic_flowup", s1, s4, s5);
            //MessageBox.Show("تم حفظ البيانات بنجاح");
        }

        private void تنظيم_الأسرة_والصحة_الانجابية_Load(object sender, EventArgs e)
        {
            //con.OpenConection();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("من فضلك ادخل حروف !");
            //}
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("من فضلك ادخل ارقام !");
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{ e.Handled = true; }
			
			
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("من فضلك ادخل ارقام !");
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{ e.Handled = true; }
			
			
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //بحث_عن_مريضه f = new بحث_عن_مريضه();
            //// f.Show();
            //// catogrical ob = new catogrical();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    textBox2.Text = بحث_عن_مريضه.Code.ToString();
               
            //}

        }
    }
}
