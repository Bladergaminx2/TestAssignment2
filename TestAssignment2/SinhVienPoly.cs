using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
    public class SinhVienPoly
    {
        private List<SinhVien> danhSachSinhVien;

        public SinhVienPoly()
        {
            danhSachSinhVien = new List<SinhVien>();
        }

        public void ThemSinhVien(SinhVien sinhVien)
        {
            if (string.IsNullOrWhiteSpace(sinhVien.TenLop) || sinhVien.TenLop.Any(c => !char.IsLetterOrDigit(c) && c != ' '))
                throw new ArgumentException("tên lớp không được có ký tự đặc biệt");

            danhSachSinhVien.Add(sinhVien);
        }

        public SinhVien TimKiemTheoMaSV(string maSV)
        {
            return danhSachSinhVien.FirstOrDefault(sv => sv.MaSV == maSV);
        }
    }
}
