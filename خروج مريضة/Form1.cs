using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Printing;

namespace womenDisease
{
    public partial class doctor_orders : Form
    {
        string strfilename;
        private PrintDocument printDocument1 = new PrintDocument();
        Connection conn = new Connection();
        
        public doctor_orders()
        {
            InitializeComponent();
           
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
          
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Treatment_paper f2 =new frm_Treatment_paper();
            f2.Show();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "حسب الطلب") 
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                    }
            else if (comboBox1.SelectedItem == "عدم التواجد /هروب")
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
                panel2.Location = panel1.Location;

            }
            else if (comboBox1.SelectedItem == "وفاة")
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Location = panel1.Location;

            }
            else if (comboBox1.SelectedItem == "متابعه")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else if (comboBox1.SelectedItem == "تحسن")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height-50, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog(this) == DialogResult.OK)
            {
                strfilename = op.InitialDirectory + op.FileName;
                
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.OpenConection();
            string[] pramname = new string[1];
            string[] pramvalue = new string[1];
            SqlDbType[] pramtype = new SqlDbType[1];
            pramname[0] = "@image";


            pramvalue[0] = strfilename;
           



            pramtype[0] = SqlDbType.VarChar;




           conn.ExecuteInsertOrUpdateOrDeleteUsingStoredProc("addReport", pramname, pramvalue, pramtype);
                MessageBox.Show("inserted");
                conn.CloseConnection();
            }



        }

    }

