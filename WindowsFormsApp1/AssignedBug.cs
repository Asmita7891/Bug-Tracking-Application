﻿using MySql.Data.MySqlClient;
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
    public partial class AssignedBug : Form
    {
        public AssignedBug()
        {
            InitializeComponent();
        }
        public DataTable SelectBug()
        {
            //Database connection
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = bugtrack");
            //Getting data from database using DataAdapter 
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from bugreport where assignedto='" + Form1.uname + "'", conn);
            //Holding data from database
            DataTable dt = new DataTable();
            sda.Fill(dt);//It means to fill in our database
            return dt;
        }

        private void AssignedBug_Load(object sender, EventArgs e)
        {
            // Data Grid View
            AssignedBug ab = new AssignedBug();
            DataTable dt = ab.SelectBug();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
 
    }
}
