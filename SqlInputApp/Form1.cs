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
using System.IO;

namespace SqlInputApp
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private SqlConnection connection;
        private byte[] image;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectBt_Click(object sender, EventArgs e)
        {
            connectionString = ConnectionStringTb.Text.Trim();
            
            if (connectionString == "")
            {
                MessageBox.Show("Connection string không được để trống");
            }
            else
            {
               connection = new SqlConnection(connectionString);
            }

        }

        private void ImageChooseBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pictureBox.Image = Image.FromFile(fileDialog.FileName);
            image = (byte[])(new ImageConverter()).ConvertTo(pictureBox.Image , typeof(byte[]));
        }

        private void addStudentBt_Click(object sender, EventArgs e)
        {
            string str = "insert into **** Value  " + image;
            SqlCommand command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
        }

        private Image byteArrayToIMage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image i = Image.FromStream(ms);
            return i;
        }
    }
}
