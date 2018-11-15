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
    public partial class ProgrammerPanel : Form
    {
        public ProgrammerPanel()
        {
            InitializeComponent();
        }

        private void button_lgout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btn_changepwd_Click(object sender, EventArgs e)
        {

            ChangePassword cha = new ChangePassword();
            cha.Show();

        }

        private void button_bugsol_Click(object sender, EventArgs e)
        {
            AddBugSolution abs = new AddBugSolution();
            abs.Show(); 
        }

        private void button_assign_Click(object sender, EventArgs e)
        {
            AssignedBug abug = new AssignedBug();
            abug.Show();
        }
    }
}
