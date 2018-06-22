using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms.Warmup 
{
    public class MiniMaxSum
    {
        public static long[] Run(long[] arr) 
        {
            List<long> results = new List<long>();
            for (int i = 0; i < arr.Length; i++) {
                
                long sum = 0;

                for(int j = 0; j < arr.Length; j++)
                {
                    if (j != i) {
                        sum += arr[j];
                    }
                }
                results.Add(sum);
            }

            return new long[]
            {
                results.Min(),
                results.Max()
            };
        }
    }
}