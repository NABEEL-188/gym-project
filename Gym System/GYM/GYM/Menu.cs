using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Addmission mem = new Addmission();
            mem.TopLevel = false;
            mainpanel.Controls.Add(mem);
            mem.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            FeesRec fr = new FeesRec();
            fr.TopLevel = false;
            mainpanel.Controls.Add(fr);
            fr.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Product pro = new Product();
            pro.TopLevel = false;
            mainpanel.Controls.Add(pro);
            pro.Show();
        }

        private void User_Account_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            CreateAccount ca = new CreateAccount();
            ca.TopLevel = false;
            mainpanel.Controls.Add(ca);
            ca.Show();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
