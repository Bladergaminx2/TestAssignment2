using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestAssignment2;

namespace NUnitLab
{
    [TestFixture]
    public class TestTBC
    {
        private TBC tbc;

        [SetUp]
        public void Setup()
        {
            tbc = new TBC      ();
        }

        [Test]
        public void TestTinhTrungBinhCong_ValidList_ReturnsCorrectResult()
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };
            double expected = 3;
            double result = tbc.TinhTrungBinhCong(numbers);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestTinhTrungBinhCong_EmptyList_ThrowsArgumentException()
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };
            double expected = 3;
            double result = tbc.TinhTrungBinhCong(numbers);
            Assert.AreEqual(expected, result);
        }


    }
}
