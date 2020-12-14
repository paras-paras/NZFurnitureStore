using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NZFurnitureStore.Models
{
    public class Query
    {

        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=NZFurniture;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;



        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Message { get; set; }

        public int Insert() {
            sqlConn = new SqlConnection(connection_String);
            sqlConn.Open();


            sqlCmd = new SqlCommand("insert into QuerySection(Name,Email,Phone,Message) values('"+Name+"','"+Email+"','"+Phone+"','"+Message+"')", sqlConn);
            sqlCmd.ExecuteNonQuery();

            sqlConn.Close();
            return 1;
        }

    }
}