using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NZFurnitureStore.Models
{
    public class headID
    {
        public String head_ID {get;set;}
        public String head_Password { get; set; }

        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-57QUUPE\\SQLEXPRESS;Initial Catalog=NZFurniture;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        public int loginVerfication() {


            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand("select * from headDetails where headID='"+head_ID+ "' and headPassword='"+head_Password+"'", sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();
            if (tbl.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }

}