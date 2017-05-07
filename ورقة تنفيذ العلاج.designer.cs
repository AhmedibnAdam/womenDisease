namespace womenDisease
{
    partial class frm_treatment
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
            this.lbl_treat_name = new System.Windows.Forms.Label();
            this.txt_treat_name = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cb_how = new System.Windows.Forms.ComboBox();
            this.lbl_how = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_doctor_name = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_treat_name
            // 
            this.lbl_treat_name.AutoSize = true;
            this.lbl_treat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_treat_name.Location = new System.Drawing.Point(430, 36);
            this.lbl_treat_name.Name = "lbl_treat_name";
            this.lbl_treat_name.Size = new System.Drawing.Size(69, 24);
            this.lbl_treat_name.TabIndex = 0;
            this.lbl_treat_name.Text = "اسم الدواء";
            // 
            // txt_treat_name
            // 
            this.txt_treat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_treat_name.Location = new System.Drawing.Point(245, 36);
            this.txt_treat_name.Name = "txt_treat_name";
            this.txt_treat_name.Size = new System.Drawing.Size(138, 26);
            this.txt_treat_name.TabIndex = 1;
            this.txt_treat_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(188, 34);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(54, 24);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "الجرعة";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(25, 32);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(138, 26);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_how
            // 
            this.cb_how.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_how.FormattingEnabled = true;
            this.cb_how.Location = new System.Drawing.Point(57, 90);
            this.cb_how.Name = "cb_how";
            this.cb_how.Size = new System.Drawing.Size(326, 28);
            this.cb_how.TabIndex = 2;
            // 
            // lbl_how
            // 
            this.lbl_how.AutoSize = true;
            this.lbl_how.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_how.Location = new System.Drawing.Point(401, 90);
            this.lbl_how.Name = "lbl_how";
            this.lbl_how.Size = new System.Drawing.Size(99, 24);
            this.lbl_how.TabIndex = 0;
            this.lbl_how.Text = "طريقة الأعطاء";
            this.lbl_how.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(442, 148);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(51, 24);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "التاريخ";
            this.lbl_date.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(442, 211);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(49, 24);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "الساعة";
            this.lbl_time.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 215);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // lbl_doctor_name
            // 
            this.lbl_doctor_name.AutoSize = true;
            this.lbl_doctor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_name.Location = new System.Drawing.Point(415, 279);
            this.lbl_doctor_name.Name = "lbl_doctor_name";
            this.lbl_doctor_name.Size = new System.Drawing.Size(78, 24);
            this.lbl_doctor_name.TabIndex = 0;
            this.lbl_doctor_name.Text = "اسم الطبيب";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doctor_name.Location = new System.Drawing.Point(183, 279);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(200, 26);
            this.txt_doctor_name.TabIndex = 1;
            this.txt_doctor_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(57, 330);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 4;
            this.btn_done.Text = "تـم";
            this.btn_done.UseVisualStyleBackColor = true;
            // 
            // frm_treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_how);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_doctor_name);
            this.Controls.Add(this.txt_treat_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_doctor_name);
            this.Controls.Add(this.lbl_how);
            this.Controls.Add(this.lbl_treat_name);
            this.Name = "frm_treatment";
            this.RightToLeftLayout = true;
            this.Text = "ورقة تنفيذ العلاج";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_treat_name;
        private System.Windows.Forms.TextBox txt_treat_name;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cb_how;
        private System.Windows.Forms.Label lbl_how;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_doctor_name;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Button btn_done;
    }
}