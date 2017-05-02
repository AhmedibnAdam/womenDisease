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
    public partial class emp : Form
    {



        public static string Code { get; set; }
        Connection con = new Connection();
        public emp()
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
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("employee_code1", s, s2, s3);




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
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("employee_name1", s, s2, s3);



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
                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("search_employee1", s, s2, s3);




                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }
            else
            {
                try
                {

                    con.OpenConection();


                    dataGridView1.DataSource = (DataTable)con.ShowDataInGridViewUsingStoredProc("search_employee11");




                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { con.CloseConnection(); }
            }





        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Code = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
             
                أذن_دخول_مريضة f = new أذن_دخول_مريضة();
             
                f.Focus();
          
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " dfff");
            }
        }

        private void emp_Load(object sender, EventArgs e)
        {

        }
    }
}
