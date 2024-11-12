namespace Task26.Tests;
using NUnit.Framework;    
using static task26rec;       
   

public class Tests
{

    [TestFixture]
    public class Task26RecTests
    {
        [Test]
        public void TestCycleLengthForD7()
        {
            var result = task26rec.cycleLength(7);
            Assert.AreEqual(6, result, "The cycle length for d = 7 should be 6");
        }

        [Test]
        public void TestCycleLengthForD3()
        {
            var result = task26rec.cycleLength(3);
            Assert.AreEqual(1, result, "The cycle length for d = 3 should be 1");
        }

        [Test]
        public void TestCycleLengthForD1()
        {
            var result = task26rec.cycleLength(1);
            Assert.AreEqual(0, result, "The cycle length for d = 1 should be 0");
        }

        [Test]
        public void TestFindMaxCycleRec()
        {
            var result = task26rec.findMaxCycleRec(1000, 1, 1, 0);
            Assert.AreEqual(983, result, "The number with the longest cycle length in the range should be 983");
        }

        [Test]
        public void TestFindMaxCycleRecWithSmallerRange()
        {
            var result = task26rec.findMaxCycleRec(10, 1, 1, 0);
            Assert.AreEqual(7, result, "The number with the longest cycle length in the range should be 7");
        }

        [Test]
        public void TestFindMaxCycleRecWithLargeRange()
        {
            var result = task26rec.findMaxCycleRec(2000, 1, 1, 0);
            Assert.AreEqual(1979, result, "The number with the longest cycle length in the range should be 983");
        }
    }
}