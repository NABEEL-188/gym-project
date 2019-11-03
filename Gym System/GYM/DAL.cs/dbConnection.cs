using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.cs
{
    public class dbConnection
    {
       
        static SqlConnection con = new SqlConnection("Data Source=NABEEL;Initial Catalog=Gym_Management_System;Integrated Security=True");
        
        
        
        public static void executeQuery(string Query,SqlParameter [] prm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}
