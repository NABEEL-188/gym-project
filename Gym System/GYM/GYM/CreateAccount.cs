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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        Registration_Operation TR = new Registration_Operation();

        private void Rregisteredbtn_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_Management_SystemDataSet.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.gym_Management_SystemDataSet.Registration);

        }

        private void search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TR.VeiwRecord();
            dgVAccount.DataSource = dt;
        }
    }
}
