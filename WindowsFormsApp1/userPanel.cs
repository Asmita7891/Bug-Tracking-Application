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
    public partial class userPanel : Form
    {
        public userPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void userPanel_Load(object sender, EventArgs e)
        {

        }

        private void button_bugreport_Click(object sender, EventArgs e)
        {
            Bug b = new Bug();
            b.Show();

        }

        private void button_changePwd_Click(object sender, EventArgs e)
        {
            ChangePassword cha = new ChangePassword();
            cha.Show();
  
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
