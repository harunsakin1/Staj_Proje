using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Staj
{
    public class DbYonetimi

    {
        public static SqlConnection BaglantiTestEt()
        {
            string dataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            string InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            string UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            //string Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection baglanti = new SqlConnection();
            {
                baglanti.ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Integrated Security=True;Connection Timeout=300", dataSource, InitialCatalog, UserID);

                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    SqlConnection.ClearPool(baglanti);
                    SqlConnection.ClearAllPools();
                }

                return baglanti;

            }
        }
    }
}
