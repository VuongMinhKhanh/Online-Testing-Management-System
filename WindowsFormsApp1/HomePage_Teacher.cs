using System;
using System.Data;
using System.Windows.Forms;
using QuestionBank_BUS;

namespace QuestionBank_GUI
{
    public partial class HomePage_Teacher : Form
    {
        private HomePage_Teacher_BUS homePage_Teacher_BUS;

        public HomePage_Teacher()
        {
            InitializeComponent();
            homePage_Teacher_BUS = new HomePage_Teacher_BUS();
        }

        // Xử lý sự kiện khi tab "Lịch thi" được chọn
        private void tabPageSchedule_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin lịch thi
            DataTable lichThi = homePage_Teacher_BUS.getLichThi();

            // Hiển thị thông tin lịch thi lên giao diện
            dataGridViewSchedule.DataSource = lichThi; // Sửa tên dataGridView tương ứng
        }

        // Xử lý sự kiện khi tab "Đề thi" được chọn
      
        private void tabPageExams_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đề thi
            DataTable deThi = homePage_Teacher_BUS.getDeThi();

            // Hiển thị thông tin đề thi lên giao diện
            listViewExams.Items.Clear();
            foreach (DataRow row in deThi.Rows)
            {
                string[] rowData = new string[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    rowData[i] = row.ItemArray[i].ToString();
                }
                listViewExams.Items.Add(new ListViewItem(rowData));
            }
        }

        // Xử lý sự kiện khi tab "Đăng kí giám thị" được chọn
        private void tabPageInvigilatorRegistration_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đăng kí giám thị
            DataTable dangKiGiamThi = homePage_Teacher_BUS.DangKiGiamThi();

            // Hiển thị thông tin đăng kí giám thị lên giao diện
            dataGridViewInvigilatorRegistration.DataSource = dangKiGiamThi; // Sửa tên dataGridView tương ứng
        }
    }
}
