using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace womenDisease
{
    public partial class Examination_ultrasound_group_L : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public Examination_ultrasound_group_L()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private int randomN(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection(); string constr = conn.getconstr();
            SqlConnection connection = new SqlConnection(constr);
            decimal blp = 0;
            try
            {
                connection.Open();
                blp = numericUpDown1.Value / numericUpDown2.Value;

                cmd = new SqlCommand("groupL_generalExamination_insert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pulse", numericUpDown3.Value);
                cmd.Parameters.AddWithValue("@BIP", blp);
                cmd.Parameters.AddWithValue("@temp", comboBox3.SelectedItem);
                cmd.Parameters.AddWithValue("@chest", comboBox5.SelectedItem);
                cmd.Parameters.AddWithValue("@chest_note", textBox4.Text);
                cmd.Parameters.AddWithValue("@heart", comboBox6.SelectedItem);
                cmd.Parameters.AddWithValue("@heart_note", textBox1.Text);
                cmd.Parameters.AddWithValue("@lower_limbs", comboBox7.SelectedItem);
                cmd.Parameters.AddWithValue("@lower_limbs_note", textBox2.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }

            catch
            { MessageBox.Show("من فضلك ادخل البيانات الناقصة"); }

            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection(); string constr = conn.getconstr();
            SqlConnection connection = new SqlConnection(constr);
            decimal blp = 0;

            if (radioButton3.Checked==true)
            {
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }
            else if (radioButton10.Checked == true)
            {
                try
                {
                    connection.Open();
                    blp = numericUpDown1.Value / numericUpDown2.Value;

                    cmd = new SqlCommand("groupL_abdominal_examination_insert", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@other_pelvi_abdominal_mass", numericUpDown4.Value);
                    cmd.Parameters.AddWithValue("@other_hernia", comboBox9.SelectedItem);
                    cmd.Parameters.AddWithValue("@other_tenderness", comboBox10.SelectedItem);
                    cmd.Parameters.AddWithValue("@other", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت عملية الاضافة بنجاح");
                }

                catch(Exception ex)
                { MessageBox.Show(ex.Message+"من فضلك ادخل البيانات الناقصة"); }
            }
            else
            {
                MessageBox.Show("من فضلك اختر احد الخيارات");
            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Connection conn = new Connection(); string constr = conn.getconstr();
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                connection.Open();

                cmd = new SqlCommand("groupL_pelvic_examination_insert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@inspection", comboBox11.SelectedItem);
                cmd.Parameters.AddWithValue("@Bim_uterine_position", comboBox12.SelectedItem);
                cmd.Parameters.AddWithValue("@Bim_uterine_size", comboBox13.SelectedItem);
                cmd.Parameters.AddWithValue("@Bim_right_adnexa", comboBox14.SelectedItem);
                cmd.Parameters.AddWithValue("@Bim_left_adnexa", comboBox15.SelectedItem);
                cmd.Parameters.AddWithValue("@Bim_douglas_pouch", comboBox16.SelectedItem);
                cmd.Parameters.AddWithValue("@cusco", comboBox17.SelectedItem);
                cmd.Parameters.AddWithValue("@other", textBox5.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection(); string constr = conn.getconstr();
            SqlConnection connection = new SqlConnection(constr);
            decimal blp = 0;
            try
            {
                connection.Open();
                blp = numericUpDown1.Value / numericUpDown2.Value;
                int VD = randomN(1, 10000);

                cmd = new SqlCommand("groupL_ultrasound_insert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@approach", comboBox18.SelectedItem);
                cmd.Parameters.AddWithValue("@sponograph", textBox7.Text);
                cmd.Parameters.AddWithValue("@report_size_note", comboBox19.SelectedItem);
                cmd.Parameters.AddWithValue("@report_size1", numericUpDown16.Value);
                cmd.Parameters.AddWithValue("@report_size2", numericUpDown15.Value);
                cmd.Parameters.AddWithValue("@report_size3", numericUpDown14.Value);
                cmd.Parameters.AddWithValue("@reports_position", comboBox23.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_endometrical", numericUpDown21.Value);
                cmd.Parameters.AddWithValue("@reports_masses_polyp1", numericUpDown20.Value);
                cmd.Parameters.AddWithValue("@reports_masses_polyp2", numericUpDown19.Value);
                cmd.Parameters.AddWithValue("@reports_fibroid_v1", comboBox27.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_fibroid_v2", comboBox28.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_fibroid_size1", numericUpDown17.Value);
                cmd.Parameters.AddWithValue("@reports_fibroid_size2", numericUpDown18.Value);
                cmd.Parameters.AddWithValue("@reports_Rmass_v1", comboBox31.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Rmass_v2", comboBox32.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Rmass_v3", comboBox34.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Rmass_v4", comboBox33.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Rmass_v5", comboBox35.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Rmass_size1", numericUpDown5.Value);
                cmd.Parameters.AddWithValue("@reports_Rmass_size2", numericUpDown6.Value);
                cmd.Parameters.AddWithValue("@reports_Rmass_size3", numericUpDown7.Value);
                cmd.Parameters.AddWithValue("@reports_Lmass_v1", comboBox42.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Lmass_v2", comboBox41.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Lmass_v3", comboBox40.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Lmass_v4", comboBox39.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Lmass_v5", comboBox8.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_Lmass_size1", numericUpDown10.Value);
                cmd.Parameters.AddWithValue("@reports_Lmass_size2", numericUpDown9.Value);
                cmd.Parameters.AddWithValue("@reports_Lmass_size3", numericUpDown8.Value);
                cmd.Parameters.AddWithValue("@reports_douglas_ipf", comboBox47.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_v1", comboBox51.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_v2", comboBox50.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_v3", comboBox49.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_v4", comboBox48.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_v5", comboBox46.SelectedItem);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_size1", numericUpDown13.Value);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_size2", numericUpDown12.Value);
                cmd.Parameters.AddWithValue("@reports_douglas_mass_size3", numericUpDown11.Value);
                cmd.Parameters.AddWithValue("@comments", textBox6.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }

            catch(Exception ex)
            { MessageBox.Show( ex.Message + "من فضلك ادخل البيانات الناقصة");  }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection(); string constr = conn.getconstr();
            SqlConnection connection = new SqlConnection(constr);
            decimal blp = 0;
            try
            {
                connection.Open();
                blp = numericUpDown1.Value / numericUpDown2.Value;

                cmd = new SqlCommand("groupL_provisional_diagnosis_insert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@provisional_diagnosis", textBox8.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت عملية الاضافة بنجاح");
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            connection.Close();
        }
    }
}
