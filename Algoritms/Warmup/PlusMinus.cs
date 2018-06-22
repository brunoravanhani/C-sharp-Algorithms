using System;
using System.Linq;

namespace Algoritms.Warmup
{
    public class PlusMinus
    {
        
        public static decimal[] Run (int n, int[] arr)
        {
            var va1 = RoundInSix( (decimal) arr.Count(x => x > 0) / n );
            var va2 = RoundInSix( (decimal) arr.Count(x => x < 0) / n );
            var va3 = RoundInSix( (decimal) arr.Count(x => x == 0) / n );
            return new decimal[]{ va1, va2, va3};
        }

        public static decimal RoundInSix(decimal value) {
            return Math.Round(value, 6, MidpointRounding.AwayFromZero);
        }
    }
}