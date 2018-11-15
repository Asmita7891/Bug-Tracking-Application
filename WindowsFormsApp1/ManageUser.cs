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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public DataTable Select_user()
        {
            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtrack");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from userdetails", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // Data Grid View
            ManageUser vu = new ManageUser();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }
        public DataTable Search(string keyword)
        {


            //connecting to the database
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtrack");
            //getting data from database using dataadapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM userdetails WHERE username LIKE '%" + keyword + "%'", conn);
            //to hold data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//it means the fill in our database
            return dt;

        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from textbox 
            string keyword = text_search.Text;
            ManageUser vu1 = new ManageUser();
            //check if keywords have value or not
            if (keyword != null)
            {
                //show user based based on keywords

                DataTable dt = vu1.Search(keyword);
                dataGridView1.DataSource = dt;

            }
            else
            {
                //show all user from database
                DataTable dt = vu1.Select_user();
                dataGridView1.DataSource = dt;
            }
        }

   

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // Data Grid View
            ManageUser vu = new ManageUser();
            DataTable dt = vu.Select_user();
            dataGridView1.DataSource = dt;
        }
    }
}
