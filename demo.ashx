using System.Web;
using Newtonsoft.Json;
using demo;



// Jquery autocomplete text with ashx

public class booklist : IHttpHandler
    {

demo.sqldb sqldb = new jqcrud_app.sqldb();

public void ProcessRequest(HttpContext context)
  {
    switch (context.Request["method"])
      {
         case "search_autotext":
              {
                  //Here use dateset , can use list<>
                  string query_json = JsonConvert.SerializeObject(sqldb.sql_query(@" select your sql query string ").Tables[0]);
                  context.Response.Write(query_json);
                  break;
              }
      }
  }
}
  
