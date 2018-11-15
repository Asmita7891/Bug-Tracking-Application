using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btn_manageuser_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
        }

        private void btn_managebug_Click(object sender, EventArgs e)
        {
            Bug bg = new Bug();
            bg.Show();
        }

        private void btn_assignbug_Click(object sender, EventArgs e)
        {
            admin_AssignBug aab = new admin_AssignBug();
            aab.Show();

        }

        private void button_fixed_Click(object sender, EventArgs e)
        {
            FixedBug fixbug = new FixedBug();
            fixbug.Show();
        }
    }
}
