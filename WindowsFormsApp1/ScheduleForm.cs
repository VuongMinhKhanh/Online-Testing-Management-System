using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuestionBank_GUI
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        public string MaMon = "VD:T103GENG";
        public string TenMonHoc = "VD:Tiếng Anh";
        public string MaLop = "VD:IT2101";
        static public Schedule editSchedule = new Schedule();

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void txtMaMon_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == MaMon || t.Text == MaLop || t.Text == TenMonHoc)
                t.Text = "";
            t.ForeColor = System.Drawing.Color.Black;

        }

        private void txtMaMon_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "")
            {
                t.ForeColor = System.Drawing.Color.DarkGray;
                switch (t.Name)
                {
                    case "txtMaMon":
                        t.Text = MaMon;
                        break;
                    case "txtTenMonHoc":
                        t.Text = TenMonHoc;
                        break;
                    case "txtMaLop":
                        t.Text = MaLop;
                        break;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CreateScheduleForm f = new CreateScheduleForm();
            f.ShowDialog();
            Schedule s = CreateScheduleForm.schedule;
            if (s != null)
            {
                ListViewItem item = new ListViewItem(s.maMon);
                item.SubItems.Add(s.tenMonHoc);
                item.SubItems.Add(s.maLop);
                item.SubItems.Add(s.ngayThi.ToString("dd/MM/yyyy"));
                item.SubItems.Add(s.gioThi);
                listSchedule.Items.Add(item);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listSchedule.SelectedItems)
                listSchedule.Items.Remove(item);

        }

        private void listSchedule_DoubleClick(object sender, EventArgs e)
        {
            //khoi tao gia tri để truyền vào form edit
            ListViewItem item = listSchedule.SelectedItems[0];
            editSchedule.maMon = item.Text;
            editSchedule.tenMonHoc = item.SubItems[1].Text;
            editSchedule.maLop = item.SubItems[2].Text;
            string ngayThi = item.SubItems[3].Text;
            string formatNgayThi = "dd/MM/yyyy";
            editSchedule.ngayThi = DateTime.ParseExact(ngayThi,formatNgayThi,CultureInfo.CurrentCulture);
            editSchedule.gioThi = item.SubItems[4].Text;
            EditScheduleForm f = new EditScheduleForm();
            f.ShowDialog();
            //thay the lịch thi đã chỉnh sửa bằng lịch thi mới
            item.Text = editSchedule.maMon;
            item.SubItems[1].Text = editSchedule.tenMonHoc;
            item.SubItems[2].Text = editSchedule.maLop;
            item.SubItems[3].Text = editSchedule.ngayThi.ToString("dd/MM/yyyy");
            item.SubItems[4].Text = editSchedule.gioThi;
        }
    }
}
