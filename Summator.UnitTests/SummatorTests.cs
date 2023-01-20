using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {

        [Test]
        public void TestSummatorSumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2, };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestSummatorSumTwoNegativeNumbers()
        {
            var nums = new int[] { -2, -99 };
            var actual = Summator.Sum(nums);

            var expected = -101;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void TestSummatorOneNumber()
        {
            var nums = new int[] { 11 };
            var actual = Summator.Sum(nums);

            var expected = 11;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestSummatorZeroNumber()
        {
            var nums = new int[] {  };
            var actual = Summator.Sum(nums);

            var expected = 0;
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSummatorBigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);

            var expected = 8000000000;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}