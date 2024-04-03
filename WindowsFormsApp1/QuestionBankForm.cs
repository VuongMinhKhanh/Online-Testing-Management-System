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
using QuestionBank_DTO;

namespace QuestionBank_GUI
{
    public partial class QuestionBankForm : Form
    {
        Subject_BUS subject = new Subject_BUS();
        public QuestionBankForm()
        {
            InitializeComponent();

            DataRow[] dr = subject.getSubjects().Select();
            utils.LoadSubjects(cbSubject, dr, "ten_mon_hoc");
            cbSubject.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
