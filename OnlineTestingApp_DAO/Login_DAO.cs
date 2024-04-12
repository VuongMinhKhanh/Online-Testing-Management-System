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

        public bool CheckLogin(string username, string password, string userRole)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE Username = @Username AND Password = @Password AND UserRole = @UserRole";

            conn.Open();
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserRole", userRole);

                    try
                    {
                        conn.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Trả về true nếu có tài khoản tồn tại trong cơ sở dữ liệu
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false; // Trả về false nếu có lỗi xảy ra trong quá trình kiểm tra đăng nhập
                    }
                }
            }
        }
    }
}
