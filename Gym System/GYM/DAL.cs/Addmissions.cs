using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.cs
{
    public class Addmissions
    {
        public dbConnection con = new dbConnection();

        public int insertAddmission(string A_name,string A_gender,int A_height,int A_weight,int A_contact,int A_batch,string A_workout,int A_feesmode,string A_instructor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO addmember VALUES ('" + A_name + "','" + A_gender + "','" + A_height + "','" + A_weight + "','" + A_contact + "', '" + A_batch + "' ,'" + A_workout + "','" + A_feesmode + "' ,'" + A_instructor + "')";
            return con.ExeNonQuery(cmd);
        }
        public int UpdateAddmission(int A_id,string A_name, string A_gender, int A_height, int A_weight, int A_contact, int A_batch, string A_workout, int A_feesmode, string A_instructor)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update addmember set name = '" + A_name + "',gender = '" + A_gender + "',height = '" + A_height + "',weight = '" + A_weight + "',contact = '" + A_contact + "',batch = '" + A_batch + "' ,workout = '" + A_workout + "',feesmode = '" + A_feesmode + "' ,Instructors = '" + A_instructor + "' where id = '"+A_id+"'";
            return con.ExeNonQuery(cmd);
        }

        public int deleteAddmission(int ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from addmember where id = '" + ID + "'";
            return con.ExeNonQuery(cmd);
        }
        public DataTable SearchAddmission(int ID)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from addmember where id = '" + ID + "'";
            return con.ExeReader(cmd);
        }
        
        public DataTable VeiwRecord()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from addmember";
            return con.ExeReader(cmd);
        }
        public DataTable VeiwRecords()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from Registration where Type in ('Trainer')";
            return con.ExeReader(cmd);
        }
    }
}
