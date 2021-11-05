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
            string queryInsert = "INSERT INTO NoiDungTour VALUES (@MaDoan,@HanhTrinh,@KhachSan,@DiaDiemThamQuan)";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(queryInsert, connection);
                command.Parameters.AddWithValue("MaDoan",txtMaDoan.Text);
                command.Parameters.AddWithValue("HanhTrinh", txtHanhTrinh.Text);
                command.Parameters.AddWithValue("KhachSan", txtKhachSan.Text);
                command.Parameters.AddWithValue("DiaDiemThamQuan", txtDiaDiem.Text);
                command.ExecuteNonQuery();

                // load lại form
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = GetAllNhanVien().Tables[0];

                connection.Close();
            }
            

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

                SqlCommand command = new SqlCommand(query, connection);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllNhanVien().Tables[0];
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE NoiDungTour SET HanhTrinh = @HanhTrinh, KhachSan = @KhachSan, DiaDiemThamQuan = @DiaDiemThamQuan WHERE MaDoan = @MaDoan "; 
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(queryUpdate, connection);
                command.Parameters.AddWithValue("MaDoan", txtMaDoan.Text);
                command.Parameters.AddWithValue("HanhTrinh", txtHanhTrinh.Text);
                command.Parameters.AddWithValue("KhachSan", txtKhachSan.Text);
                command.Parameters.AddWithValue("DiaDiemThamQuan", txtDiaDiem.Text);
                command.ExecuteNonQuery();

                // load lại form
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = GetAllNhanVien().Tables[0];

                connection.Close();
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE FROM NoiDungTour WHERE MaDoan = @MaDoan ";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(queryDelete, connection);
                command.Parameters.AddWithValue("MaDoan", txtMaDoan.Text);
                command.Parameters.AddWithValue("HanhTrinh", txtHanhTrinh.Text);
                command.Parameters.AddWithValue("KhachSan", txtKhachSan.Text);
                command.Parameters.AddWithValue("DiaDiemThamQuan", txtDiaDiem.Text);
                command.ExecuteNonQuery();

                // load lại form
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = GetAllNhanVien().Tables[0];

                connection.Close();
            }
        }
    }
}
