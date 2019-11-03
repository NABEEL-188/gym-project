using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.cs;

namespace GYM
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }



        string gender;
        private void tbReg_Click(object sender, EventArgs e)
        {
            Registration_Operation TR = new Registration_Operation();
            
            TR.R_name = tbName.Text;

            if (rbMale.Checked == true)
            {
                gender = "Male";
            }
            if (rbFemale.Checked == true)
            {
                gender = "Female";
            }
            TR.R_gender = gender;

            TR.R_dob = Convert.ToDateTime(dtpDOB.Value.ToShortDateString());
            TR.R_address = tbAdrs.Text;
            TR.R_Level = cbLevel.Text;
            TR.R_utype = cmbType.Text;
            TR.R_username = tbUname.Text;
            TR.R_password = tbPass.Text;

            int rows = TR.insertREg();
            if (rows > 0)
            {
                MessageBox.Show("Data Saved Successfully");
            }
            this.Hide();
        }
    }
}
