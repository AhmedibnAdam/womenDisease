namespace womenDisease
{
    partial class frm_pastHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.past_History = new womenDisease.past_History();
            this.PHIS_abdominal_examinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHIS_abdominal_examinationTableAdapter = new womenDisease.past_HistoryTableAdapters.PHIS_abdominal_examinationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.past_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIS_abdominal_examinationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PHIS_abdominal_examinationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HIS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 89);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(933, 167);
            this.reportViewer1.TabIndex = 0;
            // 
            // past_History
            // 
            this.past_History.DataSetName = "past_History";
            this.past_History.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PHIS_abdominal_examinationBindingSource
            // 
            this.PHIS_abdominal_examinationBindingSource.DataMember = "PHIS_abdominal_examination";
            this.PHIS_abdominal_examinationBindingSource.DataSource = this.past_History;
            // 
            // PHIS_abdominal_examinationTableAdapter
            // 
            this.PHIS_abdominal_examinationTableAdapter.ClearBeforeFill = true;
            // 
            // frm_pastHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 268);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_pastHistory";
            this.Text = "السجل المرضي";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.past_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIS_abdominal_examinationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PHIS_abdominal_examinationBindingSource;
        private past_History past_History;
        private past_HistoryTableAdapters.PHIS_abdominal_examinationTableAdapter PHIS_abdominal_examinationTableAdapter;
    }
}

