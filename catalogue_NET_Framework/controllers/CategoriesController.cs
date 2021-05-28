using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using catalogue.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web;

using System.Diagnostics;
namespace catalogue.Controllers
{
    public class CategoriesController : ApiController
    {
        public IHttpActionResult getcategories()
        {

            string sql_host = Environment.GetEnvironmentVariable("sql_host", EnvironmentVariableTarget.Machine);

            if (null == sql_host)
            {
                sql_host = "robotshopsrvs.mcmpoc.com";
            }

            List<String> pc = new List<String>();
        
            string mainconn = "data source=" + sql_host + ";initial catalog=catalogue;persist security info=True;user id=SA;password=Passw0rd#;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select distinct categories from [dbo].[products]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                pc.Add(Convert.ToString(sdr.GetString(0)));
             }

            sqlconn.Close();
            return Ok(pc);
        }
    }
}

