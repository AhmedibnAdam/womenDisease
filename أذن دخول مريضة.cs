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
    public partial class أذن_دخول_مريضة : Form
    {
       // Connection con = new Connection();
        public أذن_دخول_مريضة()
        {
            InitializeComponent();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          /*  string[] s1 = new string[] {"@entry_date",
	                "@entry_time",
	                "@entry_state",
	                "@exit_date",
	                "@exit_Status",
	                "@Initial_diagnosis",
	                "@Final_diagnosis",
	                "@recommendation",
	                "@hospital_num",
	                "@send_side_name",
	                "@entry_doctor_name",
	                "@responsible_doctor_name",
	                "@doc_ssn",
	                "@patient_id",
	                "@Visit_type" };

            string[] s4 = new string[] {dateTimePicker5.Text,dateTimePicker7.Text,textBox36.Text,dateTimePicker6.Text,textBox37.Text,
                textBox27.Text,textBox33.Text,textBox39.Text,textBox40.Text,comboBox9.Text,textBox26.Text,textBox28.Text,
           textBox25.Text,textBox29.Text,comboBox10.Text };
            SqlDbType[] s5 = new SqlDbType[] { SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
            SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
            SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar};
            con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_into_patient_visit", s1, s4, s5);
            MessageBox.Show("تم حفظ البيانات بنجاح");*/
        }

        private void أذن_دخول_مريضة_Load(object sender, EventArgs e)
        {
          //  con.OpenConection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          /*  string[] s = new string[] {"@patient_name" ,
	                                    "@age" ,
	                                    "@marital_status" ,
	                                    "@job " ,
	                                     "@nationality" ,
	                                     "@identity_type",
	                                      "@identity_side",
	                                      "@date_Regist",
	                                        "@phone" ,
	                                        "@address_working",
	                                        "@address_of_patient",
	                                        "@married_since",
	                                        "@married_duration " ,
	                                        "@husband_name" ,
	                                        "@husband_identity ",
                                            "@patient_Relative_name" ,
                                            "@patient_Relative_identity" ,
	                                        "@patient_Relative_state",
	                                        "@patient_Relative_phone" 
	                                        };
            string[] s2 = new string[] {textBox21.Text,textBox9.Text,comboBox4.Text,comboBox3.Text,comboBox2.Text,textBox10.Text,textBox11.Text
            ,dateTimePicker3.Text,textBox31.Text,textBox32.Text,textBox41.Text,dateTimePicker4.Text,textBox42.Text,textBox20.Text,textBox5.Text,
            textBox4.Text,textBox1.Text,comboBox4.Text,textBox2.Text};
            SqlDbType[] s3 = new SqlDbType[] { SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
            SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
            SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar};
            con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_into_patient", s, s2, s3);
            MessageBox.Show("تم حفظ البيانات بنجاح");*/

        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل حروف !");
            }*/
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل حروف !");
            }*/
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل حروف !");
            }*/
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }*/
			
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }*/
			
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }*/
			
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }
			*/
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }
			*/
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام !");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            { e.Handled = true; }
			*/
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {

           /* if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل حروف !");
            }*/
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
/*
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل حروف !");
            }*/
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("من فضلك ادخل حروف !");
            //}
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            //String d1 = dateTimePicker5.Value.ToString("dd-MM-yyyy");
            //String d2 = dateTimePicker6.Value.ToString("dd-MM-yyyy");

            //if (dateTimePicker5.Value.Date > dateTimePicker6.Value.Date)
            //{
            //    MessageBox.Show(" تاريخ الخروج يجب ان يكون اكبر من تاريخ الدخول ");
            //}
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //بحث f = new بحث();
            //// f.Show();
            //// catogrical ob = new catogrical();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    textBox29.Text = بحث.Code.ToString();

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //doc f = new doc();
            //// f.Show();
            //// catogrical ob = new catogrical();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    textBox25.Text = doc.Code.ToString();

            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //emp f = new emp();
            //// f.Show();
            //// catogrical ob = new catogrical();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    textBox28.Text = emp.Code.ToString();

            //}
        }
    }
}
