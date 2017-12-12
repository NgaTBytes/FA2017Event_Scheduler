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
using System.Data.Sql;
//using Event_2017FA_CSOS_1320_001;

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
            // user Tamil password Yemen for participant
            // user Swati password China for admin
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
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Tabs f2 = new Tabs();
                ListView f4 = new ListView();
                f2.ShowDialog();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
