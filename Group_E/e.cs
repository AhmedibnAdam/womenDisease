using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace womenDisease
{
    public partial class e : Form
    {
        Connection con = new Connection();
        public e()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        String path = "";

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dd = new OpenFileDialog();
            if (dd.ShowDialog() == DialogResult.OK) {
               path = dd.FileName;
                pictureBox1.Image = Image.FromFile(dd.FileName);
                
            }
                          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                DataTable dt = new DataTable();
                dt.Columns.Add("name"); dt.Columns.Add("dia"); dt.Columns.Add("r1"); dt.Columns.Add("r2"); dt.Columns.Add("age"); dt.Columns.Add("sig");
                dt.Rows.Add(textBox1.Text,textBox3.Text,textBox4.Text,textBox6.Text,textBox2.Text,textBox5.Text);
                reportViewer1.LocalReport.DataSources.Clear();
                var rtds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rtds);
                reportViewer1.RefreshReport();

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);

                using (FileStream fs = new FileStream("receipt.pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                PrintDocument printdoc = new PrintDocument();
                printdoc.DocumentName = "receipt.pdf";
                printdoc.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];
                printdoc.Print();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //insert img in database
            try
            {
                con.OpenConection();
                string s = "insert into request_spcialist (photo_pass) values ('"+path+"');";
                con.ExecuteQueries(s);
                con.CloseConnection();
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
