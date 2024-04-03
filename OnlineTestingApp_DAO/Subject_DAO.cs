using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DAO
{
    public class Subject_DAO : DBConnect
    {
        public DataTable getSubjects()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ten_mon_hoc from MonHoc",
                conn);
            DataTable dtSubject = new DataTable();

            conn.Open();

            da.Fill(dtSubject);

            conn.Close();

            return dtSubject;
        }
    }
}
