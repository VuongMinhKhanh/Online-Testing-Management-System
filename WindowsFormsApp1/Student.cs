using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_GUI
{
    public class Student
    {
        public int mssv,namNhapHoc;
        public Student()
        {
        }

        public Student(int mssv, int namNhapHoc)
        {
            this.mssv = mssv;
            this.namNhapHoc = namNhapHoc;
        }
        static public DataTable getScoreOfStudentFromClass(int lopHocMonHocID, string mssv)
        {
            DataTable dataTable = new DataTable();
            string query = "select id_diem as N'ID', diem as N'Điểm' , loai_diem as N'Loại điểm' from SinhVien_DangKyMon left join LopHoc_MonHoc on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc join Diem on Diem.id_sv = SinhVien_DangKyMon.mssv and  Diem.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc where mssv = @mssv and LopHoc_MonHoc.id_LopHoc_MonHoc = @lopHocMonHocID";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@lopHocMonHocID", lopHocMonHocID);
                sqlCommand.Parameters.AddWithValue("@mssv", mssv);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
