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
        public TestForm(string idStudent, string idSubject)
        {
            InitializeComponent();

            this.idStudent = idStudent;
            this.idSubject = idSubject;
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            //questionNumber = 4;
            //idSubject = "ITEC3406";
            Text += " " + idSubject;

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
                Text = "Finish!",
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
            //MessageBox.Show(questionList[0].Controls[0].Controls[0].Text.ToString());
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
            // Clear existing RadioButtons
            //gbAnswers.Controls.Clear();
            // Dynamically create and bind RadioButtons for the answers
            //for (int i = 0; i < selectedQuestion.Answers.Count; i++)
            //{
            //    RadioButton radioButton = new RadioButton();
            //    radioButton.Text = selectedQuestion.Answers[i];
            //    radioButton.Location = new Point(10, i * 20 + 20); // Adjust as needed
            //    radioButton.Size = new Size(200, 17); // Adjust as needed
            //    gbAnswers.Controls.Add(radioButton);
            //}
        }

        private void gbAnswers_Enter(object sender, EventArgs e)
        {

        }
    }
}
