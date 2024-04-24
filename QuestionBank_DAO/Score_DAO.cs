using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank_DAO
{
    public class Score_DAO: DBConnect
    {
        public bool addScore(Score_DTO score)
        {
            string sql = "SELECT * FROM Diem";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataSet dataSet = new DataSet();

            using (conn)
            {
                try
                {
                    conn.Open();

                    dataAdapter = new SqlDataAdapter(sql, conn);
                    commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataAdapter.Fill(dataSet, "Diem");

                    DataRow newRow = dataSet.Tables["Diem"].NewRow();
                    newRow["id_sv"] = score.IdStudent;
                    newRow["id_MonHoc"] = score.IdSubject;
                    newRow["diem"] = score.Score;
                    dataSet.Tables["Diem"].Rows.Add(newRow);

                    dataAdapter.Update(dataSet, "Diem");

                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    dataSet.RejectChanges();
                    return false;
                }
            }
        }
        public DataTable getScores(string subjectId, int semester, int year)
        {
            string sql = "Select diem, Count(id_diem) as Qty " +
                "From Diem " +
                "Join SinhVien_LopHoc on id_sv = Id_MSSV " +
                "Join LopHoc_MonHoc on Id_Lop = Id_LopHoc " +
                $"Where LopHoc_MonHoc.id_MonHoc = '{subjectId}' " +
                "And Diem.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                $"And HocKy = {semester} and NamHoc = {year} " +
                "Group By diem " +
                "Order By Count(id_diem)";

            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();

                dataAdapter = new SqlDataAdapter(sql, conn);
                commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet, "Diem");

                return dataSet.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return dataTable;
            }
            finally
            {
                conn.Close();
            }   
        }
    }
}
