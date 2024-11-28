using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
    public class Hieu2SoNguyen
    {
        public double HieuHaiSoNguyen(double a, double b)
        {
            if (a % 1 != 0 || b % 1 != 0)
                throw new ArgumentException("Cả hai số phải là số nguyên");

            double ketQua = a - b;

            if (ketQua > int.MaxValue || ketQua < int.MinValue)
                throw new OverflowException("Kết quả vượt quá giới hạn của số nguyên");

            return ketQua;
        }
    }
}
                                 