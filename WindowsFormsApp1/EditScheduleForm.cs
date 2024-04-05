using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuestionBank_GUI
{
    public partial class EditScheduleForm : Form
    {
        public EditScheduleForm()
        {
            InitializeComponent();
        }
        public static Schedule schedule;
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (cbMaMon != null && cbGioThi != null && cbMaLop != null && dateNgayThi.Value > DateTime.Now)
                ScheduleForm.editSchedule = new Schedule(cbMaMon.Text, "Kỹ thuật lập trình", cbMaLop.Text, dateNgayThi.Value, cbGioThi.Text);
            Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditScheduleForm_Load(object sender, EventArgs e)
        {
            cbMaMon.SelectedItem= ScheduleForm.editSchedule.maMon;
            cbGioThi.SelectedItem= ScheduleForm.editSchedule.gioThi;
            cbMaLop.SelectedItem= ScheduleForm.editSchedule.maLop;
            cbGioThi.SelectedItem= ScheduleForm.editSchedule.gioThi;
            dateNgayThi.Value = ScheduleForm.editSchedule.ngayThi;

        }
    }
}
