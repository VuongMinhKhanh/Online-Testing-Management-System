using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuestionBank_GUI
{
    public partial class StudentScheduleForm : Form
    {
        public StudentScheduleForm()
        {
            InitializeComponent();
        }
        public static int studentID=1;
        //Ngày thông báo
        int DiffDay = 100;

        void LoadSemeterToComboBox(int studentID)
        {
            try
            {
                cbHocKy.DataSource = Semeter.getAllSemeter(studentID);
                cbHocKy.DisplayMember = "id_HocKy";
                cbHocKy.ValueMember = "id_HocKy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Lấy dữ liệu đổ ra notice
        private SqlDataReader LoadNotice(SqlConnection connection)
        {
                string query = "select LichThi.*,ten_mon_hoc,DATEDIFF(DAY, GETDATE(), LichThi.ngay_thi) as ngay_chenh_lech,trang_thai " +
                    "from SinhVien_DangKyMon " +
                    "left join LopHoc_MonHoc on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc " +
                    "join LichThi on LichThi.id_LopHoc_MonHoc = SinhVien_DangKyMon.id_Lop_MonHoc " +
                    "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                    "where SinhVien_DangKyMon.mssv = @mssv and trang_thai like N'Học' and DATEDIFF(DAY, GETDATE(), LichThi.ngay_thi) >0";
                // Mở kết nối
                // Tạo một đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@mssv", studentID);
                return sqlCommand.ExecuteReader();
        }

        //load Thông báo
        bool HasNotice(int KhoangCachNgayThongBao)
        {
            int count = 0;
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlDataReader reader = LoadNotice(connection))
                {
                    if (reader.HasRows)
                    {
                        //lấy vị trí cột ngày chênh lệch
                        int column_ngay_chenh_lech = reader.GetOrdinal("ngay_chenh_lech");
                        // Đọc từng dòng dữ liệu
                        while (reader.Read())
                        {
                            // Lấy giá trị từ cột column_name và thêm vào danh sách
                            // Chỉ số 0 là chỉ số của cột
                            if (reader.GetInt32(column_ngay_chenh_lech) <= KhoangCachNgayThongBao)
                                count++;
                        }
                    }
                }
            }    
                if (count > 0)
                {
                    btNotice.Text = btNotice.Text.Remove(btNotice.Text.Length - 1);
                    btNotice.Text += count.ToString();
                    btNotice.ImageIndex = 1;
                    return true;
                }
                else
                    return false;

            
        }
        void LoadStatusButton()
        {
            // Kiểm tra xem DataGridView có cột button chưa
            if (dataGridViewSchedule.Columns["Trạng thái"] == null)
            {
                // Tạo một DataGridViewButtonColumn mới
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Trạng thái";
                buttonColumn.Text = "Vào thi";
                buttonColumn.UseColumnTextForButtonValue = true;
                // Thêm cột vào cuối DataGridView
                dataGridViewSchedule.Columns.Add(buttonColumn);
            }
            else
            {
                dataGridViewSchedule.Columns.Remove("Trạng thái");
                // Tạo một DataGridViewButtonColumn mới
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Trạng thái";
                buttonColumn.Text = "Vào thi";
                buttonColumn.UseColumnTextForButtonValue = true;
                // Thêm cột vào cuối DataGridView
                dataGridViewSchedule.Columns.Add(buttonColumn);
            }
        }
        void LoadStudentSchedule(int studentID)
        {
            try
            {
                LoadSemeterToComboBox(studentID);
                dataGridViewSchedule.DataSource = Schedule.getAllSchedule(studentID);
                LoadStatusButton();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void StudentScheduleForm_Load(object sender, EventArgs e)
        {
            LoadStudentSchedule(studentID);
            if(HasNotice(DiffDay))
            txtMaLop.TextChanged += Find;
            txtMaMon.TextChanged += Find;
            cbHocKy.SelectedIndexChanged += Find;
        }

        private void Find(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string hocKy = cbHocKy.Text;
            string[] arr = hocKy.Split('-');
            int namHoc = int.Parse(arr[1]);
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            if (checkBoxHocKy.Checked || checkBoxMaLop.Checked || checkBoxMaMon.Checked)
                using (SqlConnection sqlConnection = Connection.GetConnection())
                {
                    sqlConnection.Open();
                    string query = "select id_LichThi as N'ID lịch thi',ngay_thi as N'Ngày thi',CaThi.gio_bat_dau as N'Giờ bắt đầu',thoi_gian_thi as N'Thời gian thi',LopHoc_MonHoc.id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn' from SinhVien_DangKyMon left join LopHoc_MonHoc on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc join LichThi on LichThi.id_LopHoc_MonHoc= LopHoc_MonHoc.id_LopHoc_MonHoc join CaThi on CaThi.id_CaThi=LichThi.id_CaThi where SinhVien_DangKyMon.mssv = @mssv";
                    switch (arr[0])
                        {
                            case "HK1":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) >= 11 OR DATEPART(month, ngay_thi) <= 2)";
                                break;
                            case "HK2":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) > 2 and DATEPART(month, ngay_thi) <= 6)";
                                break;
                            case "HK3":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) > 6 and DATEPART(month, ngay_thi) <= 10)";
                                break;
                        }
                    if (checkBoxMaLop.Checked) query += " and LopHoc_MonHoc.id_LopHoc like @maLop";
                    if (checkBoxMaMon.Checked) query += " and LopHoc_MonHoc.id_MonHoc like @maMon";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    if (checkBoxMaLop.Checked) sqlCommand.Parameters.AddWithValue("@maLop", "%" + maLop + "%");
                    if (checkBoxMaMon.Checked) sqlCommand.Parameters.AddWithValue("@maMon", "%" + maMon + "%");
                    if (checkBoxHocKy.Checked) sqlCommand.Parameters.AddWithValue("@namHoc", namHoc);
                    sqlCommand.Parameters.AddWithValue("@mssv", studentID);
                    dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dataTable);
                    dataGridViewSchedule.DataSource = dataTable;
                    dataGridViewSchedule.Columns[0].DisplayIndex = dataGridViewSchedule.Columns.Count - 1;
                }
        }
        //hover lên label trong subtitle
        void lbNotification_MouseEnter(object sender, EventArgs e)
        {
            Label lbNotification = (Label)sender;
            lbNotification.BackColor = Color.LightBlue;
            // Tạo một Richtexbox mới
            RichTextBox rtbDetail = new RichTextBox();
            rtbDetail.Name = "rtbDetail";
            rtbDetail.BackColor = Color.LightGray;
            rtbDetail.Enabled = true;
            rtbDetail.Font = lbNotification.Font;
            rtbDetail.Size = new Size(250, 100); // Thiết lập kích thước của FlowLayoutPanel
            rtbDetail.Location = new Point(lbNotification.Location.X+lbNotification.Width+3, (flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height + 3)+lbNotification.Location.Y); // Đặt vị trí của FlowLayoutPanel
            this.Controls.Add(rtbDetail); // Thêm FlowLayoutPanel vào Form hoặc container tương ứng
            this.Controls.SetChildIndex(rtbDetail, this.Controls.Count + 1);
            rtbDetail.BringToFront();
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                int lichThiID = int.Parse(lbNotification.Tag.ToString());
                sqlConnection.Open();
                using (SqlDataReader reader = Schedule.getScheduleByID(lichThiID,sqlConnection))
                {
                    if(reader.HasRows)
                    {
                        //CaThi.gio_bat_dau as N'Giờ bắt đầu',thoi_gian_thi as N'Thời gian thi',id_Lop as N'Mã lớp', LichThi.id_MonHoc as N'Mã môn'//
                        int column_ngay_thi = reader.GetOrdinal("Ngày thi");
                        int column_gio_bat_dau = reader.GetOrdinal("Giờ bắt đầu");
                        int column_thoi_gian_thi = reader.GetOrdinal("Thời gian thi");
                        int column_id_Lop = reader.GetOrdinal("Mã lớp");
                        int column_id_MonHoc = reader.GetOrdinal("Mã môn");
                        while (reader.Read())
                        {
                            rtbDetail.Text = "Mã lớp: "+reader.GetString(column_id_Lop)+"\n"+
                                             "Mã môn: " + reader.GetString(column_id_MonHoc) + "\n" +
                                             "Giờ bắt đầu: " + reader.GetValue(column_gio_bat_dau).ToString() + "\n" +
                                             "Thời gian thi: " + reader.GetValue(column_thoi_gian_thi).ToString() + "\n" +
                                             "Ngày thi: " +reader.GetDateTime(column_ngay_thi).ToString("dd/MM/yyyy");
                        }    
                    }    
                }    
            }    
        }
        private void lbNotification_MouseLeave(object sender, EventArgs e)
        {
            Label lblNotification = (Label)sender;
            lblNotification.BackColor = Color.DarkGreen;
            Control foundControl = this.Controls.Find("rtbDetail", true).FirstOrDefault();
                this.Controls.Remove(foundControl);
                foundControl.Dispose(); // Giải phóng tài nguyên của control
        }
        //Xử lý sự kiện nhấn nút vào thi
        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSchedule.ColumnCount-1 && e.RowIndex<dataGridViewSchedule.RowCount && dataGridViewSchedule.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DateTime ngay_thi = (DateTime)dataGridViewSchedule.Rows[e.RowIndex].Cells["Ngày thi"].Value;
                DateTime thoi_gian_thi = DateTime.Parse(dataGridViewSchedule.Rows[e.RowIndex].Cells["Thời gian thi"].Value.ToString());
                DateTime gio_bat_dau = DateTime.Parse(dataGridViewSchedule.Rows[e.RowIndex].Cells["Giờ bắt đầu"].Value.ToString());
                // Lấy số phút chênh lệch bằng cách trừ ngày hiện tại cho ngày thi
                TimeSpan difference = ngay_thi.Subtract(DateTime.Now);
                int diffMinutes = (int)difference.TotalMinutes;
                //Nếu bấm vào trước giờ thi
                if (diffMinutes>0)
                // Thực hiện hành động tương ứng khi nút được click
                MessageBox.Show("Chưa đến giờ thi");
                //bấm vào sau giờ thi
                else
                {
                    switch((string)dataGridViewSchedule.Rows[e.RowIndex].Cells["Tình trạng"].Value)
                    {
                        case "Học":
                            int tongThoiGianThi = thoi_gian_thi.Hour * 60 + thoi_gian_thi.Minute;
                            int tongThoiGianHienTai = Math.Abs((DateTime.Now.Hour * 60 + DateTime.Now.Minute) - (gio_bat_dau.Hour * 60 + gio_bat_dau.Minute));
                            int phanTram = tongThoiGianHienTai / tongThoiGianThi * 100;
                            //nếu thời gian vào thi quá 30% thời lượng thi
                            if (phanTram > 30)
                            {
                                MessageBox.Show("Đã quá thời gian được phép thi");
                            }
                            //Vào thi
                            else if (phanTram <= 30)
                            {
                                //Xử lý xự kiện load form thi
                                MessageBox.Show("Vào thi");
                            }
                            break;
                        case "Rớt":
                            MessageBox.Show("Bạn đã rớt môn hoặc bị cấm thi");
                            break;
                        case "Đạt":
                            MessageBox.Show("Bạn đã thi rồi");
                            break;
                    }
                } 
                    
            }
        }

        private void btNotice_Click(object sender, EventArgs e)
        {
            if(HasNotice(DiffDay))
            {
                btNotice.Text = btNotice.Text.Remove(btNotice.Text.Length - 1, 1);
                btNotice.Text = btNotice.Text + " ";
                btNotice.ImageIndex = 0;
                //Tạo label Thông báo
                if(!this.Controls.ContainsKey("flowLayoutPanelContext"))
                {
                    int HEIGHT = 30;
                    int WIDTH = 300;
                    FlowLayoutPanel flowLayoutPanelContext = new FlowLayoutPanel();
                    flowLayoutPanelContext.Location = new Point(panelNotice.Location.X, flowLayoutPanel1.Location.Y + flowLayoutPanel1.Height+3);
                    flowLayoutPanelContext.Width = WIDTH;
                    flowLayoutPanelContext.Height = 150;
                    flowLayoutPanelContext.Name = "flowLayoutPanelContext";
                    flowLayoutPanelContext.BackColor = Color.DarkGreen;
                    flowLayoutPanelContext.Font = new Font("Arial", 10, FontStyle.Regular);
                    flowLayoutPanelContext.ForeColor = Color.White;
                    flowLayoutPanelContext.AutoScroll = true;
                    flowLayoutPanelContext.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(flowLayoutPanelContext);
                    this.Controls.SetChildIndex(flowLayoutPanelContext, this.Controls.Count + 1);
                    flowLayoutPanelContext.BringToFront();
                    //Nạp thông báo vào flowLayoutPanelContext
                    //xử lý hiện Thông báo
                    // Mở kết nối
                    using (SqlConnection connection = Connection.GetConnection())
                    {
                        connection.Open();
                            // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                            using (SqlDataReader reader = LoadNotice(connection))
                            {
                                if(reader.HasRows)
                                {
                                //Lấy vị trí các cột
                                int column_ten_mon_hoc = reader.GetOrdinal("ten_mon_hoc");
                                int column_id_LichThi = reader.GetOrdinal("id_LichThi");
                                int column_ngay_chenh_lech = reader.GetOrdinal("ngay_chenh_lech");
                                // Đọc từng dòng dữ liệu
                                for (int index = 0; reader.Read(); index++)
                                    {
                                        //Thêm label thông báo
                                        Label lbNotification = new Label();
                                        lbNotification.Name = "lbNotification" + index.ToString();
                                        lbNotification.Height = HEIGHT;
                                        lbNotification.Width = WIDTH;
                                        lbNotification.BorderStyle = BorderStyle.Fixed3D;
                                        lbNotification.Font = flowLayoutPanelContext.Font;
                                        lbNotification.Text = reader.GetString(column_ten_mon_hoc) + " sẽ thi vào " + reader.GetInt32(column_ngay_chenh_lech).ToString() + " ngày nữa!";
                                        //truyền Lịch Thi vào tag dùng vào sự kiện mouseEnter
                                        lbNotification.Tag = reader.GetInt32(column_id_LichThi).ToString();
                                        flowLayoutPanelContext.Controls.Add(lbNotification);
                                        lbNotification.MouseEnter += lbNotification_MouseEnter;
                                        lbNotification.MouseLeave += lbNotification_MouseLeave;
                                    }
                            }                                    
                            }
                    }
                }
                else
                {
                    this.Controls.RemoveByKey("flowLayoutPanelContext");
                }
            }      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
