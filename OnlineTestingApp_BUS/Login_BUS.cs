using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank_DAO;
using QuestionBank_DTO;


namespace QuestionBank_BUS
{
    internal class Login_BUS
    {
        Login_DAO login = new Login_DAO();

        public DataTable getUsers()
        {
            return login.GetUsers();
        }
    }
}
