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
    public partial class fol_serv : Form
    {

        Connection con = new Connection();
        string[] name_input;
        string[] values;
        SqlDbType[] types;
        int temperatureaftermiscarriage = 0;
        int Normalfeeding = 0;
        int Typeoflastbirths = 0;
        int familyplanning = 0;
        int usedcontraceptivemethod = 0;
        int pregnancyoccurred = 0;
        int sideeffects = 0;
        string Regmenstruation="لا توجد";
        string time_period = "";
        string mensQuantity = "متوسطه";
        int Painmenstruation = 0;
        int abnormalsmell = 0;
        int feelurinating = 0;
        int severeabdomen = 0;
        int heartdisease = 0;
        int varicoseveins = 0;
        int hypertension = 0;
        int diabetes = 0;
        int familytumors = 0;
        int yellow = 0;
        int epilepsy = 0;
        int tuberculosis = 0;
        public fol_serv()
        {
            InitializeComponent();
        }

       
        //هل حدث ارتفاع فى درجة الحرارة أو افرازات صديدية بعد اخر ولادة او اجهاض
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                temperatureaftermiscarriage = 1;
            }
        }

       

        
        //For insert into PHIS_Clinic_patient
        private void button1_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            int x=50;
           time_period=dateTimePicker1.Value.ToString("yyyy-MM-dd");
           
           //string sentence = "insert into [dbo].[PHIS_Clinic_patient](Clinic_patient_id,visit_id,NO_of_pregnancies,NO_of_miscarriages,NO_live_sons,Older_son_age,smaller_son_age,Date_of_birth_or_miscarriage,Over_temperature_after_birth_or_miscarriage,Normal_feeding,NO_of_natural_births,NO_of_surgical_births,Type_of_last_births,currently_using_family_planning_method,FB_method_type,FB_duration,Entities_id,used_contraceptive_method,C_Last_method_name,C_duration,Interruption_date,Interruption_reason,pregnancy_occurred_while_using_one_of_the_Method,PO_method_type,PO_duration,side_effects_while_using_one_of_the_Method,SE_method_type,side_effects,Regular_menstruation,Last_menstruation,menstruation_Quantity,menstruation_duration,Pain_during_menstruation,abnormal_vaginal_discharge_with_smell,feel_burning_while_urinating,severe_pains_below_the_abdomen,Other,Heart_disease,Varicose_veins,Hypertension,Diabetes,Family_or_personal_history_of_breast_tumors,Yellow,Epilepsy,Tuberculosis,weight,blood_pressure,check_breast_self) values('NULL',"+1+"," + numericUpDown3.Value.ToString() + "," + numericUpDown2.Value.ToString() + "," + numericUpDown1.Value.ToString() + "," + Convert.ToInt32(textBox10.Text) + "," + Convert.ToInt32(textBox13.Text) + "," + textBox11.Text + "," + temperatureaftermiscarriage + "," + Normalfeeding + "," + numericUpDown6.Value.ToString() + "," + numericUpDown5.Value.ToString() + "," + Typeoflastbirths + "," + familyplanning + "," + textBox17.Text + "," + textBox18.Text + "," + Convert.ToInt32(textBox19.Text) + "," + usedcontraceptivemethod + "," + textBox21.Text + "," + textBox20.Text + "," + textBox23.Text + "," + textBox22.Text + "," + pregnancyoccurred + "," + textBox26.Text + "," + textBox25.Text + "," + sideeffects + "," + textBox29.Text + "," + textBox28.Text + "," + Regmenstruation + "," + time_period + "," + mensQuantity + "," + numericUpDown4.Value.ToString() + "," + Painmenstruation + "," + abnormalsmell + "," + feelurinating + "," + severeabdomen + "," + textBox31.Text + "," + heartdisease + "," + varicoseveins + "," + hypertension + "," + diabetes + "," + familytumors + "," + yellow + "," + epilepsy + "," + tuberculosis + ","+Convert.ToDecimal(textBox32.Text)+","+textBox33.Text+","+textBox36.Text+")";
           con.ExecuteQueries("insert into [dbo].[PHIS_Clinic_patient](Clinic_patient_id,visit_id,NO_of_pregnancies,NO_of_miscarriages,NO_live_sons,Older_son_age,smaller_son_age,Date_of_birth_or_miscarriage,Over_temperature_after_birth_or_miscarriage,Normal_feeding,NO_of_natural_births,NO_of_surgical_births,Type_of_last_births,currently_using_family_planning_method,FB_method_type,FB_duration,Entities_id,used_contraceptive_method,C_Last_method_name,C_duration,Interruption_date,Interruption_reason,pregnancy_occurred_while_using_one_of_the_Method,PO_method_type,PO_duration,side_effects_while_using_one_of_the_Method,SE_method_type,side_effects,Regular_menstruation,Last_menstruation,menstruation_Quantity,menstruation_duration,Pain_during_menstruation,abnormal_vaginal_discharge_with_smell,feel_burning_while_urinating,severe_pains_below_the_abdomen,Other,Heart_disease,Varicose_veins,Hypertension,Diabetes,Family_or_personal_history_of_breast_tumors,Yellow,Epilepsy,Tuberculosis,weight,blood_pressure,check_breast_self) values('NULL'," +x+ "," + numericUpDown3.Value.ToString() + "," + numericUpDown2.Value.ToString() + "," + numericUpDown1.Value.ToString() + "," + Convert.ToInt32(textBox10.Text) + "," + Convert.ToInt32(textBox13.Text) + "," + Convert.ToDateTime(textBox11.Text) + "," + temperatureaftermiscarriage + "," + Normalfeeding + "," + numericUpDown6.Value.ToString() + "," + numericUpDown5.Value.ToString() + "," + Typeoflastbirths + "," + familyplanning + "," + textBox17.Text + "," + textBox18.Text + "," + Convert.ToInt32(textBox19.Text) + "," + usedcontraceptivemethod + "," + textBox21.Text + "," + textBox20.Text + "," + textBox23.Text + "," + textBox22.Text + "," + pregnancyoccurred + "," + textBox26.Text + "," + textBox25.Text + "," + sideeffects + "," + textBox29.Text + "," + textBox28.Text + "," + Regmenstruation + "," + time_period + "," + mensQuantity + "," + numericUpDown4.Value.ToString() + "," + Painmenstruation + "," + abnormalsmell + "," + feelurinating + "," + severeabdomen + "," + textBox31.Text + "," + heartdisease + "," + varicoseveins + "," + hypertension + "," + diabetes + "," + familytumors + "," + yellow + "," + epilepsy + "," + tuberculosis + ","+x+","+textBox33.Text+","+textBox36.Text+")");
           con.CloseConnection();
        }
        //هل ترضعين حاليا رضاعة طبيعية
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                Normalfeeding = 1;
            }
        }
        //نوع اخر ولادة
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                Typeoflastbirths = 1;
            }
        }
        //1-هل تستخدمين احدى وسائل تنظيم الاسرة حاليا؟ 
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                familyplanning = 1;
            }
        }
        //2- هل استخدمت احدى وسائل منع الحمل سابقا
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                usedcontraceptivemethod = 1;
            }
        }
        //3- هل حدث حمل اثناء استخدام إحدى الوسائل؟
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                pregnancyoccurred = 1;
            }
        }
        //4- هل حدثت اعراض جانبية أثناء استخدام إحدى الوسائل؟
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                sideeffects = 1;
            }
        }
        //انتظام الدورة
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                Regmenstruation="منتظمه";
            }
        }
        //انتظام الدورة
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                Regmenstruation = "غير منتظمه";
            }
        }
        //كمية الحيض
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked)
            {
                mensQuantity = "قليله";
            }
        }
        //كمية الحيض
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                mensQuantity = "كثيره";
            }
        }
        //الآلام أثناء الحيض 
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                Painmenstruation = 1;
            }
        }
        //هل هناك افرازات مهبلة غير طبيعية(ذات رائحة)؟
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                abnormalsmell = 1;
            }
        }
        //هل تشعرين بحرقان أثناء التبول؟
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                feelurinating = 1;
            }
        }
        //هل توجد آلام شديدة اسفل البطن؟
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                severeabdomen = 1;
            }
        }
        //أمراض القلب
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                heartdisease = 1;
            }
        }
        //دوالى الساقين
        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked)
            {
                varicoseveins = 1;
            }
        }
        //ارتفاع ضغط الدم
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton40.Checked)
            {
                hypertension = 1;
            }
        }
        //مرض السكر
        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked)
            {
                diabetes = 1;
            }
        }
        //تاريخ عائلى او شخصى لأورام الثدئ
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked)
            {
                familytumors = 1;
            }
        }
        //الصفراء
        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton44.Checked)
            {
                yellow = 1;
            }
        }
        //الصرع
        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton46.Checked)
            {
                epilepsy = 1;
            }
        }
        //الدرن
        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton48.Checked)
            {
                tuberculosis = 1;
            }
        }

        
    }
}
