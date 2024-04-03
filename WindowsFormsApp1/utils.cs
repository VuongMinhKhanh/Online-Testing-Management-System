using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank_GUI
{
    public class utils
    {
        public static void LoadSubjects(ComboBox comboBox, DataRow[] dr, string columnName)
        {
            foreach (DataRow dr2 in dr)
            {
                comboBox.Items.Add(dr2[columnName].ToString());
            }
        }
    }
}
