
using TestAssignment2;

namespace NUnitLab
{
    [TestFixture]
    public class TestSinhVienPolyTim
    {
        private SinhVienPoly sinhVienPoly;

        [SetUp]
        public void Setup()
        {
            sinhVienPoly = new SinhVienPoly();

            sinhVienPoly.ThemSinhVien(new SinhVien("1", "Nguyen Van Anh", "ML001", "Lop 1", "SV001"));
            sinhVienPoly.ThemSinhVien(new SinhVien("2", "Tran Van Bang", "ML002", "Lop 2", "SV002"));
        }

        [Test]
        [TestCase("SV001", "Nguyen Van Anh")] 
        [TestCase("SV002", "Tran Van Bang")]  
        [TestCase("SV003", "")]          
        [TestCase("", "")]
        [TestCase("SV005", "Ngu Van Hiu")]              
        public void TestTimKiemTheoMaSV(string maSV, string expectedHoTen)
        {
            var result = sinhVienPoly.TimKiemTheoMaSV(maSV);
            if (expectedHoTen == null)
                Assert.IsNull(result);
            else
                Assert.AreEqual(expectedHoTen, result.HoTen);
        }
    }
}
