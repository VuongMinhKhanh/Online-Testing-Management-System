using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Schedule
    {
        public string tenMonHoc,maMon,gioThi,maLop;
        public DateTime ngayThi = new DateTime();
        public Schedule(string maMon,string tenMonHoc, string maLop, DateTime ngayThi,string gioThi)
        {
            this.maMon = maMon;
            this.tenMonHoc = tenMonHoc;
            this.ngayThi = ngayThi;
            this.gioThi = gioThi;
            this.maLop = maLop;
        }
        public Schedule()
        {
            this.maMon = "";
            this.tenMonHoc = "";
            this.ngayThi = default;
            this.gioThi = "";
            this.maLop = "";
        }
    }
}
