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
namespace womenDisease
{
    public partial class OBSTATRIC_HISTORY : Form
    {
        
        SqlDataReader dr;
        Connection connect;
        BindingSource bs;
        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlCommandBuilder ba;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public string patientCode = "", patientName="", doctorCode = "", doctortName = "";
        string s;
        public OBSTATRIC_HISTORY()
        {
            connect = new Connection();
            InitializeComponent();
        }

        private void OBSTATRIC_HISTORY_Load(object sender, EventArgs e)
        {
             connect.OpenConection();
           
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.OpenConection();

            if (!Class1.chkEmpty(comboBox3.Items[comboBox3.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox4.Items[comboBox4.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox19.Items[comboBox19.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox1.Items[comboBox1.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox2.Items[comboBox2.SelectedIndex].ToString()) && !Class1.chkEmpty(textBox6.Text) && !Class1.chkEmpty(textBox27.Text) && !Class1.chkEmpty(comboBox21.Items[comboBox21.SelectedIndex].ToString()))
            {

                connect.OpenConection();
                string pName = "phis_obst_history1";
                dt = (DataTable)connect.ShowDataInGridViewUsingStoredProc(pName);
                ////////////////

                string pName2="phis_obst_history2";
                string g = comboBox3.Items[comboBox3.SelectedIndex].ToString();
                string p = comboBox4.Items[comboBox4.SelectedIndex].ToString();
                string pl = comboBox19.Items[comboBox19.SelectedIndex].ToString();
                string p2 = comboBox21.Items[comboBox21.SelectedIndex].ToString();
                string sp = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string cs = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                string ab = textBox27.Text;
                string[] paramNames = { "@G", "@P", "@plus", "@plusplus", "@abnormal_deliveries", "@specify_if_yes", "@number_of_cs", "@cs_indications", "@last_delivery", "@last_abortion", "@living_childern", "@male", "@female" };
                string[] paramValues = { g, p, pl, p2, ab, sp, textBox6.Text, cs, dateTimePicker3.Value.ToShortDateString(), dateTimePicker4.Value.ToShortDateString(), numericUpDown3.Value.ToString(), numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString() };
                SqlDbType[] paramType = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName2, paramNames, paramValues, paramType);
                /////////////////
                string pName3 = "phis_obst_history3";
                string ch = textBox28.Text;
                string Bl = textBox29.Text;
                string al = comboBox7.Items[comboBox7.SelectedIndex].ToString();
                string[] paramNames3 = {"@chronic_mediacl_diseases","@Blood_transfusion","@allergies" };
                string[] paramValues3 = { ch, Bl, al };
                SqlDbType[] paramType3 = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName3, paramNames3, paramValues3, paramType3);
                ///////////////////////////////////////////
                string pName4 ="phis_obst_history4";
                string ob= textBox30.Text;
                string[] paramNames4 = {"@obstetrical_Gynecological","@other_data" };
                string[] paramValues4 = {ob,textBox9.Text };
                SqlDbType[] paramType4 = {SqlDbType.VarChar,SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName4, paramNames4, paramValues4, paramType4);

            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!Class1.chkEmpty(textBox10.Text) && !Class1.chkEmpty(textBox11.Text) && !Class1.chkEmpty(textBox12.Text) && !Class1.chkEmpty(textBox21.Text) && !Class1.chkEmpty(textBox7.Text) && !Class1.chkEmpty(textBox32.Text) && !Class1.chkEmpty(textBox33.Text) && !Class1.chkEmpty(comboBox9.Items[comboBox9.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox5.Items[comboBox5.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox6.Items[comboBox6.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox8.Items[comboBox8.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox11.Items[comboBox11.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox16.Items[comboBox16.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox20.Items[comboBox20.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox18.Items[comboBox18.SelectedIndex].ToString()))
            {
                connect.OpenConection();
                string procName = "general_examination";
                string[] paramNames = {"@pulse","@BIP","@BIP2","@temp","@chest","@heart","@lower_limbs" };
                string[] paramValues = { textBox10.Text, textBox11.Text, textBox12.Text, textBox21.Text, textBox7.Text, textBox32.Text, textBox33.Text };
                SqlDbType[] paramType = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName, paramNames, paramValues, paramType);

                string procName1 = "Pelvic_examination";
                string[] paramNames1 = { "@sterile_casco_speculm", "@cervical_dilatation", "@effacement", "@presenting_part", "@station", "@position", "@bony_pelvis", "@membranes", "@membranes2" };
                string[] paramValues1 = { comboBox9.Items[comboBox9.SelectedIndex].ToString(), comboBox5.Items[comboBox5.SelectedIndex].ToString(), comboBox6.Items[comboBox6.SelectedIndex].ToString(), comboBox8.Items[comboBox8.SelectedIndex].ToString(), comboBox11.Items[comboBox11.SelectedIndex].ToString(), comboBox16.Items[comboBox16.SelectedIndex].ToString(), comboBox20.Items[comboBox20.SelectedIndex].ToString(), comboBox18.Items[comboBox18.SelectedIndex].ToString(), comboBox10.Items[comboBox10.SelectedIndex].ToString() };
                SqlDbType[] paramType1 = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName1, paramNames1, paramValues1, paramType1);

                string procName2 = "abdominal_examination";
                string[] paramNames2 = {"@fundal_level","@fundal_grip","@umbilical_grip","@plevic_grip","@others","@comment" };
                string[] paramValues2 = {comboBox12.Items[comboBox12.SelectedIndex].ToString(),comboBox13.Items[comboBox13.SelectedIndex].ToString(),comboBox14.Items[comboBox14.SelectedIndex].ToString(),comboBox15.Items[comboBox15.SelectedIndex].ToString(),textBox23.Text,textBox22.Text };
                SqlDbType[] paramType2 = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName2, paramNames2, paramValues2, paramType2);

                string procName3 = "Fetal_heart_sound_examination";
                string[] paramNames3 = {"@FHS"};
                string[] paramValues3 = {comboBox17.Items[comboBox17.SelectedIndex].ToString()};
                SqlDbType[] paramType3 = {SqlDbType.VarChar};
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName3, paramNames3, paramValues3, paramType3);
                /*
                 * connect.ShowDataInGridViewUsingStoredProc(procName);
                 * connect.ShowDataInGridViewUsingStoredProc(procName, paramNames, paramValues, paramType);
                 * connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName, paramNames, paramValues, paramType);
                 */

                MessageBox.Show("تم الحفظ بنجاح");
            }


            else
            {
                MessageBox.Show("ادخل البيانات كاملة");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            connect.OpenConection();
            cmd = new SqlCommand("insert into Investigation(comment) values('" + textBox19.Text + "');", connect.con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("data inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string dt = dateTimePicker3.ToString();

                //  string[] words = dt.Split('/');
                //  string s = words[2] +"-"+ words[0] + "-" + words[1];
                string[] words = dt.Split(' ');

                string[] dat = words[2].Split('/');
                s = dat[2];
                if (dat[0].Length == 1)
                    s += "-0" + dat[0];
                else
                    s += "-" + dat[0];
                if (dat[1].Length == 1)
                    s += "-0" + dat[1];
                else
                    s += "-" + dat[1];

                MessageBox.Show(s);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string dt = dateTimePicker4.ToString();

                //  string[] words = dt.Split('/');
                //  string s = words[2] +"-"+ words[0] + "-" + words[1];
                string[] words = dt.Split(' ');

                string[] dat = words[2].Split('/');
                s = dat[2];
                if (dat[0].Length == 1)
                    s += "-0" + dat[0];
                else
                    s += "-" + dat[0];
                if (dat[1].Length == 1)
                    s += "-0" + dat[1];
                else
                    s += "-" + dat[1];

                MessageBox.Show(s);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select patient_id,patient_name from PHIS_patient ", connect.con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox25.Text = patientCode;
            patientName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox24.Text = patientName;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*conn.OpenConection();
           cmd = new SqlCommand("insert into Investigation(comment) values('" + textBox19.Text + "');", conn.con);
           try
           {
               cmd.ExecuteNonQuery();
               MessageBox.Show("data inserted");
           }
           catch (Exception ex) {
               MessageBox.Show(ex.Message);
           }*/
            if (!Class1.chkEmpty(textBox19.Text))
            {
                connect.OpenConection();
                /*
                SqlCommand cmd = new SqlCommand("phis_Investigation1", conn.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@comment", textBox19.Text);
                cmd.ExecuteNonQuery();*/
                string procName = "phis_Provisona_Diagnosis";
                string[] paramNames = { "@comment" };
                string[] paramValues = { textBox19.Text };
                SqlDbType[] paramType = { SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(procName, paramNames, paramValues, paramType);
                MessageBox.Show("data inserted");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            { 
            
            }
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }
        /*
       private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox25.Text = patientCode;
            patientName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox24.Text = patientName;

           // MessageBox.Show(patientCode);
        }
        */
      


    }
}
