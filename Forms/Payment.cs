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


namespace _1271713_ADO.NetCCProjectByNewaz.Forms
{
    public partial class Payment : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Payment()
        {
            InitializeComponent();
            string myconnection = ConfigurationManager.ConnectionStrings["newazConn"].ConnectionString;
            conn = new SqlConnection(myconnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboPay.SelectedItem.ToString() != "")
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT TOP 1 OrderId FROM Orders WHERE CustID = @cstid ORDER BY OrderDate DESC", conn);
                    cmd.Parameters.AddWithValue("@cstid", MainWindow.cstid);
                    int orderid = (int)cmd.ExecuteScalar();


                    cmd = new SqlCommand("INSERT INTO Payments VALUES(@orid,@custid,@pamount,GETDATE(),@pmethod)", conn);

                    cmd.Parameters.AddWithValue("@orid", orderid);
                    cmd.Parameters.AddWithValue("@custid", MainWindow.cstid);
                    cmd.Parameters.AddWithValue("@pamount", MainWindow.pamm);
                    cmd.Parameters.AddWithValue("@pmethod", comboPay.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Payment Successfull!!");
                    this.Close();
                    new Print().ShowDialog();

                }
                else
                {
                    MessageBox.Show("Please select payment method");
                }
            }
            finally 
            {
                conn.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
