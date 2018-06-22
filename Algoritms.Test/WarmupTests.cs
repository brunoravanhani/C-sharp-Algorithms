using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Algoritms.Warmup;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WarmupTests
    {
        

        [Test]
        public void PlusMinusTest() 
        {
            var expected = new decimal[]{0.500000M, 0.333333M, 0.166667M};

            var result = PlusMinus.Run(6, new int[]{-4,3,-9,0,4,1});

            Assert.AreEqual(expected, result);
        }

        [TestCase(new long[]{1,2,3,4,5}, new long[]{10,14})]
        [TestCase(
            new long[]{256741038,623958417,467905213,714532089,938071625}, 
            new long[]{2063136757,2744467344}
        )]
        public void MiniMaxSumTest(long[] input, long[] expected)
        {

            var result = MiniMaxSum.Run(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[]{3,2,1,3,3}, 3)]
        public void BirthdayCakeCandlesTest(int[] input, int expected) 
        {
            var result = BirthdayCakeCandles.Run(input);

            Assert.AreEqual(expected, result);
        }

        [TestCase("07:05:45AM")]
        [TestCase("07:05:45PM")]
        [TestCase("12:40:22AM")]
        [TestCase("12:45:54PM")]
        public void TimeConversionTest(string input) 
        {
            var date = DateTime.Parse(input);
            var expected = date.ToString("HH:mm:ss");

            var result = TimeConversion.Run(input);

            Assert.AreEqual(expected, result);
        }
    }
}