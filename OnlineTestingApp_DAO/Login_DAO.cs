using System;
using System.Data;
using System.Data.SqlClient;

namespace QuestionBank_DAO
{
    public class Login_DAO : DBConnect
    {
        public DataTable GetUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Account", conn);
            DataTable dtUser = new DataTable();

            conn.Open();

            da.Fill(dtUser);

            conn.Close();

            return dtUser;
        }
    }
}
