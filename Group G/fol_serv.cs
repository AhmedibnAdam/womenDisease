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
        string mensQuantity = "متوسطه", thyroid = "Normal", abdomen = "free", nipple = "R", lower = "Normal", size="Normal";
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
        int pallor, jaundicc, heart, cur_feeding, breast, vulval, uretheral, vaginal, prolapse, position, mass, tenderness, position2, vaginal_w, vaginal_masses, vaginal_masses2 = 1;
        public fol_serv()
        {
            InitializeComponent();
            panel45.Visible = false;
            panel46.Visible = false;
            panel47.Visible = false;
            panel48.Visible = false;
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
            

            

           

            

            //create procedure insert_clinic_patient
            //(@num_preg int,@num_mis int,@num_live int,@old decimal,@small decimal,@date datetime,@over int,@normal int,@num_nat int,@num_sur int,@type int
            //,@family int,@fb_type varchar,@fb_dur varchar,@ent_id int,@con int,@c_method varchar,@c_dur varchar,@inp_date date,@inp_res varchar,@preg int,@po_type varchar,@po_dur varchar,@s_effect int,@s_type varchar,@side varchar
            //,@reg varchar,@last_men date,@men_quan varchar,@men_dur int,@pain int
            //,@abno int,@feel_pain int,@severe int,@other varchar 
            //,@heart int,@varcio int,@hyper int,@diab int,@fam_his int,@yellow bit,@epli int,@tuber int,@weight decimal,@blood varchar,@check varchar
            //)
            //as
            //begin
            //declare @id int

            //set @id=(select  max(visit_id) from [dbo].[PHIS_patient_Visits])
			
            //insert into [dbo].[PHIS_Clinic_patient]
            //(visit_id,NO_of_pregnancies,NO_of_miscarriages,NO_live_sons,Older_son_age,smaller_son_age,Date_of_birth_or_miscarriage,Over_temperature_after_birth_or_miscarriage,Normal_feeding,NO_of_natural_births,NO_of_surgical_births,Type_of_last_births
            //,currently_using_family_planning_method,FB_method_type,FB_duration,Entities_id,used_contraceptive_method,C_Last_method_name,C_duration,Interruption_date,Interruption_reason,pregnancy_occurred_while_using_one_of_the_Method,PO_method_type,PO_duration,side_effects_while_using_one_of_the_Method,SE_method_type,side_effects
            //,Regular_menstruation,Last_menstruation,menstruation_Quantity,menstruation_duration,Pain_during_menstruation
            //,abnormal_vaginal_discharge_with_smell,feel_burning_while_urinating,severe_pains_below_the_abdomen,Other
            //,Heart_disease,Varicose_veins,Hypertension,Diabetes,Family_or_personal_history_of_breast_tumors,Yellow,Epilepsy,Tuberculosis,weight,blood_pressure,check_breast_self) 
			
            //values(@id ,@num_preg ,@num_mis ,@num_live ,@old ,@small ,@date ,@over ,@normal ,@num_nat ,@num_sur ,@type
            //,@family ,@fb_type ,@fb_dur ,@ent_id ,@con ,@c_method ,@c_dur ,@inp_date ,@inp_res ,@preg ,@po_type ,@po_dur ,@s_effect ,@s_type ,@side
            //,N''+@reg+'%' ,@last_men ,N''+@men_quan+'%',@men_dur,@pain
            //,@abno ,@feel_pain ,@severe ,@other 
            //,@heart ,@varcio ,@hyper ,@diab ,@fam_his ,@yellow ,@epli ,@tuber ,@weight ,@blood ,@check 
            //)
            //end




            con.OpenConection();
            int x=50;
           time_period=dateTimePicker1.Value.ToString("yyyy-MM-dd");
           //string t1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
           //string format = "yyyy-MM-dd HH:mm:ss";

           String t = dateTimePicker2.Value.ToString("yyyy-MM-dd");
           //MessageBox.Show(t1);
           //string sentence = "insert into [dbo].[PHIS_Clinic_patient](Clinic_patient_id,visit_id,NO_of_pregnancies,NO_of_miscarriages,NO_live_sons,Older_son_age,smaller_son_age,Date_of_birth_or_miscarriage,Over_temperature_after_birth_or_miscarriage,Normal_feeding,NO_of_natural_births,NO_of_surgical_births,Type_of_last_births,currently_using_family_planning_method,FB_method_type,FB_duration,Entities_id,used_contraceptive_method,C_Last_method_name,C_duration,Interruption_date,Interruption_reason,pregnancy_occurred_while_using_one_of_the_Method,PO_method_type,PO_duration,side_effects_while_using_one_of_the_Method,SE_method_type,side_effects,Regular_menstruation,Last_menstruation,menstruation_Quantity,menstruation_duration,Pain_during_menstruation,abnormal_vaginal_discharge_with_smell,feel_burning_while_urinating,severe_pains_below_the_abdomen,Other,Heart_disease,Varicose_veins,Hypertension,Diabetes,Family_or_personal_history_of_breast_tumors,Yellow,Epilepsy,Tuberculosis,weight,blood_pressure,check_breast_self) values('NULL',"+1+"," + numericUpDown3.Value.ToString() + "," + numericUpDown2.Value.ToString() + "," + numericUpDown1.Value.ToString() + "," + Convert.ToInt32(textBox10.Text) + "," + Convert.ToInt32(textBox13.Text) + "," + textBox11.Text + "," + temperatureaftermiscarriage + "," + Normalfeeding + "," + numericUpDown6.Value.ToString() + "," + numericUpDown5.Value.ToString() + "," + Typeoflastbirths + "," + familyplanning + "," + textBox17.Text + "," + textBox18.Text + "," + Convert.ToInt32(textBox19.Text) + "," + usedcontraceptivemethod + "," + textBox21.Text + "," + textBox20.Text + "," + textBox23.Text + "," + textBox22.Text + "," + pregnancyoccurred + "," + textBox26.Text + "," + textBox25.Text + "," + sideeffects + "," + textBox29.Text + "," + textBox28.Text + "," + Regmenstruation + "," + time_period + "," + mensQuantity + "," + numericUpDown4.Value.ToString() + "," + Painmenstruation + "," + abnormalsmell + "," + feelurinating + "," + severeabdomen + "," + textBox31.Text + "," + heartdisease + "," + varicoseveins + "," + hypertension + "," + diabetes + "," + familytumors + "," + yellow + "," + epilepsy + "," + tuberculosis + ","+Convert.ToDecimal(textBox32.Text)+","+textBox33.Text+","+textBox36.Text+")";
         // con.ExecuteQueries("insert into [dbo].[PHIS_Clinic_patient](visit_id,NO_of_pregnancies,NO_of_miscarriages,NO_live_sons,Older_son_age,smaller_son_age,Date_of_birth_or_miscarriage,Over_temperature_after_birth_or_miscarriage,Normal_feeding,NO_of_natural_births,NO_of_surgical_births,Type_of_last_births) values(" + x + "," + numericUpDown3.Value.ToString() + "," + numericUpDown2.Value.ToString() + "," + numericUpDown1.Value.ToString() + "," + Convert.ToInt32(textBox10.Text) + "," + Convert.ToInt32(textBox13.Text) + "," + t + "," + temperatureaftermiscarriage + "," + Normalfeeding + "," + Convert.ToInt32(numericUpDown6.Value.ToString()) + "," + Convert.ToInt32(numericUpDown5.Value.ToString()) + "," + Typeoflastbirths + ")");
           types = new SqlDbType[] {  SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Decimal, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Date, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Date, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int ,SqlDbType.Int,SqlDbType.Int,SqlDbType.Int,SqlDbType.Decimal,SqlDbType.VarChar,SqlDbType.VarChar};
            name_input = new string[] 
            {  "@num_preg" ,"@num_mis" ,"@num_live" ,"@old" ,"@small" ,"@date" ,"@over" ,"@normal" ,"@num_nat" ,"@num_sur" ,"@type","@family","@fb_type","@fb_dur","@ent_id","@con","@c_method","@c_dur","@inp_date","@inp_res","@preg","@po_type" ,"@po_dur","@s_effect" ,"@s_type","@side" ,"@reg" ,"@last_men" ,"@men_quan","@men_dur" ,"@pain","@abno" ,"@feel_pain" ,"@severe" ,"@other","@heart" ,"@varcio" ,"@hyper" ,"@diab" ,"@fam_his" ,"@yellow" ,"@epli" ,"@tuber" ,"@weight" ,"@blood" ,"@check" };
            values = new string[] 
            {  numericUpDown3.Value.ToString(), numericUpDown2.Value.ToString(), numericUpDown1.Value.ToString(), textBox10.Text, textBox13.Text, t, Convert.ToString(temperatureaftermiscarriage), Convert.ToString(Normalfeeding), numericUpDown6.Value.ToString(), numericUpDown5.Value.ToString(), Convert.ToString(Typeoflastbirths), Convert.ToString(familyplanning) ,textBox17.Text , textBox18.Text , textBox19.Text  ,Convert.ToString(usedcontraceptivemethod) , textBox21.Text , textBox20.Text , textBox23.Text , textBox22.Text , Convert.ToString(pregnancyoccurred) , textBox26.Text  , textBox25.Text , Convert.ToString(sideeffects) ,textBox29.Text , textBox28.Text , Regmenstruation , time_period , mensQuantity , numericUpDown4.Value.ToString() , Convert.ToString(Painmenstruation),Convert.ToString(abnormalsmell) , Convert.ToString(feelurinating),Convert.ToString(severeabdomen) ,textBox31.Text, Convert.ToString(heartdisease) , Convert.ToString(varicoseveins), Convert.ToString(hypertension) , Convert.ToString(diabetes) , Convert.ToString(familytumors) , Convert.ToString(yellow) , Convert.ToString(epilepsy) , Convert.ToString(tuberculosis),textBox32.Text,textBox33.Text,textBox36.Text  };
            con.ExecuteNonQueryProcedure("insert_clinic_patient", name_input, values, types);
            
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
                panel45.Visible = true;
            }
        }
        //2- هل استخدمت احدى وسائل منع الحمل سابقا
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                usedcontraceptivemethod = 1;
                panel46.Visible = true;
            }
        }
        //3- هل حدث حمل اثناء استخدام إحدى الوسائل؟
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                pregnancyoccurred = 1;
                panel47.Visible = true;
            }
        }
        //4- هل حدثت اعراض جانبية أثناء استخدام إحدى الوسائل؟
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                sideeffects = 1;

                panel48.Visible = true;
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
        //pallor الفحص الطبي
        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton49.Checked)
            {
                pallor = 0;
            }

        }
        //jaundicc
        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton64.Checked)
            {
                jaundicc = 0;
            }
        }
        //Thyroid
        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton53.Checked)
            {
                thyroid = "Enlarged";
            }

        }
        //Thyroid
        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton53.Checked)
            {
                thyroid = "Nodules";
            }

        }
        //Heart
        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton56.Checked)
            {
                heart =0;
            }

        }
        //Abdomen
        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton57.Checked)
            {
                abdomen = "Tenderness";
            }

        }
        //Abdomen
        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton52.Checked)
            {
                abdomen = "Masses";
            }
            
        }
        //Currently Breast Feeding
        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton60.Checked)
            {
                cur_feeding = 0;
            }
        }
        //Breast
        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton62.Checked)
            {
                breast = 0;
            }
        }
        //Nipple Discharge
        private void radioButton65_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton65.Checked)
            {
                nipple = "L";
            }

        }
        //Nipple Discharge
        private void radioButton67_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton67.Checked)
            {
                nipple = "BSL";
            }

        }
        //Lower Extremities
        private void radioButton69_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton69.Checked)
            {
                lower = "Varicositeis";
            }
        }
        //Lower Extremities
        private void radioButton68_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton68.Checked)
            {
                lower = "Ocdcma";
            }
        }
        //Vulval Scarring/Ulcer
        private void radioButton72_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton72.Checked)
            {
                vulval = 0;
            }

        }
        //Uretheral Discharge
        private void radioButton74_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton74.Checked)
            {
                uretheral = 0;
            }
        }
        //Vaginal Discharge
        private void radioButton76_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton76.Checked)
            {
                vaginal = 0;
            }
        }
        //Prolapse
        private void radioButton78_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton78.Checked)
            {
                prolapse = 0;
            }

        }
        //Position
        private void radioButton80_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton80.Checked)
            {
                position = 0;
            }

        }
        //Size
        private void radioButton81_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton81.Checked)
            {
                size = "Enlarged";
            }

            
        }

        private void radioButton87_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton87.Checked)
            {
                size = "Small";
            }


        }
        //Masses
        private void radioButton84_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton84.Checked)
            {
                mass = 0;
            }

        }
        //Tenderness
        private void radioButton86_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton86.Checked)
            {
                tenderness = 0;
            }
        }
        //Position 2
        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton89.Checked)
            {
                position2 = 0;
            }
        }
        //Vaginal Walls

        private void radioButton91_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton91.Checked)
            {
                vaginal_w = 0;
            }
        }

        private void radioButton93_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton93.Checked)
            {
                vaginal_masses = 0;
            }

        }

        private void radioButton95_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton95.Checked)
            {
                vaginal_masses2 = 0;
            }

        }
        //Second One Save
        private void button2_Click(object sender, EventArgs e)
        {



            

        
            //create procedure insret_clinic_exm
            //(@pallor int,@jaun int,@thy varchar,@heart int,@abdo varchar,@curFeed int,@breast_m varchar,@nipple varchar,@lower varchar,@vulval int,@urc_dis int,@vag_dis int,@prol int
            //,@g varchar,@uter_pos int,@uter_size varchar,@uter_mass int,@spec varchar,@uter_tend int,@adn_mass int,@Vag_walls int,@Cervix int
            //,@Suger varchar,@Blood varchar,@HB varchar,@Preg_test varchar,@Urine varchar,@Other varchar,@con varchar)
            //as 
            //begin
            //declare @id int
            //set @id=(select  max(visit_id) from [dbo].[PHIS_patient_Visits])
            //insert into PHIS_Clinic_Examination
            //([visit_id],[Pallor],[Jaundice],[thyroid],[Heart],[Abdomen],[Currently_breast_Feeding]
            //,[Breast_Mass],[Breast_Nipple_Discharge],[Lower_extremities],[Vulval_Scarring_ULcer],[Urctheral_Discharge]
            //,[vaginal_Discharge],[Prolapse],[Grade],[Uterus_Position],[Uterus_size],[Uterus_Masses],[Specify]
            //,[Uterus_Tenderness],[adnexa_masses],[Vaginal_walls],[Cervix],[Suger_in_Urince]
            //,[Blood_suger],[HB],[Pregnancy_test],[Urine_analysis_Main_findings],[Other],[CONCLUSION])

            //values
            //(@id,@pallor ,@jaun ,@thy ,@heart ,@abdo ,@curFeed ,@breast_m ,@nipple ,@lower ,@vulval ,@urc_dis ,@vag_dis ,@prol 
            //,@g ,@uter_pos ,@uter_size ,@uter_mass ,@spec ,@uter_tend ,@adn_mass ,@Vag_walls ,@Cervix 
            // ,@Suger ,@Blood ,@HB ,@Preg_test ,@Urine ,@Other ,@con )
            //end
	
	
	









            con.OpenConection();
			



            types = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int,
                SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar
                , SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int
                , SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar};
            name_input = new string[] { "@pallor" ,"@jaun" ,"@thy" ,"@heart" ,"@abdo" ,"@curFeed" ,"@breast_m" ,"@nipple" ,"@lower" ,"@vulval" ,"@urc_dis" ,"@vag_dis" ,"@prol" 
,"@g" ,"@uter_pos" ,"@uter_size" ,"@uter_mass" ,"@spec" ,"@uter_tend" ,"@adn_mass" ,"@Vag_walls" ,"@Cervix"
 ,"@Suger" ,"@Blood" ,"@HB" ,"@Preg_test" ,"@Urine" ,"@Other" ,"@con"};

            values = new string[] { Convert.ToString(pallor), Convert.ToString(jaundicc), thyroid, Convert.ToString(heart), abdomen, Convert.ToString(cur_feeding), Convert.ToString(breast) 
                ,nipple,lower,Convert.ToString(vulval),Convert.ToString(uretheral),Convert.ToString(vaginal),Convert.ToString(prolapse),textBox63.Text,Convert.ToString(position)
                ,size,Convert.ToString(mass),textBox73.Text,Convert.ToString(tenderness),Convert.ToString(position2),Convert.ToString(vaginal_w),Convert.ToString(vaginal_masses)
                ,Convert.ToString(vaginal_masses2),textBox84.Text,textBox85.Text,textBox87.Text,textBox86.Text,textBox88.Text,textBox89.Text,textBox90.Text};
                
                
                
                con.ExecuteNonQueryProcedure("insret_clinic_exm", name_input, values, types);

            con.CloseConnection();

			

			

			
        }

        
    }
}
