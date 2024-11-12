namespace Task7.Tests;
using NUnit.Framework;
using static task7inf;       
using static task7module;    
using static task7rec;       
using static task7tailrec;   
using static task7map;     

public class Tests
{
    [TestFixture]
    public class Task7Tests
    {
        [Test]
        public void TestFindNthPrimeInTask7Inf()
        {
            var result = task7inf.findNthPrime(6);
            Assert.That(result, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void TestFindNthPrimeInTask7Module()
        {
            var result = task7module.findNthPrime(6);
            Assert.That(result, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void TestFindNthPrimeInTask7Rec()
        {
            var result = task7rec.findNthPrime(6, 1, 0);
            Assert.That(result, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void TestFindNthPrimeInTask7TailRec()
        {
            var result = task7tailrec.findNthPrime(6);
            Assert.That(result, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void TestFindNthPrimeInTask7Map()
        {
            var result = task7map.findNthPrime(6);
            Assert.That(result, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void TestIsPrimeNumberForPrimeNumber()
        {
            var result = task7module.isPrimeNumber(29);
            Assert.That(result, Is.True, "29 should be prime");
        }

        [Test]
        public void TestIsPrimeNumberForNonPrimeNumber()
        {
            var result = task7module.isPrimeNumber(100);
            Assert.That(result, Is.False, "100 should not be prime");
        }
    }
}