﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace womenDisease
{
    
    public partial class frm_past_history : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\projects;database=NEW_PHIS;uid=sa;pwd=root");
        SqlDataAdapter da;
        DataTable dt;
        
        public frm_past_history()
        {
            InitializeComponent();
        }

        private void frm_past_history_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_visit_id.Text == "")
            { MessageBox.Show("من فضلك أدخل رقم الزيارة "); }
            else
            {
                string query = "SELECT  entry_date, entry_state, exit_date, exit_Status, Initial_diagnosis, Final_diagnosis, recommendation, Visit_type, visit_id FROM PHIS_patient_Visits where visit_id= " + txt_visit_id.Text;
                da = new SqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);

                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();
            }
        }

        private void txt_visit_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            validation.integer(sender, e, this);
            btn_show.Focus();
        }
    }
}
