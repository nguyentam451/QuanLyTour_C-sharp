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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllNhanVien().Tables[0];
        }

        DataSet GetAllNhanVien()
        {
            DataSet data = new DataSet();
            // kết nối database
            // sql connection
            // xài using để xài xong sẽ đóng connection
           
            string query = "select * from NoiDungTour";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query,connection);
             //   command.Parameters.AddWithValue("@manhanvien",MaNhanVien)

                //tạo adapter
                //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // đổ data lấy về vào trong dataset
                adapter.Fill(data);

                connection.Close();
            }
                return data;
        }
    }
}
