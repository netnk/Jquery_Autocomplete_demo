using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;



 public class sqldb
    {
        string st = ConfigurationManager.ConnectionStrings["sqldb"].ConnectionString; 

         public string sql_query2(string sql,string key,string term) //autocomplete_title_Query,three parameter
        {

            using (SqlConnection con = new SqlConnection(st))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, new SqlConnection(st));
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@term", term);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);               
               
                string[] items = new string[dt.Rows.Count];
                int ctr = 0;
                foreach (DataRow row in dt.Rows)
                {
                    items[ctr] = (string)row[key];
                    ctr++;
                }
                return JsonConvert.SerializeObject(items);
            }

        }
    }
