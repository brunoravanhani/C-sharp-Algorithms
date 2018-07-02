using System;
using System.Linq;

namespace Algoritms.Implementation
{
    public class AppleOrange
    {
        public static int[] Run(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var countApples = apples.Select(x => x + a)
                                    .Count(x => x >= s && x <= t);
            var countOranges = oranges.Select(x => x + b)
                                     .Count(x => x >= s && x <= t);

            var result =  new int[] {countApples, countOranges};

            return result;
        }
    }
}