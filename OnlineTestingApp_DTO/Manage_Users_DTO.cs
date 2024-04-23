using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuestionBank_DTO
{
    public class Manage_Users_DTO
    {
        public int UserId { get { return UserId; } set { UserId = value; } }
        public string Username { get { return Username; } set { Username = value; } }
        public string Email { get { return Email; } set { Email = value; } }
        public string Password { get { return Password; } set { Password = value; } }
        public string UserRole { get { return UserRole; } set { UserRole = value; } }
    }
}
