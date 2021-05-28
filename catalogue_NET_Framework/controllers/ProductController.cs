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
    public class ProductController : ApiController
    {
        public IHttpActionResult getproduct()
        {
            string path = HttpContext.Current.Request.Url.AbsolutePath;

            string sql_host = Environment.GetEnvironmentVariable("sql_host", EnvironmentVariableTarget.Machine);

            if (null == sql_host)
            {
                sql_host = "robotshopsrvs.mcmpoc.com";
            }

            String sku = path.Substring(9);
            sku = System.Uri.UnescapeDataString(sku);
            Debug.WriteLine("sku: " + sku);
            List<ProductClass> pc = new List<ProductClass>();
            //string mainconn = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
            string mainconn = "data source=" + sql_host + ";initial catalog=catalogue;persist security info=True;user id=SA;password=Passw0rd#;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            string sqlquery = "select * from [dbo].[products] where sku = @sku";
            SqlCommand cmd = new SqlCommand(sqlquery, sqlconn);
            SqlParameter skuParam = cmd.Parameters.Add("@sku", SqlDbType.NVarChar, 255);
            skuParam.Value = sku;
            SqlDataReader sdr = cmd.ExecuteReader();



            while (sdr.Read())
            {
                pc.Add(new ProductClass()
                {
                    sku = sdr.GetValue(0).ToString(),
                    name = sdr.GetValue(1).ToString(),
                    description = sdr.GetValue(2).ToString(),
                    price = Convert.ToInt32(sdr.GetValue(3)),
                    instock = Convert.ToInt32(sdr.GetValue(4)),
                    categories = sdr.GetValue(5).ToString()
                });
            }

            sqlconn.Close();

            return Ok(pc);
        }
    }
}
