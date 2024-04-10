using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank_GUI
{
    public class utils
    {
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
            List<String> answers = new List<String>();
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
    }
}
