using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class Score_DTO
    {
        //private int idScore;
        private string idStudent;
        private string idSubject;
        private double score;

        public string IdStudent { get { return idStudent; } set { idStudent = value; } }
        public string IdSubject { get { return idSubject; } set { idSubject = value; } }
        public double Score { get { return score; } set { score = value; } }

        public Score_DTO() { }
        public Score_DTO(string idStudent, string idSubject, double score)
        {
            this.idStudent = idStudent;
            this.idSubject = idSubject;
            this.score = score;
        }   
    }
}
