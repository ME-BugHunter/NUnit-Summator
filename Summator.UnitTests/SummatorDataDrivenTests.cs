using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Summator.UnitTests
{
    public class SummatorDataDrivenTests
    {

        [TestCase(new int[] {1,2}, 3)]
        [TestCase(new int[] {1}, 1)]
        [TestCase(new int[] { -3, -9, -20 }, -32)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 }, 8000000000)]
        public void Test_Summator_SumDDT(int[] values, long expected)
        {
            var actual = Summator.Sum(values);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new double[] {15, 15, 12}, 14)]
        [TestCase(new double[] { -4, 2, -5, -2 },-2.25 )]
        [TestCase(new double[] {2000000000, 2000000000, 2000000000 }, 2000000000)]
        public void Test_Summator_AverageDDT(double[] values, double expected)
        {
            var actual = Summator.Average(values);
            
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new long[] { 444, 555, 999 }, 246173580)]
        [TestCase(new long[] { -100, -40, 1001, 240 }, 960960000)]
        [TestCase(new long[] { 2000000000, 43 }, 86000000000)]
        [TestCase(new long[] { -50, -25, -9, -56, -108 }, -68040000)]
        [TestCase(new long[] { 3000000, 3444, 120, 0, 4 }, 0)]
        public void Test_Summator_MultiplyDDT(long[] values, long expected)
        {
            var actual = Summator.Multiply(values);

            Assert.That(actual, Is.EqualTo(expected));
        }
   
    }
}
