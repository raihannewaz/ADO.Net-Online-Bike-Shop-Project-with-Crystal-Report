using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace _1271713_ADO.NetCCProjectByNewaz.Forms
{
    public partial class UserUpdate : Form
    {

        int uid; string uname, uaddress;
        SqlConnection conn;
        SqlCommand cmd;


        public UserUpdate(int id, string name, string address)
        {
            InitializeComponent();
            string myconnection = ConfigurationManager.ConnectionStrings["newazConn"].ConnectionString;
            conn = new SqlConnection(myconnection);

            this.uid = id;
            this.uname = name;
            this.uaddress = address;


        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
            txtId.Text = uid.ToString();
            txtName.Text = uname.ToString();
            txtAddress.Text = uaddress.ToString();

        }

        private byte[] getimage()
        {
            MemoryStream stream = new MemoryStream();
            picbox.Image.Save(stream, picbox.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string imagePath = open.FileName;
                picbox.Image = new Bitmap(imagePath);
                txtimage.Text = imagePath;

                string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                string fname = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, path + "\\Images\\" + fname);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uid = Convert.ToInt32(txtId.Text);


            conn.Open();
            try
            {
                cmd = new SqlCommand("UpdateCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustId", uid);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address",txtAddress.Text);
                cmd.Parameters.AddWithValue("@Image", getimage());
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
