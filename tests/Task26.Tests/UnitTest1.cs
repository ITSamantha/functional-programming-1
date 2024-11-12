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
            Assert.That(result, Is.EqualTo(6), "The cycle length for d = 7 should be 6");
        }

        [Test]
        public void TestCycleLengthForD3()
        {
            var result = task26rec.cycleLength(3);
            Assert.That(result, Is.EqualTo(1), "The cycle length for d = 3 should be 1");
        }

        [Test]
        public void TestCycleLengthForD1()
        {
            var result = task26rec.cycleLength(1);
            Assert.That(result, Is.EqualTo(0), "The cycle length for d = 1 should be 0");
        }

        [Test]
        public void TestFindMaxCycleRec()
        {
            var result = task26rec.findMaxCycleRec(1, 1000, 1, 0);
            Assert.That(result, Is.EqualTo(983), "The number with the longest cycle length in the range should be 983");
        }

        [Test]
        public void TestFindMaxCycleRecWithSmallerRange()
        {
            var result = task26rec.findMaxCycleRec(1, 10, 1, 0);
            Assert.That(result, Is.EqualTo(7), "The number with the longest cycle length in the range should be 7");
        }

        [Test]
        public void TestFindMaxCycleRecWithLargeRange()
        {
            var result = task26rec.findMaxCycleRec(1, 2000, 1, 0);
            Assert.That(result, Is.EqualTo(1979), "The number with the longest cycle length in the range should be 1979");
        }
    }
}