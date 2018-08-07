﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _02_樊佳兴崔仲达董鑫
{
    class DBHelper
    {
        private static string connectionString = "Data Source =.; Initial Catalog =Student; Integrated Security=SSPI";
        public static int ExecuteSql(string SQLString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQLString, connection);
            try
            {
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                connection.Close();
                throw e;
            }

        }
        public static DataSet GetDataSet(string SQLString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                command.Fill(ds, "ds");
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }

        internal static SqlDataReader GetExecuteReader(string sql, object p)
        {
            throw new NotImplementedException();
        }

        internal static void GetExecuteQuery(string sql, SqlParameter[] param)
        {
            throw new NotImplementedException();
        }
    }
}
