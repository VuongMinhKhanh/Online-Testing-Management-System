using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuestionBank_GUI
{
    public static class Utils
    {
        private static Random rng = new Random();

        public static void LoadSubjects(ComboBox comboBox, DataRow[] dr, string columnName)
        {
            foreach (DataRow dr2 in dr)
            {
                comboBox.Items.Add(dr2[columnName].ToString());
            }
        }

        public static void LoadQuestions(ListView listView, DataRow[] dr, string idColumn, string questionColumn, string answerColumn)
        {
            listView.Items.Clear();

            foreach (DataRow dr2 in dr)
            {
                ListViewItem item = new ListViewItem(new string[] { dr2[questionColumn].ToString(), dr2[answerColumn].ToString() });
                item.Font = new Font("arial", 12, FontStyle.Regular);
                item.Tag = dr2[idColumn].ToString();
                listView.Items.Add(item);
            }
        }

        public static void LoadQuestions(ListView listView, DataRow[] dr, string idColumn, string questionColumn, string answerColumn, string keyword)
        {
            listView.Items.Clear();

            foreach (DataRow dr2 in dr)
            {
                if (dr2[questionColumn].ToString().StartsWith(keyword))
                {
                    ListViewItem item = new ListViewItem(new string[] { dr2[questionColumn].ToString(), dr2[answerColumn].ToString() });
                    item.Font = new Font("arial", 12, FontStyle.Regular);
                    item.Tag = dr2[idColumn].ToString();
                    listView.Items.Add(item);
                }
            }
        }

        public static Question_DTO GetQuestion(DataRow[] drQuestion, DataRow[] drAnswers, string idSubject)
        {
            List<string> answers = new List<string>();
            List<int> idAnswers = new List<int>();
            int index = 1;
            int correctAnswer = 0;
            foreach (DataRow dr in drAnswers)
            {
                answers.Add(dr["cau_tra_loi"].ToString());
                idAnswers.Add(int.Parse(dr["id_ChiTietCauHoi"].ToString()));

                if (dr["cau_tra_loi"].ToString() == drQuestion[0]["cau_tra_loi"].ToString())
                {
                    correctAnswer = index;
                }

                index++;
            }

            Question_DTO question = new Question_DTO(
                int.Parse(drQuestion[0]["id_CauHoi"].ToString()),
                drQuestion[0]["cau_hoi"].ToString(),
                idAnswers,
                answers,
                int.Parse(drQuestion[0]["id_DapAn"].ToString()),
                correctAnswer,
                true,
                idSubject
                );

            return question;
        }

        public static bool IsValidQuestion(
            TextBox txtQuestion,
            TextBox txt1, RadioButton rd1,
            TextBox txt2, RadioButton rd2,
            TextBox txt3, RadioButton rd3,
            TextBox txt4, RadioButton rd4
            )
        {
            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Question missing");
                return false;
            }    

            int countTxt = 0;
            if (txt1.Text != "")
                countTxt++;
            if (txt2.Text != "")
                countTxt++;
            if (txt3.Text != "")
                countTxt++;
            if (txt4.Text != "")
                countTxt++;
            if (countTxt < 2)
            {
                MessageBox.Show("Answers must be more than 2");
                return false;
            }
            else
            {
                if (txt1.Text == "" && rd1.Checked ||
                    txt2.Text == "" && rd2.Checked ||
                    txt3.Text == "" && rd3.Checked ||
                    txt4.Text == "" && rd4.Checked)
                {
                    MessageBox.Show("Correct answers mustn't be ticked in a null answer");
                    return false;
                }
            }

            return true;
        }

        public static void AddGroupBoxQuestionsToControl
            (Control containerControl,
            DataRow[] drQuestions,
            List<GroupBox> containerGroupBox)
        {
            int questionNo = 1;
            int answerIndex = 0;

            GroupBox groupBox = new GroupBox()
            {
                Width = containerControl.Width,
                Name = "gb0",
                Text = $"Câu {questionNo}: " + drQuestions[0]["cau_hoi"].ToString(),
                Tag = drQuestions[0]["id_CauHoi"].ToString(),
                //Font = new Font("Arial", 12, FontStyle.Bold),
            };
            containerControl.Controls.Add(groupBox);
            FlowLayoutPanel flpInner = new FlowLayoutPanel()
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                Width = containerControl.Width,
                Dock = DockStyle.Fill,
            };
            groupBox.Controls.Add(flpInner);
            groupBox.Height = flpInner.Height * 2;
            containerGroupBox.Add(groupBox);

            string[] answer = { "A", "B", "C", "D" };
            int id = int.Parse(drQuestions[0]["id_CauHoi"].ToString());
            int startY = 20;
            List<RadioButton> rdList = new List<RadioButton>();

            foreach (DataRow dr in drQuestions)
            {
                //MessageBox.Show(id.ToString() + " " + dr["id_CauHoi"].ToString());
                if (int.Parse(dr["id_CauHoi"].ToString()) != id)
                {
                    questionNo++;
                    answerIndex = 0;

                    Shuffle(rdList);
                    foreach (RadioButton radio in rdList)
                        flpInner.Controls.Add(radio);

                    rdList = new List<RadioButton>();

                    groupBox = new GroupBox()
                    {
                        Width = containerControl.Width,
                        Name = "rd" + questionNo.ToString(),
                        Text = $"Câu {questionNo}: " + dr["cau_hoi"].ToString(),
                        Tag = dr["id_CauHoi"].ToString(),
                    };

                    containerControl.Controls.Add(groupBox);
                    containerGroupBox.Add(groupBox);

                    flpInner = new FlowLayoutPanel()
                    {
                        AutoSize = true,
                        FlowDirection = FlowDirection.TopDown,
                        Width = containerControl.Width,
                        Dock = DockStyle.Fill,
                    };
                    groupBox.Controls.Add(flpInner);
                    groupBox.Height = flpInner.Height * 2;

                    startY = 20;
                    
                    id = int.Parse(dr["id_CauHoi"].ToString());
                }

                RadioButton rd = new RadioButton()
                {
                    Text = $"{answer[answerIndex]}. {dr["cau_tra_loi"]}",
                    AutoSize = true,
                    Location = new Point(6, startY),
                    Width = containerControl.Width,
                    Tag = int.Parse(dr["id_ChiTietCauHoi"].ToString()),
                };
                //rd.Click += Rd_Click;
                rdList.Add(rd);
                //flpInner.Controls.Add(rd);
                answerIndex++;
                startY += 30;
            }

            if (rdList.Count != 0)
            {
                Shuffle(rdList);
                foreach (RadioButton rd in rdList)
                    flpInner.Controls.Add(rd);
            }
                
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static Dictionary<string, int> getListOfCorrectAnswers(DataRow[] drQuestions )
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (DataRow dr in drQuestions)
            {
                if (dr["id_DapAn"].ToString() != "")
                    dict.Add(dr["id_CauHoi"].ToString(), int.Parse(dr["id_ChiTietCauHoi"].ToString()));
            }

            return dict;
        }

        public static bool CheckFormCompleted(List<GroupBox> gbList)
        {
            foreach (GroupBox gb in gbList)
            {
                if (gb.Controls[0].Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked) is null)
                {
                    if (MessageBox.Show("The form is incomplete. Would you like to proceed anyway?",
                        "Incomplete Form Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return false;
                }
            }

            if (MessageBox.Show("Are you ready to submit your form?",
                        "Confirm Submission",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                return false;

            return true;
        }

        public static int CalculateScore(List<GroupBox> gbList, Dictionary<string, int> answerDict)
        {
            int score = 0;

            foreach (GroupBox gb in gbList)
            {
                RadioButton rdObj = gb.Controls[0].Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);
                int userAnswerId = 0;
                if (!(rdObj is null))
                    userAnswerId = int.Parse(rdObj.Tag.ToString());

                if (answerDict[gb.Tag.ToString()] == userAnswerId)
                    score++;
            }

            return score;
        }
        public static Score_DTO GetScore(string idStudent, string idSubject, double score)
        {
            Score_DTO score_dto = new Score_DTO(idStudent, idSubject, score);

            return score_dto;
        }

    }
}
