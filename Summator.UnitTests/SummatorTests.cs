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
        [Test]
        public void TestSummatorBigNegativeNumbers()
        {
            var nums = new int[] { -2000000000, -2000000000, -2000000000 };
            var actual = Summator.Sum(nums);

            var expected = -6000000000;
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSummatorThreeNumbers()
        {
            //Arrange
            var nums = new int[] { 4, 9, -11 };
            var expected = 2;

            //Act
            var actual = Summator.Sum(nums);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        public void TestSummatorSumZero()
        {
            var nums = new int[] { 20, 45, -20, -45 };
            var actual = Summator.Sum(nums);

            Assert.That(0, Is.EqualTo(actual));

        }
        /*[Test]
        public void AssertionsExample()
        {
            //assert boolean conditions
            Assert.That(9 == 9);
            Assert.That(9, Is.GreaterThan(6));

            //Range Assertions
            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("I want to become the best QA", Does.Contain("QA"));
            //regex
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));
            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());

            //Assert.That(90, Is.EqualTo(100), "It's not equal");

        }*/

    }
}