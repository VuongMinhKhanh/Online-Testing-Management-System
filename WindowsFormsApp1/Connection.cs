using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuestionBank_GUI
{
    public class Connection
    {
        private static string stringConnection = "Data Source=LAPTOP-4HVBK6EG\\TRANHOANG;Initial Catalog=HeThongQuanLyThiTracNghiemOnline;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }


}
