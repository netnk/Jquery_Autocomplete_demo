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
                 var term = context.Request.QueryString["term"];
                 context.Response.Write(sqldb.sql_query2("select newbook01  from newbook where  newbook01 like '%' + @term+'%'", "newbook01" ,term));  
                 break;
              }
      }
  }
}
  
