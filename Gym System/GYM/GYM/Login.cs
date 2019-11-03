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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string utype;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Registration_Operation TR = new Registration_Operation();
            
            DataTable dt = new DataTable();

            TR.R_username = txtName.Text;
            TR.R_password = txtPass.Text;

            dt = TR.login();
            if (dt.Rows.Count > 0 )
            {
                utype = dt.Rows[0][6].ToString().Trim();
                if (utype == "Trainee")
                {
                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else if (utype == "Trainer")
                {
                    this.Hide();
                    Home_Trainer HT = new Home_Trainer();
                    HT.Show();
                }
                else
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Registration R = new Registration();
            R.Show();
        }
    }
}
