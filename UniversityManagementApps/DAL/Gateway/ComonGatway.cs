using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace NavigateURLWebApps.DAL.Gatway
{
    public class ComonGatway
    {
       public string connectionString = WebConfigurationManager.ConnectionStrings["UniversityDB1ConnectionString"].ConnectionString;
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        public ComonGatway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}