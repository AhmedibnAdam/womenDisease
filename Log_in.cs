using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms; 

namespace womenDisease
{
    public partial class log_in : Form
    {
        //decalre properties 
        public string Username { get; set; }
        public string Userpassword { get; set; } 
        public log_in()
        {
            InitializeComponent();
            this.Username = "admin";
            this.Userpassword = "1234"; 
        }


       
         
        //intialise  
        public log_in(string user, string pass) 
        { 
            this.Username = user; 
            this.Userpassword = pass; 
        } 
        //validate string 
        private bool StringValidator(string input) 
        { 
            string pattern = "[^a-zA-Z]"; 
            if(Regex.IsMatch(input,pattern)) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        } 
        //validate integer 
        private bool IntegerValidator(string input) 
        { 
            string pattern = "[^0-9]"; 
            if(Regex.IsMatch(input,pattern)) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        } 
        //clear user inputs 
        private void ClearTexts(string user, string pass) 
        { 
            user = String.Empty; 
            pass = String.Empty; 
        } 
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass) 
        { 
            //check user name empty 
            if (string.IsNullOrEmpty(user)) 
            { 
                MessageBox.Show("الرجاء ادخال اسم المستخدم"); 
                return false; 
 
            } 
            //check user name is valid type 
            else if (StringValidator(user) == true) 
            { 
                MessageBox.Show("ادخل نصوص فقط"); 
                ClearTexts(user,pass); 
                return false; 
            } 
            //check user name is correct 
            else 
            { 
                if (Username != user) 
                { 
                    MessageBox.Show("اسم المستخدم الذى ادخلته غير صحيح "); 
                    ClearTexts(user,pass); 
                    return false; 
                } 
                //check password is empty 
                else 
                { 
                    if (string.IsNullOrEmpty(pass)) 
                    { 
                        MessageBox.Show("الرجاء ادخال كلمة السر"); 
                        return false; 
                    } 
                    //check password is valid 
                    else if (IntegerValidator(pass) == true) 
                    { 
                        MessageBox.Show("الرجاء ادخال ارقام فقط"); 
                        return false; 
                    } 
                    //check password is correct 
                    else if(Userpassword!=pass) 
                    { 
                        MessageBox.Show("كلمة السر غير صحيحة"); 
                        return false; 
                    } 
                    else 
                    { 
                        return true; 
                    } 
                } 
            } 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = textBox1.Text;
            string pass = textBox2.Text;
            //check if eligible to be logged in 
            if (IsLoggedIn(user, pass))
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح");
                new HHome().Show();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("خطأ في تسجيل الدخول");
            } 
           
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
