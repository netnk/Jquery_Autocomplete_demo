using System.Data;
using System.Data.SqlClient;
using System.Configuration;



 public class sqldb
    {
        string st = ConfigurationManager.ConnectionStrings["sqldb"].ConnectionString; 

        public DataSet sql_query(string sql) //Query
        {            
            using (SqlConnection con = new SqlConnection(st))
            {
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(ds);                
                return ds;
            }
                
        }
    }
