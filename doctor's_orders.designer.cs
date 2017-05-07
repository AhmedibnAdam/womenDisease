namespace womenDisease
{
    partial class frm_doctor_orders
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_ph_notes = new System.Windows.Forms.TextBox();
            this.txt_doctor_order = new System.Windows.Forms.TextBox();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.lbl_ph_notes = new System.Windows.Forms.Label();
            this.lbl_doctor_orders = new System.Windows.Forms.Label();
            this.lbl_doctor_name = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(416, 34);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(45, 20);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "التاريخ";
            // 
            // txt_ph_notes
            // 
            this.txt_ph_notes.Location = new System.Drawing.Point(254, 135);
            this.txt_ph_notes.Name = "txt_ph_notes";
            this.txt_ph_notes.Size = new System.Drawing.Size(200, 20);
            this.txt_ph_notes.TabIndex = 2;
            // 
            // txt_doctor_order
            // 
            this.txt_doctor_order.Location = new System.Drawing.Point(254, 181);
            this.txt_doctor_order.Name = "txt_doctor_order";
            this.txt_doctor_order.Size = new System.Drawing.Size(200, 20);
            this.txt_doctor_order.TabIndex = 2;
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(71, 248);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(200, 20);
            this.txt_doctor_name.TabIndex = 2;
            // 
            // lbl_ph_notes
            // 
            this.lbl_ph_notes.AutoSize = true;
            this.lbl_ph_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ph_notes.Location = new System.Drawing.Point(33, 135);
            this.lbl_ph_notes.Name = "lbl_ph_notes";
            this.lbl_ph_notes.Size = new System.Drawing.Size(188, 20);
            this.lbl_ph_notes.TabIndex = 1;
            this.lbl_ph_notes.Text = "Physician Progress Notes";
            // 
            // lbl_doctor_orders
            // 
            this.lbl_doctor_orders.AutoSize = true;
            this.lbl_doctor_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_orders.Location = new System.Drawing.Point(33, 181);
            this.lbl_doctor_orders.Name = "lbl_doctor_orders";
            this.lbl_doctor_orders.Size = new System.Drawing.Size(120, 20);
            this.lbl_doctor_orders.TabIndex = 1;
            this.lbl_doctor_orders.Text = "Doctor\'s Orders";
            // 
            // lbl_doctor_name
            // 
            this.lbl_doctor_name.AutoSize = true;
            this.lbl_doctor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctor_name.Location = new System.Drawing.Point(378, 248);
            this.lbl_doctor_name.Name = "lbl_doctor_name";
            this.lbl_doctor_name.Size = new System.Drawing.Size(70, 20);
            this.lbl_doctor_name.TabIndex = 1;
            this.lbl_doctor_name.Text = "اسم الطبيب ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(416, 75);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(38, 20);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "الوقت";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(71, 331);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // frm_doctor_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 400);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_doctor_name);
            this.Controls.Add(this.txt_doctor_order);
            this.Controls.Add(this.txt_ph_notes);
            this.Controls.Add(this.lbl_doctor_name);
            this.Controls.Add(this.lbl_doctor_orders);
            this.Controls.Add(this.lbl_ph_notes);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frm_doctor_orders";
            this.RightToLeftLayout = true;
            this.Text = "أوامر الطبيب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_ph_notes;
        private System.Windows.Forms.TextBox txt_doctor_order;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label lbl_ph_notes;
        private System.Windows.Forms.Label lbl_doctor_orders;
        private System.Windows.Forms.Label lbl_doctor_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_save;
    }
}

