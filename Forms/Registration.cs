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
using System.Configuration;

namespace _1271713_ADO.NetCCProjectByNewaz
{
    public partial class Registration : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string gender;
        public Registration()
        {
            InitializeComponent();

            string myconnection = ConfigurationManager.ConnectionStrings["newazConn"].ConnectionString;
            conn = new SqlConnection(myconnection);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
                if (txtName.Text == "" && txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "" && bdate.Text == "" && txtAddress.Text == "")
                {
                    MessageBox.Show("All information is required!! Try Again");
                }
                else if (txtPassword.Text == txtConPassword.Text)
                {
                    conn.Open();
                //cmd = new SqlCommand("INSERT INTO Customer Values (@name, @username, @pass, @bdate, @gender, @address)", conn);
                cmd = new SqlCommand("InsertCustomer",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", bdate.Value);

                    if (rdMale.Checked == true)
                    {
                        gender = "Male";
                    }
                    else if(rdFemale.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Select gender");
                    }
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Registration Successful");

                }
                else
                {
                    MessageBox.Show("Password not matched!!");
                    txtPassword.Text = "";
                    txtConPassword.Text = "";
                    txtPassword.Focus();
                }
        }



        private void bdate_ValueChanged_1(object sender, EventArgs e)
        {
            bdate.CustomFormat = "yyyy/MM/dd";
        }

        private void bdate_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                bdate.CustomFormat = "";
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void chkboxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }
    }
}
