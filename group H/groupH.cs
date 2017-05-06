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
    public partial class groupH : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=172.31.44.128;Initial Catalog=NEW_PHIS;User id=sa;Password=sql@2013");
        Connection con = new Connection();
        SqlCommand cmd = new SqlCommand();

        public groupH()
        {
            InitializeComponent();
        }


        private void groupH_Load(object sender, EventArgs e)
        {
            try
            {
                con.OpenConection();
                // MessageBox.Show("The Connection is open");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                con.CloseConnection();
            }

            dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;

            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView2.BorderStyle = 0;
            dataGridView2.RowHeadersVisible = false;

            dataGridView2.BackgroundColor = Color.White;
            con.OpenConection();

            con.DataReader("Patientnames");
            dataGridView2.DataSource = con.ShowDataInGridView("Patientnames");
            con.CloseConnection();    
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.CommandText = "PHIS_Max_visitid";
            cmd.Parameters.AddWithValue("x", patient_id.Text);
            cmd.Parameters.Add("y", SqlDbType.VarChar, 250);
            cmd.Parameters["y"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            visit_id.Text = cmd.Parameters["y"].Value.ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
         try
            {
                string s = "";
                string s1 = "";
                string s2 = "";
                string s3 = "";
                if (checkBox1.Checked == true)
                    s += "no diseases";
                if (checkBox2.Checked == true)
                    s += "Diabetes Mellitus";
                if (checkBox3.Checked == true)
                    s += "Hypertension";
                if (checkBox4.Checked == true)
                    s += "Rheumatic heart disease";
                if (checkBox5.Checked == true)
                    s += "congenital heart disease";
                if (checkBox6.Checked == true)
                    s += "ischemic heart disease";
                if (checkBox7.Checked == true)
                    s += "hyperthyroidism";

                if (checkBox8.Checked == true)
                    s += "bronchial asthma";

                if (checkBox9.Checked == true)
                    s += "SLE";
                if (checkBox10.Checked == true)
                    s += "rheumatoid arthritis";
                if (checkBox11.Checked == true)
                    s += "chronic renal failure";
                if (checkBox12.Checked == true)
                    s += "acute renal failure";
                if (checkBox13.Checked == true)
                    s1 = "Blood transfusion";
                if (checkBox14.Checked == true)
                    s2 = "Allergies";
                if (textBox3.Text != "")
                    s3 = textBox3.Text;
                con.OpenConection();
                string[] pramname = new string[5];
                string[] pramvalue = new string[5];
                SqlDbType[] pramtype = new SqlDbType[5];
                pramname[0] = "@x1";
                pramname[1] = "@x2";
                pramname[2] = "@x3";
                pramname[3] = "@x4";
                pramname[4] = "@x5";

                pramvalue[0] = visit_id.Text;
                pramvalue[1] = s;
                pramvalue[2] = s3;
                pramvalue[3] = s1;
                pramvalue[4] = s2;

                pramtype[0] = SqlDbType.Int;
                pramtype[1] = SqlDbType.VarChar;
                pramtype[2] = SqlDbType.VarChar;
                pramtype[3] = SqlDbType.VarChar;
                pramtype[4] = SqlDbType.VarChar;

                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_Present", pramname, pramvalue, pramtype);
                con.OpenConection();
                string[] pramname1 = new string[3];
                string[] pramvalue1 = new string[3];
                SqlDbType[] pramtype1 = new SqlDbType[3];
                pramname1[0] = "@x1";

                pramname1[1] = "@a2";
                pramname1[2] = "@a3";

                pramvalue1[0] = visit_id.Text;
                pramvalue1[1] = comboBox8.SelectedItem.ToString();
                pramvalue1[2] = numericUpDown9.Value + "" + comboBox7.SelectedItem.ToString();
                pramtype1[0] = SqlDbType.Int;
                pramtype1[1] = SqlDbType.VarChar;
                pramtype1[2] = SqlDbType.VarChar;
                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_gynecologic_complaint", pramname1, pramvalue1, pramtype1);
                con.CloseConnection();
                MessageBox.Show("successfuly");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            //Insert Menestrual History 
           
               try
                {
                    con.OpenConection();
                    string[] pramname = new string[10];
                    string[] pramvalue = new string[10];
                    SqlDbType[] pramtype = new SqlDbType[10];
                    pramname[0] = "@cb_Age_at_menarche";
                    pramname[1] = "@cb_Rhythm";
                    pramname[2] = "@cb_LMP";
                    pramname[3] = "@cb_Amount";
                    pramname[4] = "@cb_division_result";
                    pramname[5] = "@cb_Dysmenorrhea";
                    pramname[6] = "@pem_months";
                    pramname[7] = "@pom_years";
                    pramname[8] = "@am_years";
                    pramname[9] = "@visit_id";
                    pramvalue[0] = numericUpDown2.Value.ToString();
                    if (comboBox4.SelectedIndex<0)
                    {
                        pramvalue[1] = "Unknown";
                    }
                    else
                    {
                        pramvalue[1] = comboBox4.SelectedItem.ToString();
                    }


                    pramvalue[2] = dateTimePicker1.Value.ToString() ;
                    if (comboBox5.SelectedIndex < 0)
                    {
                        pramvalue[3] = "Unknown";
                    }
                    else
                    { pramvalue[3] = comboBox5.SelectedItem.ToString(); }

                    double result=(double.Parse(numericUpDown5.Value.ToString())/int.Parse(numericUpDown3.Value.ToString()));
                    pramvalue[4] = result.ToString() ;
                    if (comboBox3.SelectedIndex < 0)
                   {
                       pramvalue[5] = "Unknown";
                   }
                   else
                   {pramvalue[5] = comboBox3.SelectedItem.ToString();}
                    
                    pramvalue[6] = numericUpDown4.Value.ToString();
                    pramvalue[7] = numericUpDown7.Value.ToString();
                    pramvalue[8] = numericUpDown6.Value.ToString();
                    pramvalue[9] = visit_id.Text;
                    pramtype[0] = SqlDbType.Int;
                    pramtype[1] = SqlDbType.VarChar;
                    pramtype[2] = SqlDbType.Date;
                    pramtype[3] = SqlDbType.VarChar;
                    pramtype[4] = SqlDbType.Decimal;
                    pramtype[5] = SqlDbType.VarChar;
                    pramtype[6] = SqlDbType.Int;
                    pramtype[7] = SqlDbType.Int;
                    pramtype[8] = SqlDbType.Int;
                    pramtype[9] = SqlDbType.Int;
                    con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("PHIS_Menstrual_History_insert", pramname, pramvalue, pramtype);
                    MessageBox.Show("The data is inserted");

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString());
                }
            

            //Insert operative History
                try
                {
                    con.OpenConection();
                    string[] pramname1 = new string[6];
                    string[] pramvalue1 = new string[6];
                    SqlDbType[] pramtype1 = new SqlDbType[6];
                    pramname1[0] = "@name";
                    pramname1[1] = "@duration";
                    pramname1[2] = "@duration_type ";
                    pramname1[3] = "@comment";
                    pramname1[4] = "@other_data";
                    pramname1[5] = "@visit_id";
                    pramvalue1[0] = comboBox1.SelectedItem.ToString();
                    pramvalue1[1] = numericUpDown1.Text;
                    pramvalue1[2] = comboBox2.SelectedItem.ToString();
                    pramvalue1[3] = textBox2.Text;
                    pramvalue1[4] = textBox1.Text;
                    pramvalue1[5] = visit_id.Text;
                    pramtype1[0] = SqlDbType.VarChar;
                    pramtype1[1] = SqlDbType.Int;
                    pramtype1[2] = SqlDbType.VarChar;
                    pramtype1[3] = SqlDbType.Text;
                    pramtype1[4] = SqlDbType.Text;
                    pramtype1[5] = SqlDbType.Int;

                    dataGridView1.DataSource = con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_insert", pramname1, pramvalue1, pramtype1);
                    MessageBox.Show("تم ادخال البيانات بنجاح");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            patient_id.Text = row.Cells[0].Value.ToString();
            visit_id.Text = row.Cells[1].Value.ToString();
            string[] pramname = new string[1];
            string[] pramvalue = new string[1];
            SqlDbType[] pramtype = new SqlDbType[1];
            pramname[0] = "@x";
            pramvalue[0] = patient_id.Text;
            pramtype[0] = SqlDbType.Int;
            DataTable dt = new DataTable();
            object t = con.ShowDataInGridViewUsingStoredProc("Patient_identification3", pramname, pramvalue, pramtype);
            dt = (DataTable)t;
            textBox9.Text = dt.Rows[0][0].ToString();
            textBox8.Text = dt.Rows[0][1].ToString();
            textBox6.Text = dt.Rows[0][2].ToString();
            textBox5.Text = dt.Rows[0][3].ToString();
            textBox10.Text = dt.Rows[0][4].ToString();
            textBox11.Text = dt.Rows[0][5].ToString();

            //Select Menustral History 
            int v_id = int.Parse(visit_id.Text);
            string[] pram_name = new string[1];
            string[] pramval = new string[1];
            SqlDbType[] pram_type = new SqlDbType[1];
            pram_name[0] = "@visit_id";
            pramval[0] = v_id.ToString();
            pram_type[0] = SqlDbType.Int;
            DataTable d = new DataTable();
            DataTable d1 = new DataTable();
            object x = con.ShowDataInGridViewUsingStoredProc("PHIS_Menstrual_History_select", pram_name, pramval, pram_type);
            object y = con.ShowDataInGridViewUsingStoredProc("PHIS_Operative_history_select", pram_name, pramval, pram_type);
            d = (DataTable)x;
            d1 = (DataTable)y;
            if (d.Rows.Count>=1)
            {
                //menustral history
                numericUpDown2.Value = int.Parse(d.Rows[0][0].ToString());
                comboBox4.Text = d.Rows[0][1].ToString();
                dateTimePicker1.Text = d.Rows[0][2].ToString();
                comboBox5.Text = d.Rows[0][3].ToString();
                comboBox3.Text = d.Rows[0][5].ToString();
                numericUpDown4.Value = int.Parse(d.Rows[0][6].ToString());
                numericUpDown7.Value = int.Parse(d.Rows[0][7].ToString());
                numericUpDown6.Value = int.Parse(d.Rows[0][8].ToString());
                //operative history
                comboBox1.Text = d1.Rows[0][0].ToString();
                numericUpDown1.Value = int.Parse(d1.Rows[0][1].ToString());
                comboBox2.Text = d1.Rows[0][2].ToString();
                textBox2.Text = d1.Rows[0][3].ToString();
                textBox1.Text = d1.Rows[0][4].ToString();     
            }
            else
            {
                MessageBox.Show("Welcome you Make Gynecologic history sheet For New Patient");
            }
        }

       

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Update present Hisory
            try
            {
                string s = "";
                string s1 = "";
                string s2 = "";
                string s3 = "";
                if (checkBox1.Checked == true)
                    s += "no diseases";
                if (checkBox2.Checked == true)
                    s += "Diabetes Mellitus";
                if (checkBox3.Checked == true)
                    s += "Hypertension";
                if (checkBox4.Checked == true)
                    s += "Rheumatic heart disease";
                if (checkBox5.Checked == true)
                    s += "congenital heart disease";
                if (checkBox6.Checked == true)
                    s += "ischemic heart disease";
                if (checkBox7.Checked == true)
                    s += "hyperthyroidism";

                if (checkBox8.Checked == true)
                    s += "bronchial asthma";

                if (checkBox9.Checked == true)
                    s += "SLE";
                if (checkBox10.Checked == true)
                    s += "rheumatoid arthritis";
                if (checkBox11.Checked == true)
                    s += "chronic renal failure";
                if (checkBox12.Checked == true)
                    s += "acute renal failure";
                if (checkBox13.Checked == true)
                    s1 = "Blood transfusion";
                if (checkBox14.Checked == true)
                    s2 = "Allergies";
                if (textBox3.Text != "")
                    s3 = textBox3.Text;
                con.OpenConection();
                string[] pramname = new string[5];
                string[] pramvalue = new string[5];
                SqlDbType[] pramtype = new SqlDbType[5];
                pramname[0] = "@x1";
                pramname[1] = "@x2";
                pramname[2] = "@x3";
                pramname[3] = "@x4";
                pramname[4] = "@x5";
                pramvalue[0] = visit_id.Text;
                pramvalue[1] = s;
                pramvalue[2] = s3;
                pramvalue[3] = s1;
                pramvalue[4] = s2;
                pramtype[0] = SqlDbType.Int;
                pramtype[1] = SqlDbType.VarChar;
                pramtype[2] = SqlDbType.VarChar;
                pramtype[3] = SqlDbType.VarChar;
                pramtype[4] = SqlDbType.VarChar;

                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("PHIS_present_History_update", pramname, pramvalue, pramtype);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Update Menstural History
            try
            {
                con.OpenConection();
                string[] pramname = new string[10];
                string[] pramvalue = new string[10];
                SqlDbType[] pramtype = new SqlDbType[10];
                pramname[0] = "@cb_Age_at_menarche";
                pramname[1] = "@cb_Rhythm";
                pramname[2] = "@cb_LMP";
                pramname[3] = "@cb_Amount";
                pramname[4] = "@cb_division_result";
                pramname[5] = "@cb_Dysmenorrhea";
                pramname[6] = "@pem_months";
                pramname[7] = "@pom_years";
                pramname[8] = "@am_years";
                pramname[9] = "@visit_id";
                pramvalue[0] = numericUpDown2.Value.ToString();
                if (comboBox4.SelectedIndex < 0)
                {
                    pramvalue[1] = "Unknown";
                }
                else
                {
                    pramvalue[1] = comboBox4.SelectedItem.ToString();
                }


                pramvalue[2] = dateTimePicker1.Value.ToString();
                if (comboBox5.SelectedIndex < 0)
                {
                    pramvalue[3] = "Unknown";
                }
                else
                { pramvalue[3] = comboBox5.SelectedItem.ToString(); }

                double result = (double.Parse(numericUpDown5.Value.ToString()) / int.Parse(numericUpDown3.Value.ToString()));
                pramvalue[4] = result.ToString();
                if (comboBox3.SelectedIndex < 0)
                {
                    pramvalue[5] = "Unknown";
                }
                else
                { pramvalue[5] = comboBox3.SelectedItem.ToString(); }

                pramvalue[6] = numericUpDown4.Value.ToString();
                pramvalue[7] = numericUpDown7.Value.ToString();
                pramvalue[8] = numericUpDown6.Value.ToString();
                pramvalue[9] = visit_id.Text;
                pramtype[0] = SqlDbType.Int;
                pramtype[1] = SqlDbType.VarChar;
                pramtype[2] = SqlDbType.Date;
                pramtype[3] = SqlDbType.VarChar;
                pramtype[4] = SqlDbType.Decimal;
                pramtype[5] = SqlDbType.VarChar;
                pramtype[6] = SqlDbType.Int;
                pramtype[7] = SqlDbType.Int;
                pramtype[8] = SqlDbType.Int;
                pramtype[9] = SqlDbType.Int;
                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("PHIS_Menstrual_History_update", pramname, pramvalue, pramtype);
                MessageBox.Show("The data is Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //update operative History 

            con.OpenConection();
            string[] pramname1 = new string[6];
            string[] pramvalue1 = new string[6];
            SqlDbType[] pramtype1 = new SqlDbType[6];
            pramname1[0] = "@name";
            pramname1[1] = "@duration";
            pramname1[2] = "@duration_type ";
            pramname1[3] = "@comment";
            pramname1[4] = "@other_data";
            pramname1[5] = "@visit_id";
            pramvalue1[0] = comboBox1.SelectedItem.ToString();
            pramvalue1[1] = numericUpDown1.Text;
            pramvalue1[2] = comboBox2.SelectedItem.ToString();
            pramvalue1[3] = textBox2.Text;
            pramvalue1[4] = textBox1.Text;
            pramvalue1[5] = visit_id.Text;
            pramtype1[0] = SqlDbType.VarChar;
            pramtype1[1] = SqlDbType.Int;
            pramtype1[2] = SqlDbType.VarChar;
            pramtype1[3] = SqlDbType.Text;
            pramtype1[4] = SqlDbType.Text;
            pramtype1[5] = SqlDbType.Int;
            con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_update ", pramname1, pramvalue1, pramtype1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.OpenConection();
                string pName2 = "phis_obst_history2";
                string g = comboBox3.Items[comboBox3.SelectedIndex].ToString();
                string p = comboBox4.Items[comboBox4.SelectedIndex].ToString();
                string pl = comboBox19.Items[comboBox19.SelectedIndex].ToString();
                string sp = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string cs = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                string ab = comboBox16.Items[comboBox16.SelectedIndex].ToString();
                string[] paramNames = { "@G", "@P", "@plus", "@abnormal_deliveries", "@specify_if_yes", "@number_of_cs", "@cs_indications", "@last_delivery", "@last_abortion", "@male", "@female" };
                string[] paramValues = { g, p, pl, ab, sp, textBox6.Text, cs, dateTimePicker3.Value.ToShortDateString(), dateTimePicker4.Value.ToShortDateString(), numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString() };
                SqlDbType[] paramType = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName2, paramNames, paramValues, paramType);
                MessageBox.Show("تم ادخال البيانات بنجاح");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        

      
    }
}
