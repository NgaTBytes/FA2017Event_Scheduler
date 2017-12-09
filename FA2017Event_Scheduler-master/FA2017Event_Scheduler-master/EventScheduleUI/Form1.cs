using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EventScheduleUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C Programming\Class Project\EventScheduler.mdf;Integrated Security=True;Connect Timeout=30;");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Users where Username ='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'",con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
                this.Hide();
                Tabs f2 = new Tabs();
                ListView f4 = new ListView();
                f2.ShowDialog();
                Environment.Exit(0);
            //}
            //else
            //{
            //    MessageBox.Show("Please Check your Username and Password");
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }//
    }
}
