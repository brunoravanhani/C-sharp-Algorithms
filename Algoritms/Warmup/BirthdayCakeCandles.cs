using System;
using System.Linq;

namespace Algoritms.Warmup 
{
    public class BirthdayCakeCandles
    {
        public static int Run(int[] arr)
        {
            var maxValue = arr.Max();

            return arr.Where(x => x == maxValue)
                      .Count();
            
        }
    }
}