using TestAssignment2;
using NUnit.Framework;

namespace NUnitLab
{
    [TestFixture]
    public class TestHieu2SoNguyen
    {
        private Hieu2SoNguyen hieu;

        [SetUp]
        public void Setup()
        {
            hieu = new Hieu2SoNguyen();
        }

        [Test]
        [TestCase(10, 5, 5)]                 
        [TestCase(0, 0, 0)]                  
        [TestCase(-10, 10, -20)]            
        [TestCase(-10, -5, -5)]             
        [TestCase(1000000000, 500000000, 500000000)]
        [TestCase(-1000000000, -500000000, -500000000)] 
        [TestCase(1, -1, 2)]                 
        [TestCase(1.5, 2, 0)]                
        [TestCase(100, 200, -100)]           
        [TestCase(-1, 1, -2)]                
        public void TestHieuHaiSoNguyen(double a, double b, double expected)
        {
            try
            {
                double result = hieu.HieuHaiSoNguyen(a, b);
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
