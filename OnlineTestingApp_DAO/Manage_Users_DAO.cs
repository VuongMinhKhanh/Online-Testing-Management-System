using System;
using System.Data;
using System.Data.SqlClient;

namespace QuestionBank_DAO
{
    public class Manage_Users_DAO : DBConnect
    {
        // Lấy danh sách người dùng từ cơ sở dữ liệu
        public DataTable GetUsers()
        {
            DataTable dtUser = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Account", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dtUser);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtUser;
        }

        // Thêm một người dùng mới vào cơ sở dữ liệu
        public void AddUser(string username, string password, string userRole)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Account (Username, Password, UserRole) VALUES (@Username, @Password, @UserRole)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserRole", userRole);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Cập nhật thông tin người dùng trong cơ sở dữ liệu
        public void UpdateUser(int userId, string username, string password, string userRole)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Account SET Username = @Username, Password = @Password, UserRole = @UserRole WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserRole", userRole);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Xóa người dùng khỏi cơ sở dữ liệu dựa trên userId
        public void DeleteUser(int userId)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Account WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
