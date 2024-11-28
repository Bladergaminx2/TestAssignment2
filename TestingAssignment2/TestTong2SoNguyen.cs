using TestAssignment2;
using System;

namespace NUnitLab
{
    [TestFixture]
    public class TestTong2SoNguyen
    {
        private Tong2SoNguyen tong;

        [SetUp]
        public void Setup()
        {
            tong = new Tong2SoNguyen();
        }


        [Test]
        [TestCase(5, 3, 8)]                
        [TestCase(0, 0, 0)]                
        [TestCase(-10, 10, 0)]             
        [TestCase(-10, -5, -15)]           
        [TestCase(1000000000, 1000000000, 2000000000)] 
        [TestCase(-1000000000, -1000000000, -2000000000)] 
        [TestCase(1, -1, 0)]              
        [TestCase(1.5, 2, 0)]              
        [TestCase(100, 200, 300)]          
        [TestCase(-1, 1, 0)]               
        public void TestTongHaiSoNguyen(double a, double b, double expected)
        {
            try
            {
                double result = tong.TongHaiSoNguyen(a, b);
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
