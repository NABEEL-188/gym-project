using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.cs;
using System.Windows.Forms;

namespace GYM
{
    public partial class Addmission : Form
    {
        public Addmission()
        {
            InitializeComponent();
        }
        addmission_property adds = new addmission_property();
        
      
        private void insert_Click(object sender, EventArgs e)
        {

            adds.insertaddmiss(name.Text, cb_gender.Text, Convert.ToInt32(height.Text), Convert.ToInt32(weight.Text), Convert.ToInt32(contact.Text), Convert.ToInt32(batch.Text), workout.Text, Convert.ToInt32(cb_FeesMode.Text),cb_Instructor.Text);
            
           
            

            try
            {
                MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            name.Text="";
            cb_gender.Text = "";
            
            height.Text="";
            weight.Text="";
            contact.Text="";
            batch.Text="";
            workout.Text="";
            cb_FeesMode.Text = "";
            cb_Instructor.Text="";
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            adds.deleteaddmis(Convert.ToInt32(Id.Text));
            MessageBox.Show("Data delete Successfully");
        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = adds.ShowAllmemData();
            dGv_datashow.DataSource = dt;
        }

        private void cb_FeesMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cb_FeesMode.Text) == 2000)
            {
                Instructor_Label.Visible = true;
                cb_Instructor.Visible = true;
            }
            else
            {
                Instructor_Label.Visible = false;
                cb_Instructor.Visible = false;
            }
        }

        private void cb_Instructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Addmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_Management_SystemDataSet.addmember' table. You can move, or remove it, as needed.
            this.addmemberTableAdapter.Fill(this.gym_Management_SystemDataSet.addmember);
          
        }

        private void update_Click(object sender, EventArgs e)
        {
             adds.insertaddmiss(name.Text, cb_gender.Text, Convert.ToInt32(height.Text), Convert.ToInt32(weight.Text), Convert.ToInt32(contact.Text), Convert.ToInt32(batch.Text), workout.Text, Convert.ToInt32(cb_FeesMode.Text),cb_Instructor.Text);
            
           
            

            try
            {
                MessageBox.Show("Data Update Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Id.Text = "";
            name.Text="";
            cb_gender.Text = "";
            
            height.Text="";
            weight.Text="";
            contact.Text="";
            batch.Text="";
            workout.Text="";
            cb_FeesMode.Text = "";
            cb_Instructor.Text="";
        }

        private void dGv_datashow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id.Text = dGv_datashow.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dGv_datashow.SelectedRows[0].Cells[1].Value.ToString();
            cb_gender.Text = dGv_datashow.SelectedRows[0].Cells[2].Value.ToString();
            height.Text = dGv_datashow.SelectedRows[0].Cells[3].Value.ToString();
            weight.Text = dGv_datashow.SelectedRows[0].Cells[4].Value.ToString();
            contact.Text = dGv_datashow.SelectedRows[0].Cells[5].Value.ToString();
            batch.Text = dGv_datashow.SelectedRows[0].Cells[6].Value.ToString();
            workout.Text = dGv_datashow.SelectedRows[0].Cells[7].Value.ToString();
            cb_FeesMode.Text = dGv_datashow.SelectedRows[0].Cells[8].Value.ToString();
            cb_Instructor.Text = dGv_datashow.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             dt = adds.searchaddmis(Convert.ToInt32(Id.Text));
            MessageBox.Show("SEARCHING....");
            dGv_datashow.DataSource = dt;
        }
    }
}
 