using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
    public class TimKiemMang
    {
        public int LayPhanTu(int[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Mảng không được trống");

            return array[index];
        }
    }
}
