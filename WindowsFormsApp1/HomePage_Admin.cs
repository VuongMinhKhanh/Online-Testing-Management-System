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
    public partial class HomePage_Admin : Form
    {
        private HomePage_Admin_BUS HomePage_Admin_BUS;
        public HomePage_Admin()
        {
            InitializeComponent();
            HomePage_Admin_BUS = new HomePage_Admin_BUS();
        }

        private void tabPageInvigilators_Enter(object sender, EventArgs e)
        {
            DataTable danhSachGiamThi = HomePage_Admin_BUS.getDachSachGiamThi();
            // Hiển thị danh sách giám thị lên giao diện
            dataGridViewInvigilators.DataSource = danhSachGiamThi;
        }
        private void tabPageSchedule_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin lịch thi
            DataTable lichThi = HomePage_Admin_BUS.getLichThi();

            // Hiển thị thông tin lịch thi lên giao diện
            dataGridViewSchedule.DataSource = lichThi; // Sửa tên dataGridView tương ứng
        }

        private void tabPageExams_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đề thi
            DataTable deThi = HomePage_Admin_BUS.getDanhSachDeThi();

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

        // còn báo cáo thông kê ch xong
    }
}
