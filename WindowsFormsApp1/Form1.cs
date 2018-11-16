using MySql.Data.MySqlClient;
using System;
 
using System.Data;
using System.Data.SqlClient;
 
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string uname,userpasswor, usertype;
        public static int uid;

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = textBox_user.Text;//username
            string pass = textBox_pwd.Text;//password
            string uType = comboBox_utype.Text.Trim();//usertype

            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=bugtrack");

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select count(*) from userdetails where username='" + textBox_user.Text + "'and password='" + textBox_pwd.Text + "' and usertype='" + comboBox_utype.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);//

                if (user.Equals(null) || pass.Equals(null) || uType.Equals(null))
                {

                    MessageBox.Show("U must Fill all the forms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        // loggedIn = user;
                        // loggedIN_utype = uType;
                        userpasswor = pass;
                        uname = user;

                        usertype = uType;
                        switch (uType)
                        {
                            case "admin":
                                {

                                    // Admin Panel
                                     //  loggedIN_utype = uType;
                                    adminPanel admin = new adminPanel();
                                    MessageBox.Show("Login was succesful.");
                                    admin.Show();
                                    this.Hide();

                                    break;

                                }
                                //user
                            case "user":
                                {

                                    //Display User Dashboard
                                     userPanel umenu = new userPanel();
                                    MessageBox.Show("Login was succesful.");
                                    umenu.Show();
                                    this.Hide();
                                    break;
                                }
                            case "programmer":
                                {
                                    //Display programmer Dashboard
                                     ProgrammerPanel pmenu = new ProgrammerPanel();
                                    MessageBox.Show("Login was succesful.");
                                    pmenu.Show();
                                    this.Hide();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step :CLose Connection
                conn.Close();
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}


