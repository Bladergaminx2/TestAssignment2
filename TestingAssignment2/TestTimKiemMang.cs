using NUnit.Framework;
using System;
using TestAssignment2;

namespace NUnitLab
{
    [TestFixture]
    public class TestTimKiemMang
    {
        private TimKiemMang timkiem;

        [SetUp]
        public void Setup()
        {
            timkiem = new TimKiemMang();
        }

        [Test]
        public void TestLayPhanTu_ValidIndex_ReturnsCorrectElement()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 2;
            int expected = 3;
            int result = timkiem.LayPhanTu(array, index);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestLayPhanTu_NullArray_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => timkiem.LayPhanTu(null, 0));
        }

    }
}
