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

            Assert.AreEqual(result, expected);
        }
    }
}