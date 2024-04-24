using QuestionBank_DAO;
using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_BUS
{
    public class Score_BUS
    {
        Score_DAO score_dao = new Score_DAO();

        public bool addScore(Score_DTO score)
        {
            return score_dao.addScore(score);
        }
        public DataTable getScores(string subjectId, int semester, int year)
        {
            return score_dao.getScores(subjectId, semester, year);
        }
    }
}
