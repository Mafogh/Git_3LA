using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DL;

namespace DL
{
    public class DA
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DA()
        {
            con = new SqlConnection();
            da = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.Connection = con;
            da.SelectCommand = cmd;
        }

        public void connect()
        {
            con.ConnectionString = "server=.;database=HotelDB_SE_3LayerArch;integrated security=true";
            con.Open();
        }

        public void disconnect()
        {
            con.Close();
        }

        public DataTable selectdata(string q)
        {
            cmd.CommandText = q;
            dt = new DataTable();
            da.Fill(dt);
            return dt;

            int x;
        }

        public void cmdtext(string q)
        {
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
        }
    }
}
