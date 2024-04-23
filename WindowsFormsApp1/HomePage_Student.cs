using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_BUS; 

namespace QuestionBank_GUI
{
    public partial class HomePage_Student : Form
    {
        private HomePage_Student_BUS HomePage_Student_BUS;
        public HomePage_Student()
        {
            InitializeComponent();
            HomePage_Student_BUS = new HomePage_Student_BUS();
        }

        private void tabPageExamRules_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Gọi phương thức từ lớp BUS để lấy dữ liệu lịch thi
                DataTable examSchedule = HomePage_Student_BUS.getLichThi();

                // Hiển thị dữ liệu lịch thi trên tabPageExamRules
                ShowExamSchedule(examSchedule);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                Console.WriteLine("Lỗi: " + ex.Message);
                // Hoặc hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu lịch thi.");
            }
        }

        // Phương thức hiển thị dữ liệu lịch thi lên tabPageExamRules
        private void ShowExamSchedule(DataTable examSchedule)
        {
            // Xóa bỏ dữ liệu cũ (nếu có)
            tabPageExamRules.Controls.Clear();

            // Tạo một DataGridView để hiển thị dữ liệu lịch thi
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = examSchedule;

            // Thêm DataGridView vào tabPageExamRules
            tabPageExamRules.Controls.Add(dataGridView);
            dataGridView.Dock = DockStyle.Fill;
        }

    }
}
