using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaSV { get; set; }

        public SinhVien(string id, string hoTen, string maLop, string tenLop, string maSV)
        {
            Id = id;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
            MaSV = maSV;
        }
    }
}
