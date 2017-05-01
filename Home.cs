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
        public Examination_ultrasound_group_L hh ;
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


    }
}
