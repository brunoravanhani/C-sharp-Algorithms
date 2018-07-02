using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Algoritms.Implementation;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ImplementationTests
    {

        [TestCase(7,11,5,15,new int[]{-2,2,1}, new int[]{5,-6}, new int[]{1,1})]
        public void AppleOrangeTest(int s, int t, int a, int b, int[] apples, int[] oranges, int[] expected)
        {
            var result = AppleOrange.Run(s,t,a,b,apples,oranges);

            Assert.AreEqual(expected, result);
        }
    }
}