using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace shop_Management
{
    internal class function
    {
        protected SqlConnection getconnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\C#\\Mobile shop Management\\DB\\db_shop.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;
        }
        public DataSet getdata(string query)        //Extract Data from database
        {
            SqlConnection con=getconnection();
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = con;   
            cmd.CommandText = query;
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }
        public void setdata(string query)            //Insertion, Deletion, updation
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public SqlDataReader getforcombo(string query)
        {
            SqlConnection con=getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;
            con.Open();
            cmd=new SqlCommand(query,con);
            SqlDataReader sdr= cmd.ExecuteReader();
            return sdr;

        }

    }
}
