using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_BUS;
using QuestionBank_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuestionBank_GUI
{
    public partial class TestForm : Form
    {
        private List<Question_DTO> questions = new List<Question_DTO>();
        private Question_BUS question_bus = new Question_BUS();
        private Score_BUS score_bus = new Score_BUS();
        private int questionNumber = 4;
        private string idSubject = "ITEC3406";
        private string subjectName = "Lập trình cơ sở dữ liệu";
        private string idStudent = "001";
        private Dictionary<string, int> answerDict;
        private List<GroupBox> questionList = new List<GroupBox>();
        private double score = 0;
        private Timer timer;
        private int testTime = 0 * 60 + 10; // minutes * 60 + seconds;
        private int remainingTime;
        public TestForm()
        {
            InitializeComponent();
        }
        public TestForm(string idStudent, string idSubject, string subjectName)
        {
            InitializeComponent();

            this.idStudent = idStudent;
            this.idSubject = idSubject;
            this.subjectName = subjectName;
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            //questionNumber = 4;
            //idSubject = "ITEC3406";
            Text += " " + subjectName;

            DataRow[] drQuestions = question_bus.getRandomQuestions(questionNumber, idSubject).Select();
            questionList = new List<GroupBox>();
            Utils.AddGroupBoxQuestionsToControl(flpForm, drQuestions, questionList);

            timer = new Timer();
            //testTime = 0 * 60 + 1; // minutes * 60 + seconds
            remainingTime = testTime;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            lbTimer.Text = $"{testTime / 60}:{testTime % 60:00}";
            ActiveControl = lbTimer;
            //timer.Start();

            answerDict = Utils.getListOfCorrectAnswers(drQuestions);
            Button btnSubmit = new Button()
            {
                Text = "Hoàn thành!",
                Height = 50,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                UseVisualStyleBackColor = false,
                BackColor = Color.MediumSeaGreen,
            };
            btnSubmit.Left = Width / 2 - btnSubmit.Width / 2;
            btnSubmit.Width *= 2;
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Click += BtnSubmit_Click;
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            flpForm.Controls.Add(btnSubmit);

            //pbAnswer.Maximum = questionList.Count;
            //pbAnswer.Value = 0;
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.MediumSeaGreen;
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SeaGreen;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                // Update the UI to show the remaining time
                lbTimer.Text = $"{remainingTime / 60}:{remainingTime % 60:00}";
                
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is up!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                score = Utils.CalculateScore(questionList, answerDict);

                MessageBox.Show((score * 10 / questionList.Count).ToString());
                score_bus.addScore(Utils.GetScore(idStudent, idSubject, score));
                score = 0;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!Utils.CheckFormCompleted(questionList))
                return;

            score = Utils.CalculateScore(questionList, answerDict);

            score = score * 10 / questionList.Count;
            MessageBox.Show(score.ToString());
            
            score_bus.addScore(Utils.GetScore(idStudent, idSubject, score));
            score = 0;
        }

        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gbAnswers_Enter(object sender, EventArgs e)
        {

        }

        private void TestForm_Click(object sender, EventArgs e)
        {
            
        }

        private void flpForm_Click(object sender, EventArgs e)
        {
            //int percentage = (int)((double)Utils.CountCompletedAnsers(questionList) / pbAnswer.Maximum * 100);
            //lbProgress.Text = $"Progress: {percentage}%";
        }

        private void flpForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
