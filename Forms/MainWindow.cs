using System;
using System.Net;
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
using _1271713_ADO.NetCCProjectByNewaz.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace _1271713_ADO.NetCCProjectByNewaz
{
    public partial class MainWindow : Form
    {
        

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public static string cstid;
        public static string pamm;
        public MainWindow()
        {
            InitializeComponent();
            string myconnection = ConfigurationManager.ConnectionStrings["newazConn"].ConnectionString;
            conn = new SqlConnection(myconnection);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newazProjectDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.newazProjectDBDataSet.Customer);
            // TODO: This line of code loads data into the 'newazProjectDBDataSet.Bikes' table. You can move, or remove it, as needed.


            FillData();

        }

        private void datView()
        {
            
            string query = "SELECT CustID, Name, Address, Image FROM Customer where UserName='"+Login.usr+"'";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtCustId.Text = dr["CustID"].ToString();
                txtCustName.Text = dr["Name"].ToString();
                txtCustAdd.Text = dr["Address"].ToString();
            }


            dataGridView1.DataSource = dt;


        }


        private void MainWindow_Activated(object sender, EventArgs e)
        {
            datView();
        }


        private Image GetImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return System.Drawing.Image.FromStream(ms);
        }
        public void FillData()
        {
            conn.Open();
            cmd = new SqlCommand("Select * From Bikes",conn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                bikeList.Items.Add(dr["BikeName"].ToString());
            }
            conn.Close();

        }

        private void bikeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select * From Bikes Where BikeName='" + bikeList.SelectedItem.ToString() + "'", conn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBikeId.Text = dr["BikeId"].ToString();
                txtBikeName.Text = dr["BikeName"].ToString();
                txtBikePrice.Text = dr["BikePrice"].ToString();
                picbikeshow.Image = GetImage((byte[])dr["BikeImage"]);

            }
            conn.Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete Account")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["custIdDataGridViewTextBoxColumn"].Value);
                MessageBox.Show("Are sure about Delete??");

                try
                {
                    conn.Open();
                    cmd = new SqlCommand("DeleteCustomer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CustId", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfull");
                    this.Close();
                    new Login().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                int id; string name, address;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["custIdDataGridViewTextBoxColumn"].Value);
                name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nameDataGridViewTextBoxColumn"].Value);
                address = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value);




                UserUpdate userupdate = new UserUpdate(id, name, address);
                userupdate.ShowDialog();
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void txtBikePrice_TextChanged(object sender, EventArgs e)
        {
            payableAmmount();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            payableAmmount();
        }
        private void payableAmmount()
        {
            double num1, num2, result;

            if (double.TryParse(txtBikePrice.Text, out num1))
            {
                num2 = (double)numericUpDown1.Value;

                result = num1 * num2;

                txtPayAmount.Text = result.ToString();
            }
            else
            {
                txtPayAmount.Text = "";
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtBikeId.Text == "" && numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please select bike and quantity!");
            }
            else
            {
                cstid = txtCustId.Text;
                pamm = txtPayAmount.Text;

                conn.Open();
                cmd = new SqlCommand("INSERT INTO Orders VALUES(@custid,@bikeid,GETDATE(),@qntt)",conn);

                cmd.Parameters.AddWithValue("@custid", txtCustId.Text);
                cmd.Parameters.AddWithValue("@bikeid", txtBikeId.Text);
                cmd.Parameters.AddWithValue("@qntt", numericUpDown1.Value);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Order request placed. Please Confirm Payment!");
                new Payment().ShowDialog();

                
            }
        }
       
        
    }
}
