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
       // SqlConnection conn = new SqlConnection(@"server=(localdb)\projects;database=NEW_PHIS;Integrated Security=true");
        Connection con = new Connection();
        SqlCommand cmd = new SqlCommand();
        string s = "";
        string s1 = "";
        string s2 = "";
        string s3 = "";

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

            dgv.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;

            dgv.EnableHeadersVisualStyles = false;

            dgv.BorderStyle = 0;
            dgv.RowHeadersVisible = false;

            dgv.BackgroundColor = Color.White;
            con.OpenConection();

            con.DataReader("Patientnames");
            dgv.DataSource = con.ShowDataInGridView("Patientnames");
            con.CloseConnection();    
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            con.OpenConection();
             
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con.returnObject(); ;
            cmd.CommandText = "PHIS_Max_visitid";
            cmd.Parameters.AddWithValue("x", patient_id.Text);
            cmd.Parameters.Add("y", SqlDbType.VarChar, 250);
            cmd.Parameters["y"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            visit_id.Text = cmd.Parameters["y"].Value.ToString();
            con.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
         try
            {
                string s = "";
                string s1 = "";
                string s2 = "";
                string s3 = "";
                if (no.Checked == true)
                    s += "no diseases";
                if (Dia_mell.Checked == true)
                    s += "Diabetes Mellitus";
                if (Hyper.Checked == true)
                    s += "Hypertension";
                if (Rheu.Checked == true)
                    s += "Rheumatic heart disease";
                if (cong.Checked == true)
                    s += "congenital heart disease";
                if (isch.Checked == true)
                    s += "ischemic heart disease";
                if (hyperthy.Checked == true)
                    s += "hyperthyroidism";

                if (bronch.Checked == true)
                    s += "bronchial asthma";

                if (sle.Checked == true)
                    s += "SLE";
                if (rheum.Checked == true)
                    s += "rheumatoid arthritis";
                if (chronic.Checked == true)
                    s += "chronic renal failure";
                if (acute.Checked == true)
                    s += "acute renal failure";
                if (bloodtrans.Checked == true)
                    s1 = "Blood transfusion";
                if (allerg.Checked == true)
                    s2 = "Allergies";
                if (Drug_intak.Text != "")
                    s3 = Drug_intak.Text;
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
                pramvalue1[1] = Complaint.SelectedItem.ToString();
                pramvalue1[2] = Duration.Value + "" + type.SelectedItem.ToString();
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
                    pramvalue[0] = Age_of_Merchance.Value.ToString();
                    if (Rhythm.SelectedIndex<0)
                    {
                        pramvalue[1] = "Unknown";
                    }
                    else
                    {
                        pramvalue[1] = Rhythm.SelectedItem.ToString();
                    }


                    pramvalue[2] = LMP.Value.ToString() ;
                    if (Amount.SelectedIndex < 0)
                    {
                        pramvalue[3] = "Unknown";
                    }
                    else
                    { pramvalue[3] = Amount.SelectedItem.ToString(); }

                    double result=(double.Parse(firstval.Value.ToString())/int.Parse(secondval.Value.ToString()));
                    pramvalue[4] = result.ToString() ;
                    if (Dysmeno.SelectedIndex < 0)
                   {
                       pramvalue[5] = "Unknown";
                   }
                   else
                   {pramvalue[5] = Dysmeno.SelectedItem.ToString();}
                    
                    pramvalue[6] = Month.Value.ToString();
                    pramvalue[7] = year.Value.ToString();
                    pramvalue[8] = day.Value.ToString();
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
                    pramvalue1[0] = op_name.SelectedItem.ToString();
                    pramvalue1[1] = op_duration.Text;
                    pramvalue1[2] = Dur_type.SelectedItem.ToString();
                    pramvalue1[3] = rep.Text;
                    pramvalue1[4] = oth_dat.Text;
                    pramvalue1[5] = visit_id.Text;
                    pramtype1[0] = SqlDbType.VarChar;
                    pramtype1[1] = SqlDbType.Int;
                    pramtype1[2] = SqlDbType.VarChar;
                    pramtype1[3] = SqlDbType.Text;
                    pramtype1[4] = SqlDbType.Text;
                    pramtype1[5] = SqlDbType.Int;

                    object x= con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_insert", pramname1, pramvalue1, pramtype1);
                
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = dgv.Rows[e.RowIndex];
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
            HosNum.Text = dt.Rows[0][0].ToString();
            Admission.Text = dt.Rows[0][1].ToString();
            Address_id.Text = dt.Rows[0][2].ToString();
            Husband.Text = dt.Rows[0][3].ToString();
            Mar_Status.Text = dt.Rows[0][4].ToString();
            Dur.Text = dt.Rows[0][5].ToString();

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
            //present history data
            string[] pram_name1 = new string[1];
            string[] pramval1 = new string[1];
            SqlDbType[] pram_type1 = new SqlDbType[1];
            pram_name1[0] = "@visit_id";
            pramval1[0] = v_id.ToString();
            pram_type1[0] = SqlDbType.Int;
            object z = con.ShowDataInGridViewUsingStoredProc("PHIS_present_history_select", pram_name1, pramval1, pram_type1);
            DataTable dtt = new DataTable();
            dtt = (DataTable)z;

            if (dtt.Rows[0][0].ToString() != " ")
            {
                MessageBox.Show(dtt.Rows[0][0].ToString());

                string[] strr = dtt.Rows[0][0].ToString().Split(',');


                for (int i = 0; i < strr.Length; i++)
                {
                    if (strr[i] == "no diseases")
                        no.Checked = true;
                    if (strr[i] == "Diabetes Mellitus")
                        Dia_mell.Checked = true;
                    if (strr[i] == "Hypertension")
                        Hyper.Checked = true;
                    if (strr[i] == "Rheumatic heart disease")
                        Rheu.Checked = true;
                    if (strr[i] == "congenital heart disease")
                        cong.Checked = true;
                    if (strr[i] == "ischemic heart disease")
                        isch.Checked = true;
                    if (strr[i] == "hyperthyroidism")
                        hyperthy.Checked = true;
                    if (strr[i] == "bronchial asthma")
                        bronch.Checked = true;
                    if (strr[i] == "SLE")
                        sle.Checked = true;
                    if (strr[i] == "rheumatoid arthritis")
                        rheum.Checked = true;
                    if (strr[i] == "chronic renal failure")
                        chronic.Checked = true;
                    if (strr[i] == "acute renal failure")
                        acute.Checked = true;


                }
            }
            if (dtt.Rows[0][2].ToString() != "")
            {
                bloodtrans.Checked = true;

            }
            if (dtt.Rows[0][3].ToString() != "")
            {
                allerg.Checked = true;

            }
            Drug_intak.Text = dtt.Rows[0][1].ToString();
            if (d.Rows.Count>=1)
            {
                //menustral history
                Age_of_Merchance.Value = int.Parse(d.Rows[0][0].ToString());
                Rhythm.Text = d.Rows[0][1].ToString();
                LMP.Text = d.Rows[0][2].ToString();
                Amount.Text = d.Rows[0][3].ToString();
                Dysmeno.Text = d.Rows[0][5].ToString();
                Month.Value = int.Parse(d.Rows[0][6].ToString());
                year.Value = int.Parse(d.Rows[0][7].ToString());
                day.Value = int.Parse(d.Rows[0][8].ToString());
                //operative history
                op_name.Text = d1.Rows[0][0].ToString();
                op_duration.Value = int.Parse(d1.Rows[0][1].ToString());
                Dur_type.Text = d1.Rows[0][2].ToString();
                rep.Text = d1.Rows[0][3].ToString();
                oth_dat.Text = d1.Rows[0][4].ToString();     
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
                pramvalue[0] = Age_of_Merchance.Value.ToString();
                if (Rhythm.SelectedIndex < 0)
                {
                    pramvalue[1] = "Unknown";
                }
                else
                {
                    pramvalue[1] = Rhythm.SelectedItem.ToString();
                }


                pramvalue[2] = LMP.Value.ToString();
                if (Amount.SelectedIndex < 0)
                {
                    pramvalue[3] = "Unknown";
                }
                else
                { pramvalue[3] = Amount.SelectedItem.ToString(); }

                double result = (double.Parse(firstval.Value.ToString()) / int.Parse(secondval.Value.ToString()));
                pramvalue[4] = result.ToString();
                if (Dysmeno.SelectedIndex < 0)
                {
                    pramvalue[5] = "Unknown";
                }
                else
                { pramvalue[5] = Dysmeno.SelectedItem.ToString(); }

                pramvalue[6] = Month.Value.ToString();
                pramvalue[7] = year.Value.ToString();
                pramvalue[8] = day.Value.ToString();
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
            pramvalue1[0] = op_name.SelectedItem.ToString();
            pramvalue1[1] = op_duration.Text;
            pramvalue1[2] = Dur_type.SelectedItem.ToString();
            pramvalue1[3] = rep.Text;
            pramvalue1[4] = oth_dat.Text;
            pramvalue1[5] = visit_id.Text;
            pramtype1[0] = SqlDbType.VarChar;
            pramtype1[1] = SqlDbType.Int;
            pramtype1[2] = SqlDbType.VarChar;
            pramtype1[3] = SqlDbType.Text;
            pramtype1[4] = SqlDbType.Text;
            pramtype1[5] = SqlDbType.Int;
            con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("operative_history_update ", pramname1, pramvalue1, pramtype1);
            try
            {

                if (no.Checked == true)
                    s += "no diseases";
                if (Dia_mell.Checked == true)
                    s += "Diabetes Mellitus";
                if (Hyper.Checked == true)
                    s += "Hypertension";
                if (Rheu.Checked == true)
                    s += "Rheumatic heart disease";
                if (cong.Checked == true)
                    s += "congenital heart disease";
                if (isch.Checked == true)
                    s += "ischemic heart disease";
                if (hyperthy.Checked == true)
                    s += "hyperthyroidism";

                if (bronch.Checked == true)
                    s += "bronchial asthma";

                if (sle.Checked == true)
                    s += "SLE";
                if (rheum.Checked == true)
                    s += "rheumatoid arthritis";
                if (chronic.Checked == true)
                    s += "chronic renal failure";
                if (acute.Checked == true)
                    s += "acute renal failure";
                if (bloodtrans.Checked == true)
                    s1 = "Blood transfusion";
                if (allerg.Checked == true)
                    s2 = "Allergies";
                if (Drug_intak.Text != "")
                    s3 = Drug_intak.Text;
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
                string g = Dysmeno.Items[Dysmeno.SelectedIndex].ToString();
                string p = Rhythm.Items[Rhythm.SelectedIndex].ToString();
                string pl = v2.Items[v2.SelectedIndex].ToString();
                string sp = op_name.Items[op_name.SelectedIndex].ToString();
                string cs = Dur_type.Items[Dur_type.SelectedIndex].ToString();
                string ab = abnormal.Items[abnormal.SelectedIndex].ToString();
                string[] paramNames = { "@G", "@P", "@plus", "@abnormal_deliveries", "@specify_if_yes", "@number_of_cs", "@cs_indications", "@last_delivery", "@last_abortion", "@male", "@female" };
                string[] paramValues = { g, p, pl, ab, sp, Address_id.Text, cs, last_delivery_since.Value.ToShortDateString(), last_abortion.Value.ToShortDateString(), op_duration.Value.ToString(), Age_of_Merchance.Value.ToString() };
                SqlDbType[] paramType = { SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
                con.ExecuteInsertOrUpdateOrDeleteUsingStoredProc(pName2, paramNames, paramValues, paramType);
                MessageBox.Show("تم ادخال البيانات بنجاح");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        

      
    }
}
