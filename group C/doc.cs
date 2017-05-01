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
    public partial class doc : Form
    {

        public static int Code { get; set; }
        Connection con = new Connection();
        public doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text == "")
            {
                try
                {
                    con.OpenConection();
                    string[] s = new string[] { "@ssn" };
                    string[] s2 = new string[] { textBox2.Text };
                    SqlDbType[] s3 = new SqlDbType[] { SqlDbType.Int };
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("doctor_code1", s, s2, s3);




                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                try
                {
                    con.OpenConection();
                    string[] s = new string[] { "@name" };
                    string[] s2 = new string[] { textBox1.Text };
                    SqlDbType[] s3 = new SqlDbType[] { SqlDbType.VarChar };
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("doctor_name1", s, s2, s3);



                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }

            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {

                    con.OpenConection();
                    string[] s = new string[] { "@id", "@name" };
                    string[] s2 = new string[] { textBox2.Text, textBox1.Text };
                    SqlDbType[] s3 = new SqlDbType[] { SqlDbType.Int, SqlDbType.VarChar };
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("search_doctor1", s, s2, s3);




                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }
            else
            {
                try
                {

                    con.OpenConection();


                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("search_doctor11");




                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                أذن_دخول_مريضة f = new أذن_دخول_مريضة();
                // ادارة عرباتff = new تسجيل_بيانات__مريض();
                //تقرير1 f = new تقرير1();
                f.Focus();
                //  ff.Focus();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " dfff");
            }
        }
    }
}
