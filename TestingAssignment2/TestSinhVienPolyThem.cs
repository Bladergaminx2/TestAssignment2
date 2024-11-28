using TestAssignment2;

namespace NUnitLab
{
    [TestFixture]
    public class TestSinhVienPolyThem
    {
        private SinhVienPoly sinhVienPoly;

        [SetUp]
        public void Setup()
        {
            sinhVienPoly = new SinhVienPoly();
        }

        [Test]
        [TestCase("1", "Nguyen Van Anh", "ML001", "Lop 1", "SV001")] 
        [TestCase("2", "Tran Van Bang", "ML002", "Lop Hoc", "SV002")] 
        [TestCase("3", "Pham Van Cang", "ML003", "Lop123", "SV003")]  
        [TestCase("4", "Le Van Dung", "ML004", "Lop_Hoc", "SV004")]  
        [TestCase("5", "Hoang Van Tien", "ML005", "Lop@", "SV005")]  
        [TestCase("6", "Do Van Huong", "ML006", "123", "SV006")]      
        [TestCase("7", "Nguyen Van Cuong", "ML007", "", "SV007")]    
        [TestCase("8", "Tran Thi Hoa", "ML008", "", "SV008")]     
        [TestCase("9", "Le Van Nhat", "ML009", " ", "SV009")]    
        [TestCase("10", "Nguyen Thi Hieu", "ML010", "Lop 123", "SV010")] 


        public void TestThemSinhVien(string id, string hoTen, string maLop, string tenLop, string maSV)
        {

            try
            {
                var sinhVien = new SinhVien(id, hoTen, maLop, tenLop, maSV);
                sinhVienPoly.ThemSinhVien(sinhVien);
                Assert.Pass("thêm thành công");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("tên lớp không được chứa ký tự đặc biệt", ex.Message);
            }
            catch (Exception)
            {
                Assert.Fail("lỗi không xác định.");
            }

        }
    }
}
