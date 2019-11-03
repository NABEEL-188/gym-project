using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL.cs;

namespace BLL.cs
{
    public class addmission_property
    {
        dbConnection con = new dbConnection();
        public Addmissions add = new Addmissions();
        public void insertaddmiss(string A_name,string A_gender,int A_height,int A_weight,int A_contact,int A_batch,string A_workout,int A_feesmode,string A_instructor)
        {
            add.insertAddmission(A_name, A_gender, A_height, A_weight, A_contact, A_batch, A_workout, A_feesmode,A_instructor);
        }

        public void updateaddmiss(int A_id,string A_name, string A_gender, int A_height, int A_weight, int A_contact, int A_batch, string A_workout, int A_feesmode, string A_instructor)
        {
            add.UpdateAddmission (A_id,A_name, A_gender, A_height, A_weight, A_contact, A_batch, A_workout, A_feesmode, A_instructor);
        }
        public void deleteaddmis(int ID)
        {
            add.deleteAddmission(ID);
        }
        public DataTable searchaddmis(int ID)
        {

            return add.SearchAddmission(ID);
        }

        public DataTable ShowAllmemData()
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
            cmd.CommandText = "select * from Registration where Type in ('Trainer') and name";
            return con.ExeReader(cmd);
        }





        
    }
}
