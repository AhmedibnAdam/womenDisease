using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace womenDisease
{
    public class Connection
    {

        //string ConnectionString = @"Data Source=KOKO\SQLEXPRESS;Initial Catalog=PHIS;Integrated Security=True";
        string ConnectionString = @"server=FCI-PC\SQLEXPRESS;database=NEW_PHIS;Integrated Security=True";
     
        public SqlConnection con;

        public void OpenConection()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        public SqlConnection returnObject()
        { return con; }
        /// /////////////////////
        /// </summary>
        #region A
        public string PATIENT_BILL_VID;
        DataSet ads;
        SqlDataAdapter adat;
        SqlDataAdapter adata;
        SqlCommandBuilder CB;
        SqlCommandBuilder CBa;

        public void ExecuteStoredProcQueries(string Query_, string[] paramNames, string[] paramValues)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], paramValues[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet select(string query, string tablename)
        {
            try
            {
                adat = new SqlDataAdapter(query, con);
                ads = new DataSet();
                adat.Fill(ads, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ads;
        }
        public DataTable selectt(string query, string tablename)
        {
            DataTable d = new DataTable();

            try
            {
                adata = new SqlDataAdapter(query, con);
                adata.Fill(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return d;
        }

        public bool update(DataSet dd, string tablename)
        {
            try
            {
                CB = new SqlCommandBuilder(adat);
                adat.Update(dd, tablename);
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 547:
                        MessageBox.Show("عفو لا يمكن حذ هذا العنصر لانه مرتبط بجدول اخر");
                        break;
                    case 515:
                        MessageBox.Show("الرجاء الضغط على زر Enter ومن ثم الحفظ  ");
                        break;
                    default:
                        MessageBox.Show(ex.Number.ToString());
                        break;
                }
                // MessageBox.Show(ex.ToString());
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool update(DataTable dd)
        {
            try
            {
                CBa = new SqlCommandBuilder(adata);
                adata.Update(dd);
                //adat.Update(dd, tablename);
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 547:
                        MessageBox.Show("عفو لا يمكن حذ هذا العنصر لانه مرتبط بجدول اخر");
                        break;
                    case 515:
                        MessageBox.Show("الرجاء الضغط على زر Enter ومن ثم الحفظ  ");
                        break;
                    default:
                        MessageBox.Show(ex.Number.ToString());
                        break;
                }
                // MessageBox.Show(ex.ToString());
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion
        /// <summary>
        /// /////////////

        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            try
            {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlDataReader dr = null;
            try
            {
            SqlCommand cmd = new SqlCommand(Query_, con);
             dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
            return dr;
        }
        //for make StoredPro in Datareader
        public SqlDataReader ShowDataInGridViewUsingStoredProcDR(string StoredProcName, string[] paramNames, string[] paramValues
           , SqlDbType[] paramType)
        {
            SqlDataReader dataum = null;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];


                dataum = cmd.ExecuteReader();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return dataum;
        }

        //Execute procedure
        public void ExecuteNonQueryProcedure(string StoredProcName, string[] paramNames, string[] paramValues
        , SqlDbType[] paramType)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }



        public int ExecuteInsertOrUpdateOrDeleteUsingStoredProc(string StoredProcName, string[] paramNames, string[] paramValues
            , SqlDbType[] paramType)
        {
            int rowsAffected = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return rowsAffected;
        }



        public object ShowDataInGridViewUsingStoredProc(string StoredProcName, string[] paramNames, string[] paramValues
            , SqlDbType[]paramType)
        {
            object dataum = null;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for(int i=0;i<paramNames.Length;i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];

                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                dataum = ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return dataum;
        }

        public object ShowDataInGridViewUsingStoredProc(string StoredProcName)
        {
            object dataum = null;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                dataum = ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return dataum;
        }

        public object ShowDataInGridView(string Query_)
        {
            object dataum = null;
            try
            {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
             dataum = ds.Tables[0];
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
            return dataum;
        }


        public void ShowDataInsertUsingStoredProc(string StoredProcName, string[] paramNames, string[] paramValues
          , SqlDbType[] paramType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        //Group L
        public string getconstr()
        {
            return ConnectionString;
        }


        /// group c
        /// 
        public int ExecuteInsertOrUpdateOrDeleteUsingStoredProc2(string StoredProcName, string[] paramNames, string[] paramValues
    , SqlDbType[] paramType)
        {
            int rowsAffected = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { return -1; }   //  edit1   MessageBox.Show(ex.Message);            }
            return rowsAffected;
        }
    }
}