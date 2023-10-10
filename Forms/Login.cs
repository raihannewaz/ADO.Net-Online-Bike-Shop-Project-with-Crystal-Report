using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1271713_ADO.NetCCProjectByNewaz
{
    public partial class Login : Form
    {
        public static string usr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Login()
        {
            InitializeComponent();
            string myconnection = ConfigurationManager.ConnectionStrings["newazConn"].ConnectionString;
            conn = new SqlConnection(myconnection);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            usr = txtUsername.Text;
            conn.Open();
            string loginQuery = "SELECT * FROM Customer WHERE Username=@username and Password=@pass";
            cmd = new SqlCommand(loginQuery, conn);
            cmd.Parameters.AddWithValue("@username", usr);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            rdr = cmd.ExecuteReader();

            if (rdr.Read() == true)
            {
                //dataTable.Load(rdr);
                //DataRow userRow = dataTable.Rows[0];
                //LoggedInUser.UserName = userRow["UserName"].ToString();

                this.Hide();
                new MainWindow().Show();
                
                conn.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                conn.Close();
            }
            
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void chkboxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
    //public class LoggedInUser
    //{
    //    public static string UserName { get; set; }
    //}
}
