using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_DTO;

namespace QuestionBank_DAO
{
    public class Subject_DAO : DBConnect
    {
        public DataTable getId_Subjects()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id_MonHoc, ten_mon_hoc from MonHoc",
                conn);
            DataTable dtSubject = new DataTable();

            conn.Open();

            da.Fill(dtSubject);

            conn.Close();

            return dtSubject;
        }

        
    }
}
