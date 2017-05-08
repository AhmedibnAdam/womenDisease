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
        int pallor, jaundicc, heart, cur_feeding, breast, vulval, uretheral, vaginal, prolapse, position, mass, tenderness, position2, vaginal_w, vaginal_masses, vaginal_masses2 = 0;
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
            

            
                //create procedure insert_into_patient(
                //    @patient_name varchar(255) ,
                //    @age int ,
                //    @marital_status varchar(255) ,
                //    @job varchar(255) ,
                //    @nationality varchar(255) ,
                //    @identity_type varchar(255),
                //    @identity_side varchar(255) ,
                //    @date_Regist varchar(255) ,
                //    @phone varchar(255) ,
                //    @address_working varchar(255) ,
                //    @address_of_patient varchar(255) ,
                //    @married_since varchar(255) ,
                //    @married_duration  varchar(255) ,
                //    @husband_name varchar(255) ,
                //    @husband_identity varchar(255) ,
                //    @patient_Relative_name varchar(255) ,
                //    @patient_Relative_identity varchar(255) ,
                //    @patient_Relative_state varchar(255),
                //    @patient_Relative_phone varchar(255) )
                //    as 
                //    begin
                //    insert into [dbo].[PHIS_patient] (patient_name,age,marital_status,job,nationality,identity_type,identity_side,
                //    date_Regist,phone,address_working,address_of_patient,married_since,married_duration,husband_name,husband_identity
                //    ,patient_Relative_name,patient_Relative_identity,patient_Relative_state,patient_Relative_phone) values 
                //     (@patient_name,@age,@marital_status,@job,@nationality,@identity_type,@identity_side,
                //    @date_Regist,@phone,@address_working,@address_of_patient,@married_since,@married_duration,@husband_name,@husband_identity
                //    ,@patient_Relative_name,@patient_Relative_identity,@patient_Relative_state,@patient_Relative_phone);
                //    end



            con.OpenConection();

            DateTime now=DateTime.Now;
            string name = textBox6.Text + " Clinic";

            types = new SqlDbType[] { SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar};
            name_input = new string[] { "@patient_name","@age","@marital_status","@job","@nationality","@identity_type","@identity_side",
                   "@date_Regist","@phone","@address_working","@address_of_patient","@married_since","@married_duration","@husband_name","@husband_identity"
                    ,"@patient_Relative_name","@patient_Relative_identity","@patient_Relative_state","@patient_Relative_phone"};

            values = new string[] {textBox6.Text,textBox1.Text ,"Marriage","Work","Egyption",textBox5.Text,"NULL",Convert.ToString(now),textBox4.Text,"NULL",textBox3.Text,
            textBox8.Text,textBox8.Text,textBox7.Text,textBox5.Text,name,"111","NULL",textBox4.Text};


            con.ExecuteNonQueryProcedure("insert_into_patient", name_input, values, types);

            con.CloseConnection();






            

           


            



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


            con.OpenConection();




            types = new SqlDbType[] { SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar,SqlDbType.Int,SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int,
                        SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,
                        SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int,SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar};
            name_input = new string[] { "@p" ,"@p1" ,"@p2" ,"@j" ,"@j1" ,"@j2" ,"@thy" ,"@thy1" ,"@thy2" ,"@h" ,"@h1" ,"@h2" ,
                                        "@abdo" ,"@abdo1" ,"@abdo2" ,"@abdo3" ,"@cf" ,"@cf1" ,"@cf2" ,"@b" ,"@b1" ,"@b2" ,"@n" ,"@n1" ,"@n2" ,"@l" ,"@l1" ,
                                        "@l2" ,"@vu" ,"@vu1" ,"@vu2" ,"@urc" ,"@urc1" ,"@urc2" ,"@vag" ,"@vag1" ,"@vag2","@pro" ,"@pro1" ,
                                        "@pro2" ,"@g" ,"@uter" ,"@uter1" ,"@uter2" ,"@uter_s" ,"@uter_s1" ,"@uter_s2" ,"@uter_m" ,"@uter_m1" ,
                                        "@uter_m2" ,"@spec" ,"@t" ,"@t1" ,"@t2" ,"@adn_mass" ,"@adn_mass1" ,"@adn_mass2" ,"@w" ,"@w1" ,
                                        "@w2" ,"@w3" ,"@speu" ,"@speu1" ,"@speu2" ,"@speu3" ,"@sp" ,"@sp1" ,"@sp2" ,"@Suger" ,
                                        "@Blood" ,"@HB" ,"@Preg_test" ,"@Urine" ,"@Other" ,"@con"};

            values = new string[] { Convert.ToString(pallor),textBox37.Text,textBox44.Text, Convert.ToString(jaundicc),textBox38.Text,textBox45.Text, thyroid,
                textBox39.Text,textBox46.Text,Convert.ToString(heart), textBox40.Text,textBox47.Text,abdomen,textBox41.Text,textBox48.Text,textBox64.Text,
                Convert.ToString(cur_feeding),textBox42.Text,textBox49.Text, Convert.ToString(breast) ,textBox43.Text,textBox51.Text,nipple,textBox50.Text,textBox52.Text,
                lower,textBox53.Text,textBox54.Text,Convert.ToString(vulval),textBox55.Text,textBox56.Text,Convert.ToString(uretheral),textBox58.Text,textBox57.Text,
                Convert.ToString(vaginal),textBox60.Text,textBox59.Text,Convert.ToString(prolapse),textBox62.Text,textBox61.Text,textBox63.Text,
                Convert.ToString(position),textBox66.Text,textBox65.Text,size,textBox68.Text,textBox67.Text,Convert.ToString(mass),textBox70.Text,textBox69.Text,
                textBox73.Text,Convert.ToString(tenderness),textBox72.Text,textBox71.Text,Convert.ToString(position2),textBox75.Text,textBox74.Text,
                Convert.ToString(vaginal_w),textBox77.Text,textBox76.Text,textBox82.Text,Convert.ToString(vaginal_masses),textBox79.Text,textBox78.Text,textBox83.Text,
                Convert.ToString(vaginal_masses2),textBox81.Text,textBox80.Text,textBox84.Text,textBox85.Text,textBox87.Text,textBox86.Text,textBox88.Text,textBox89.Text,textBox90.Text};



            con.ExecuteNonQueryProcedure("insret_clinic_exm", name_input, values, types);

            con.CloseConnection();
            MessageBox.Show("تمت بنجاح");


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
                pallor = 1;
            }

        }
        //jaundicc
        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton64.Checked)
            {
                jaundicc = 1;
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
                heart =1;
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
                cur_feeding = 1;
            }
        }
        //Breast
        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton62.Checked)
            {
                breast = 1;
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
                vulval = 1;
            }

        }
        //Uretheral Discharge
        private void radioButton74_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton74.Checked)
            {
                uretheral = 1;
            }
        }
        //Vaginal Discharge
        private void radioButton76_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton76.Checked)
            {
                vaginal = 1;
            }
        }
        //Prolapse
        private void radioButton78_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton78.Checked)
            {
                prolapse = 1;
            }

        }
        //Position
        private void radioButton80_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton80.Checked)
            {
                position = 1;
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
                mass = 1;
            }

        }
        //Tenderness
        private void radioButton86_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton86.Checked)
            {
                tenderness = 1;
            }
        }
        //Position 2
        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton89.Checked)
            {
                position2 = 1;
            }
        }
        //Vaginal Walls

        private void radioButton91_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton91.Checked)
            {
                vaginal_w = 1;
            }
        }

        private void radioButton93_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton93.Checked)
            {
                vaginal_masses = 1;
            }

        }

        private void radioButton95_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton95.Checked)
            {
                vaginal_masses2 = 1;
            }

        }
        //Second One Save
       /* private void button2_Click(object sender, EventArgs e)
        {
                    // create procedure insret_clinic_exm
                    //(@p int,@p1 varchar (100),@p2 varchar (100),@j int,@j1 varchar (100),@j2 varchar (100),
                    //@thy varchar (100),@thy1 varchar (100),@thy2 varchar (100),@h int,@h1 varchar (100),@h2 varchar (100),
                    //@abdo varchar (100),@abdo1 varchar (100),@abdo2 varchar (100),@abdo3 varchar (100),
                    //@cf int,@cf1 varchar (100),@cf2 varchar (100),@b varchar (100),@b1 varchar (100),@b2 varchar (100),
                    //@n varchar (100),@n1 varchar (100),@n2 varchar (100),@l varchar (100),@l1 varchar (100),
                    //@l2 varchar (100),@vu int,@vu1 varchar (100),@vu2 varchar (100),@urc int,@urc1 varchar (100),
                    //@urc2 varchar (100),@vag int,@vag1 varchar (100),@vag2 varchar (100),@pro int,@pro1 varchar (100),
                    //@pro2 varchar (100),@g varchar (100),@uter int,@uter1 varchar (100),@uter2 varchar (100),
                    //@uter_s varchar (100),@uter_s1 varchar (100),@uter_s2 varchar (100),@uter_m int,@uter_m1 varchar (100),
                    //@uter_m2 varchar (100),@spec varchar (100),@t int,@t1 varchar (100),@t2 varchar (100),
                    //@adn_mass int,@adn_mass1 varchar (100),@adn_mass2 varchar (100),@w int,@w1 varchar (100),
                    //@w2 varchar (100),@w3 varchar (100),@speu int,@speu1 varchar (100),@speu2 varchar (100),
                    //@speu3 varchar (100),@sp int,@sp1 varchar (100),@sp2 varchar (100),@Suger varchar (100),
                    //@Blood varchar (100),@HB varchar (100),@Preg_test varchar (100),@Urine varchar (100),
                    //@Other varchar (100),@con varchar (100))
                    //as 
                    //begin
                    //declare @id int
                    //set @id=(select  max(visit_id) from [dbo].[PHIS_patient_Visits])
                    //insert into PHIS_Clinic_Examination
                    //([visit_id] ,[Pallor] ,[Pallor_n] ,[Pallor_r] ,[Jaundice] ,[Jaundice_n] ,[Jaundice_r] ,[thyroid] ,
                    //[thyroid_n] ,[thyroid_r] ,[Heart] ,[Heart_n] ,[Heart_r] ,[Abdomen] ,[Abdomen_n] ,[Abdomen_r] ,
                    //[Abdomen_s] ,[Currently_breast_Feeding] ,[Currently_n] ,[Currently_r] ,[Breast_Mass] ,[Breast_n] ,
                    //[Breast_r] ,[Breast_Nipple_Discharge] ,[Nipple_n] ,[Nipple_r] ,[Lower_extremities] ,[Lower_n] ,
                    //[Lower_r] ,[Vulval_Scarring_ULcer] ,[Vulval_n] ,[Vulval_r] ,[Urctheral_Discharge],[Urctheral_n] ,
                    //[Urctheral_r] ,[vaginal_Discharge] ,[vaginal_n] ,[vaginal_r] ,[Prolapse] ,[Prolapse_n] ,
                    //[Prolapse_r] ,[Grade] ,[Uterus_Position] ,[Position_n] ,[Position_r] ,[Uterus_size] ,
                    //[size_n] ,[size_r] ,[Uterus_Masses] ,[Masses_n] ,[Masses_r] ,[Specify] ,[Uterus_Tenderness] ,
                    //[Tenderness_n] ,[Tenderness_r] ,[adnexa_masses] ,[adnexa_n] ,[adnexa_r] ,[Vaginal_walls] ,
                    //[walls_n] ,[walls_r] ,[walls_s] ,[Speu] ,[Speu_n] ,[Speu_r] ,[Speu_s] ,[Speu1] ,[Speu_n1] ,
                    //[Speu_r1] ,[Suger_in_Urince],[Blood_suger] ,[HB] ,[Pregnancy_test] ,
                    //[Urine_analysis_Main_findings] ,[Other] ,[CONCLUSION])

                    //values
                    //(@id,@p ,@p1 ,@p2 ,@j ,@j1 ,@j2 ,@thy ,@thy1 ,@thy2 ,@h ,@h1 ,@h2 ,
                    //@abdo ,@abdo1 ,@abdo2 ,@abdo3 ,@cf ,@cf1 ,@cf2 ,@b ,@b1 ,@b2 ,@n ,@n1 ,@n2 ,@l ,@l1 ,
                    //@l2 ,@vu ,@vu1 ,@vu2 ,@urc ,@urc1 ,@urc2 ,@vag ,@vag1 ,@vag2,@pro ,@pro1 ,
                    //@pro2 ,@g ,@uter ,@uter1 ,@uter2 ,@uter_s ,@uter_s1 ,@uter_s2 ,@uter_m ,@uter_m1 ,
                    //@uter_m2 ,@spec ,@t ,@t1 ,@t2 ,@adn_mass ,@adn_mass1 ,@adn_mass2 ,@w ,@w1 ,
                    //@w2 ,@w3 ,@speu ,@speu1 ,@speu2 ,@speu3 ,@sp ,@sp1 ,@sp2 ,@Suger ,
                    //@Blood ,@HB ,@Preg_test ,@Urine ,@Other ,@con)
                    //end
	
	









            con.OpenConection();




            types = new SqlDbType[] { SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar,SqlDbType.Int,SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int,
                        SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar, SqlDbType.Int,
                        SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.VarChar, SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.Int,SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar,
                        SqlDbType.Int,SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.VarChar,SqlDbType.VarChar};
            name_input = new string[] { "@p" ,"@p1" ,"@p2" ,"@j" ,"@j1" ,"@j2" ,"@thy" ,"@thy1" ,"@thy2" ,"@h" ,"@h1" ,"@h2" ,
                                        "@abdo" ,"@abdo1" ,"@abdo2" ,"@abdo3" ,"@cf" ,"@cf1" ,"@cf2" ,"@b" ,"@b1" ,"@b2" ,"@n" ,"@n1" ,"@n2" ,"@l" ,"@l1" ,
                                        "@l2" ,"@vu" ,"@vu1" ,"@vu2" ,"@urc" ,"@urc1" ,"@urc2" ,"@vag" ,"@vag1" ,"@vag2","@pro" ,"@pro1" ,
                                        "@pro2" ,"@g" ,"@uter" ,"@uter1" ,"@uter2" ,"@uter_s" ,"@uter_s1" ,"@uter_s2" ,"@uter_m" ,"@uter_m1" ,
                                        "@uter_m2" ,"@spec" ,"@t" ,"@t1" ,"@t2" ,"@adn_mass" ,"@adn_mass1" ,"@adn_mass2" ,"@w" ,"@w1" ,
                                        "@w2" ,"@w3" ,"@speu" ,"@speu1" ,"@speu2" ,"@speu3" ,"@sp" ,"@sp1" ,"@sp2" ,"@Suger" ,
                                        "@Blood" ,"@HB" ,"@Preg_test" ,"@Urine" ,"@Other" ,"@con"};

            values = new string[] { Convert.ToString(pallor),textBox37.Text,textBox44.Text, Convert.ToString(jaundicc),textBox38.Text,textBox45.Text, thyroid,
                textBox39.Text,textBox46.Text,Convert.ToString(heart), textBox40.Text,textBox47.Text,abdomen,textBox41.Text,textBox48.Text,textBox64.Text,
                Convert.ToString(cur_feeding),textBox42.Text,textBox49.Text, Convert.ToString(breast) ,textBox43.Text,textBox51.Text,nipple,textBox50.Text,textBox52.Text,
                lower,textBox53.Text,textBox54.Text,Convert.ToString(vulval),textBox55.Text,textBox56.Text,Convert.ToString(uretheral),textBox58.Text,textBox57.Text,
                Convert.ToString(vaginal),textBox60.Text,textBox59.Text,Convert.ToString(prolapse),textBox62.Text,textBox61.Text,textBox63.Text,
                Convert.ToString(position),textBox66.Text,textBox65.Text,size,textBox68.Text,textBox67.Text,Convert.ToString(mass),textBox70.Text,textBox69.Text,
                textBox73.Text,Convert.ToString(tenderness),textBox72.Text,textBox71.Text,Convert.ToString(position2),textBox75.Text,textBox74.Text,
                Convert.ToString(vaginal_w),textBox77.Text,textBox76.Text,textBox82.Text,Convert.ToString(vaginal_masses),textBox79.Text,textBox78.Text,textBox83.Text,
                Convert.ToString(vaginal_masses2),textBox81.Text,textBox80.Text,textBox84.Text,textBox85.Text,textBox87.Text,textBox86.Text,textBox88.Text,textBox89.Text,textBox90.Text};
                
                
                
                con.ExecuteNonQueryProcedure("insret_clinic_exm", name_input, values, types);

            con.CloseConnection();

			

			

			
        }
        */
       

        
    }
}
