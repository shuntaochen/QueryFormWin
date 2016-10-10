using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ServerListQueryFormDll
{
    public class SqlHelper
    {
        /// <summary>
        /// query data using constr & sqltext
        /// </summary>
        /// <param name="conStr"></param>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static DataTable Query(string conStr, String sqlText)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    DataSet ds = new DataSet();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    return ds.Tables[0];
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
