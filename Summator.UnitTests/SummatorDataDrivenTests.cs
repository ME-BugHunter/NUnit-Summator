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
    }
}
