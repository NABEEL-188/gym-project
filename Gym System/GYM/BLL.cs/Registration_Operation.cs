using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL.cs;

namespace BLL.cs
{
    public class Registration_Operation
    {   
        public dbConnection con = new dbConnection();

        public string R_name { get; set; }
        public string R_gender { get; set; }
        public DateTime R_dob { get; set; }
        public string R_address { get; set; }
        public string R_Level { get; set; }
        public string R_username { get; set; }
        public string R_password { get; set; }
        public string R_utype { get; set; }

        public int insertREg()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Registration VALUES ('" + R_name + "','" + R_gender + "','" + R_dob + "','" + R_address + "','" + R_Level + "', '" + R_utype + "' ,'" + R_username + "','" + R_password + "' )";
            return con.ExeNonQuery(cmd);
        }

        public DataTable login()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Registration where Username = '" + R_username + "' and Password = '" + R_password + "'";
            return con.ExeReader(cmd);
        }

        public DataTable VeiwRecord()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration where Type in ('Trainee','Trainer')";
            return con.ExeReader(cmd);
        }
        //public int id { get; set; }
        //public string A_name { get; set; }
        //public string A_gender { get; set; }
        //public int A_height { get; set; }
        //public int A_weight { get; set; }
        //public int A_contact { get; set; }
        //public int A_batch { get; set; }
        //public string A_workout { get; set; }
        //public int A_feesmode { get; set; }

       
        //public int deleteAddmission()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "delete from addmember where '" + A_name + "'";
        //    return con.ExeNonQuery(cmd);
        //}
    }
}
