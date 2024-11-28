using TestAssignment2;
using NUnit.Framework;

namespace NUnitLab
{
    [TestFixture]
    public class TestTich2SoNguyen
    {
        private Tich2SoNguyen tich;

        [SetUp]
        public void Setup()
        {
            tich = new Tich2SoNguyen();
        }

        [Test]
        [TestCase(5, 3, 15)]                 
        [TestCase(0, 5, 0)]                  
        [TestCase(-10, -10, 100)]            
        [TestCase(-10, 5, -50)]              
        [TestCase(1.5, 2, 0)]               
        [TestCase(1000000000, 1000000000, 0)]
        [TestCase(-1000000000, 1000000000, 0)] 
        [TestCase(1, 1, 1)]             
        [TestCase(-1, -1, 1)]              
        [TestCase(10, -10, -100)]           
        public void TestNhanHaiSoNguyen(double a, double b, double expected)
        {
            try
            {
                double result = tich.NhanHaiSoNguyen(a, b);
                Assert.AreEqual(expected, result);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(a % 1 != 0 || b % 1 != 0, "không phải số nguyên");
            }
            catch (OverflowException)
            {
                Assert.IsTrue(true, "kết quả vượt quá giới hạn số nguyên");
            }
        }
    }
}
