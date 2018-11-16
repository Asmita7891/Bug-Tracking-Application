using MySql.Data.MySqlClient;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //string username = Form1.uname;
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtrack");

            DataTable dt = new DataTable();
            MySqlCommand sdaa = new MySqlCommand("Select * from userdetails where username='" + Form1.uname + "'", conn);
            MySqlDataReader myreader;
            conn.Open();
            myreader = sdaa.ExecuteReader();
            while (myreader.Read())
            {
                string sid = myreader.GetInt32("id").ToString();
                          
            }

        }

        private void button_reg_Click(object sender, EventArgs e)
        {

            string oldpwd = txt_oldpwd.Text;
            string newpwd = txt_newPwd.Text;
            //connecting to the database
            string pas = Form1.userpasswor;
            string type = Form1.usertype;
           
            if (pas.Equals(txt_oldpwd.Text))
            {
                MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtrack");
                // MessageBox.Show("password matched");
                MySqlCommand sda = new MySqlCommand("update userdetails set password='" + this.txt_newPwd.Text + "', confirmPassword='" + this.txt_newPwd.Text + "' where username='" + Form1.uname+"'", conn);
                //Open Connection
               conn.Open();
                int rows = sda.ExecuteNonQuery();

                //if Inserted rows is greater is greater than 0
                //Else set isSuccess to false, Save Failed


                if (rows > 0)
                {
                    MessageBox.Show("Password changed. Please click ok to continue");
                    //going to dashboard page
                    if (type=="user")
                    {
                        userPanel dash = new userPanel();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        ProgrammerPanel pdash = new ProgrammerPanel();
                        pdash.Show();
                        this.Hide();
                    }
                 
                }
                else
                {
                    MessageBox.Show("Password failed to changed. click ok to continue");

                }

            }
            else
            {
                MessageBox.Show("Old password didnot mathed");
            }
        }

    }
}
