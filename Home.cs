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
    public partial class Home : Form
    {
        public Examination_ultrasound_group_L hh;
        private int childFormNumber = 0;
        //OH
        SqlConnection con;
        SqlDataReader dr;
        Connection connect;
        BindingSource bs;
        SqlDataAdapter da;
        SqlCommandBuilder ba;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Connection conn = new Connection();
        string s;
        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            new Examination_ultrasound_group_L().Show();

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            hh = new Examination_ultrasound_group_L();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.OpenConection();

            if (!Class1.chkEmpty(comboBox3.Items[comboBox3.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox4.Items[comboBox4.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox19.Items[comboBox19.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox1.Items[comboBox1.SelectedIndex].ToString()) && !Class1.chkEmpty(comboBox2.Items[comboBox2.SelectedIndex].ToString()) && !Class1.chkEmpty(textBox6.Text) && !Class1.chkEmpty(comboBox16.Items[comboBox16.SelectedIndex].ToString()))
            {

                connect.OpenConection();
                string pName = "phis_obst_history1";
                dt = (DataTable)connect.ShowDataInGridViewUsingStoredProc(pName);
                dataGridView1.DataSource = dt;
                ///////////////////////


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
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName2, paramNames, paramValues, paramType);
                /////////////////
                string pName3 = "phis_obst_history3";
                string ch = comboBox5.Items[comboBox5.SelectedIndex].ToString();
                string Bl = comboBox6.Items[comboBox6.SelectedIndex].ToString();
                string al = comboBox7.Items[comboBox7.SelectedIndex].ToString();
                string[] paramNames3 = { "@chronic_mediacl_diseases", "@Blood_transfusion", "@allergies" };
                string[] paramValues3 = { ch, Bl, al };
                SqlDbType[] paramType3 = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName3, paramNames3, paramValues3, paramType3);
                ///////////////////////////////////////////
                string pName4 = "phis_obst_history4";
                string ob = comboBox8.Items[comboBox8.SelectedIndex].ToString();
                string[] paramNames4 = { "@obstetrical _Gynecological", "@other_data" };
                string[] paramValues4 = { ob, textBox9.Text };
                SqlDbType[] paramType4 = { SqlDbType.VarChar, SqlDbType.VarChar };
                connect.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName4, paramNames4, paramValues4, paramType4);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.OpenConection();
            da = new SqlDataAdapter("select patient_name,entry_state from PHIS_doctors,PHIS_patient_Visits,PHIS_patient where " +
           "PHIS_doctors.doc_ssn=PHIS_patient_Visits.doc_ssn and PHIS_patient.patient_id=PHIS_patient_Visits.patient_id and full_name='" + textBox20.Text + "' and entry_date='" + s + "';", conn.con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.OpenConection();
            cmd = new SqlCommand("insert into Investigation(comment) values('" + textBox19.Text + "');", conn.con);
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string dt = dateTimePicker2.ToString();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string dt = dateTimePicker2.ToString();

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

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string dt = dateTimePicker5.ToString();

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

        private void تنظيمالاسرهوالصحهالانجابيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            تنظيم_الأسرة_والصحة_الانجابية f = new تنظيم_الأسرة_والصحة_الانجابية();
            f.Show();
        }



        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void استمارةمنتفعةبخدماتتنظيمالاسرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fol_serv f = new fol_serv();
            f.Show();
        }

        private void طلباستدعاءاخصائياستشاريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            e gr = new e();
            gr.Show();
        }

        private void تقريرالسجلالمرضيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_past_history frm = new frm_past_history();
            frm.Show();
        }

        private void بعدالعمليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afterOPerations afterOP = new afterOPerations();
            afterOP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
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
                conn.OpenConection();
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

                conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_Present", pramname, pramvalue, pramtype);
                conn.OpenConection();
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
                conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("insert_gynecologic_complaint", pramname1, pramvalue1, pramtype1);
                conn.CloseConnection();
                MessageBox.Show("successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Insert Menestrual History 

            try
            {
                conn.OpenConection();
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
                conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("PHIS_Menstrual_History_insert", pramname, pramvalue, pramtype);
                MessageBox.Show("The data is inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //Insert operative History
            try
            {
                conn.OpenConection();
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

                dataGridView1.DataSource = conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_insert", pramname1, pramvalue1, pramtype1);
                MessageBox.Show("تم ادخال البيانات بنجاح");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Update Menstural History
            try
            {
                conn.OpenConection();
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
                conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("PHIS_Menstrual_History_update", pramname, pramvalue, pramtype);
                MessageBox.Show("The data is Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //update operative History 

            conn.OpenConection();
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
            conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_update ", pramname1, pramvalue1, pramtype1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConection();
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
                conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName2, paramNames, paramValues, paramType);
                MessageBox.Show("تم ادخال البيانات بنجاح");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.OpenConection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn.returnObject();
            cmd.CommandText = "PHIS_Max_visitid";
            cmd.Parameters.AddWithValue("x", patient_id.Text);
            cmd.Parameters.Add("y", SqlDbType.VarChar, 250);
            cmd.Parameters["y"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            visit_id.Text = cmd.Parameters["y"].Value.ToString();
            conn.CloseConnection();
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
            object t = conn.ShowDataInGridViewUsingStoredProc("Patient_identification3", pramname, pramvalue, pramtype);
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
            object x = conn.ShowDataInGridViewUsingStoredProc("PHIS_Menstrual_History_select", pram_name, pramval, pram_type);
            object y = conn.ShowDataInGridViewUsingStoredProc("PHIS_Operative_history_select", pram_name, pramval, pram_type);
            d = (DataTable)x;
            d1 = (DataTable)y;
            if (d.Rows.Count >= 1)
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

    }
}

