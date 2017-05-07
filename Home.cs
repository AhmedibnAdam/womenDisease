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
    public partial class Home : Form
    {
        public Examination_ultrasound_group_L hh;
        private int childFormNumber = 0;
        //OH
        SqlConnection con;
        SqlDataReader dr;
        Connection connect;
        BindingSource bs;
        SqlDataAdapter da;
        SqlCommandBuilder ba;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Connection conn = new Connection();
        string s;
        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            new Examination_ultrasound_group_L().Show();

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            أذن_دخول_مريضة frm = new أذن_دخول_مريضة();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabcontrol1.TabPages[0].Controls.Add(frm);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            hh = new Examination_ultrasound_group_L();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void تنظيمالاسرهوالصحهالانجابيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            تنظيم_الأسرة_والصحة_الانجابية f = new تنظيم_الأسرة_والصحة_الانجابية();
            f.Show();
        }



        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void استمارةمنتفعةبخدماتتنظيمالاسرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fol_serv f = new fol_serv();
            f.Show();
        }

        private void طلباستدعاءاخصائياستشاريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            e gr = new e();
            gr.Show();
        }

        private void تقريرالسجلالمرضيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_past_history frm = new frm_past_history();
            frm.Show();
        }

        private void بعدالعمليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afterOPerations afterOP = new afterOPerations();
            afterOP.Show();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void tabcontrol1_MouseClick(object sender, MouseEventArgs e)
        {
            /*قسم النساء */
            groupH frm = new groupH();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabcontrol1.TabPages[2].Controls.Add(frm);
            /* قسم الحوامل */
            OBSTATRIC_HISTORY obs= new OBSTATRIC_HISTORY();
            obs.TopLevel = false;
            obs.Visible = true;
            obs.FormBorderStyle = FormBorderStyle.None;
            obs.Dock = DockStyle.Fill;
            tabcontrol1.TabPages[3].Controls.Add(obs);

            /*قسم الأستقبال */
            //أوامر الطبيب
            frm_doctor_orders doctors = new frm_doctor_orders();
            doctors.TopLevel = false;
            doctors.Visible = true;
            doctors.FormBorderStyle = FormBorderStyle.None;
            doctors.Dock = DockStyle.Fill;
            tabControl2.TabPages[0].Controls.Add(doctors);
            //تنفيذ علاج 

            frm_treatment tream = new frm_treatment();
            tream.TopLevel = false;
            tream.Visible = true;
            tream.FormBorderStyle = FormBorderStyle.None;
            tream.Dock = DockStyle.Fill;
            tabControl2.TabPages[1].Controls.Add(tream);
        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        //فتح زيارة

    }
}

