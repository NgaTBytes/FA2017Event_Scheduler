﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;
//using Event_2017FA_CSOS_1320_001;

namespace EventScheduleUI
{
    public partial class Login : Form
    {
        public string username { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // user Tamil password Yemen for participant
            // user Higgs password Communist for admin  This was dustin's idea - signed everyone else


            // NoT CaSe SeNsItIvE
            SqlConnection connection = new SqlConnection(@"Data Source=cis1.actx.edu;Initial Catalog=Project1;User ID=db1;Password=db10");
            //connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password=db10;";
            //connection.Open();
            //MessageBox.Show(connection.ServerVersion);
            //SqlCommand getLogin = connection.CreateCommand();
            //getLogin.CommandText = "SELECT * FROM Users WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "';";
            //getLogin.CommandText

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Users where Username ='" + txtUsername.Text + "' and Passsword ='" + txtPassword.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //enter username and password
            if (dt.Rows[0][0].ToString() == "1")
            {
                //check username and password 
                SqlDataAdapter sda3 = new SqlDataAdapter("Select Username FROM Users WHERE Username ='" + txtUsername.Text + "' and Passsword ='" + txtPassword.Text + "'", connection);
                DataTable dt1 = new DataTable();
                sda3.Fill(dt1);
                Tabs f2 = new Tabs(dt1.Rows[0][0].ToString());
                username = txtUsername.Text;
                this.Hide();

                SqlDataAdapter sda2 = new SqlDataAdapter("Select Count(*) From Users where Username ='" + txtUsername.Text + "' and Passsword ='" + txtPassword.Text + "' and RoleID = 2", connection);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                //check username to see if it is listed as an admin or participant
                if (dt2.Rows[0][0].ToString() == "1")
                {
                    f2.admin = true;
                }
                //show views on form 2 based on if username and password is admin or participant
                f2.userName = username;
                f2.ShowDialog();
                Environment.Exit(0);

            }
            //If incorrect username and password are entered, show this message to
            //the end
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
        }
        //click the exit button to exit the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
