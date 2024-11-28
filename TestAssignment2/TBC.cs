using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
    public class TBC
    {
        public double TinhTrungBinhCong(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("danh sách không được để trống");

            return numbers.Average();
        }
    }
}
