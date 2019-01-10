using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace student
{
    class db
    {
        //public static string connectionstring = "Data Source=127.0.0.1 ;Initial Catalog=db_sketch;Persist Security Info=True;User ID=sa;Password=123456";
        public static string connectionstring = "Data Source=(local);database=student_Mis;uid=sa;password=123456;";

        public static SqlConnection OpenDB()
        {
            try
            {
                SqlConnection oConn = new SqlConnection(connectionstring);
                oConn.Open();

                return oConn;
            }
            catch
            {
                throw;
            }
        }

        public static void CloseDB(SqlConnection oConn)
        {
            try
            {
                oConn.Close();
            }
            catch
            {
                throw;
            }
        }

        public static DataSet Execute(string strCommandString)
        {
            try
            {
                SqlConnection oConn = OpenDB();

                DataSet oDataSet = new DataSet();
                SqlDataAdapter oDataAdapter = new SqlDataAdapter(strCommandString, oConn);
                oDataAdapter.Fill(oDataSet);

                CloseDB(oConn);

                return oDataSet;
            }
            catch
            {
                throw;
            }
        }

        public static int ExecuteNonQuery(string strCommandString)
        {
            int li_count = 0;
            SqlConnection oConn = null;
            SqlCommand oComm = null;
            try
            {
                oConn = new SqlConnection(connectionstring);
                oComm = new SqlCommand();
                oConn.Open();
                oComm.Connection = oConn;
                oComm.CommandText = strCommandString;
                li_count = oComm.ExecuteNonQuery();
                return li_count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (oConn != null) oConn.Close();
            }
        }

        public static int ExecuteReid(string strCommandString)
        {
            int li_count = 0;
            SqlConnection oConn = null;
            SqlCommand oComm = null;
            try
            {
                oConn = new SqlConnection(connectionstring);
                oComm = new SqlCommand();
                oConn.Open();
                oComm.Connection = oConn;
                oComm.CommandText = strCommandString;
                li_count = Convert.ToInt32(oComm.ExecuteScalar().ToString());
                return li_count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (oConn != null) oConn.Close();
            }
        }

    }
}
