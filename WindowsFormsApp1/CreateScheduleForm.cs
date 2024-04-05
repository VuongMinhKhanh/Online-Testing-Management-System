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
    public partial class CreateScheduleForm : Form
    {
        public static Schedule schedule;
        public CreateScheduleForm()
        {
            InitializeComponent();
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (cbMaMon != null && cbGioThi != null && cbMaLop != null && dateNgayThi.Value > DateTime.Now)
                schedule = new Schedule(cbMaMon.Text, "Kỹ thuật lập trình", cbMaLop.Text, dateNgayThi.Value, cbGioThi.Text);
            Close();

        }
    }
}
