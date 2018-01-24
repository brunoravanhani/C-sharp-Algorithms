using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritms
{
    public class Sorting
    {

        class BigSortingComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {

                if (x.Length < y.Length) 
                {
                    return -1;
                }
                
                if (x.Length > y.Length)
                {
                    return 1;
                }
                return String.Compare(x,y);
                
            }
        }

        public string[] BigSorting(string[] arr)
        {
            Array.Sort(arr, (x, y) => {
                if (x.Length != y.Length)
                {
                    return x.Length - y.Length;
                }
                return String.CompareOrdinal(x,y);
            });
            return arr;
        }

        public int SimpleSearchig(int V, int[] arr) 
        {
            return Array.IndexOf(arr, V);
        }

        public int[] InsertionSort1(int n, int[] arr) 
        {
            var last = arr.Last();
            for (int i = arr.Length - 2; i >= 0;i--) 
            {
                if (last < arr[i]) 
                {
                    arr[i + 1] = arr[i];
                    arr[i] = last;
                } else {
                    break;
                }
            }
            return arr;
        }

        public int[] InsertionSort2(int n, int[] arr)
        {                        

            for (int i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                int position = i;

                for (int j = i; j >= 0; j--) 
                {
                    if (value < arr[j])
                    {
                        arr[position] = arr[j];
                        arr[j] = value;
                        position = j;
                    }
                }
            }
            
            return arr;
        }

        public int RunningTime(int[] arr) 
        {
            var shifts = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                int position = i;

                for (int j = i; j >= 0; j--) 
                {
                    if (value < arr[j])
                    {
                        arr[position] = arr[j];
                        arr[j] = value;
                        position = j;
                        shifts++;
                    }
                }
            }
            
            return shifts;
        }

        public int[] QuickSort(int[] arr)
        {
            var p = arr[0];
            List<int> left = new List<int>();
            List<int> equal = new List<int>();
            List<int> right = new List<int>();
            equal.Add(p);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < p) 
                {
                    left.Add(arr[i]);
                } else if (arr[i] > p)
                {
                    right.Add(arr[i]);
                } else 
                {
                    equal.Add(arr[i]);
                }
            }
            return left.Concat(equal).Concat(right).ToArray();
        }

        public int[] CountingSort(int n, int[] arr)
        {
            int[] counts = new int[n];
            
            for (int i = 0; i < arr.Length; i++) 
            {
                counts[arr[i]]++;
            }

            return counts;
        }

        public int[] CountingSort2(int n, int[] arr)
        {
            int[] counts = new int[n];
            
            for (int i = 0; i < arr.Length; i++) 
            {
                counts[arr[i]]++;
            }

            List<int> ordened = new List<int>();
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    ordened.Add(i);
                }
            }

            return ordened.ToArray();
        }

        public string FullCountingSort(int n, string[] arr) 
        {
            int length = arr.Length;
            int[] keys = new int[length];
            string[] values = new string[length];
            
            for (int i = 0; i < length; i++) {
                keys[i] = Convert.ToInt32(arr[i].Split(' ')[0]);
                values[i] = i < length/2 ? "-" : arr[i].Split(' ')[1];
            }

            int[] counts = new int[keys.GroupBy(x => x).Count()];

            for (int i = 0; i < keys.Length; i++)
            {
                counts[keys[i]]++;
            }

            List<string> strValues = new List<string>();
            string result = "";
            
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < keys.Length; j++) {
                    if (keys[j] == i){
                        result += values[j] + " ";
                    }
                }
            }

            return result.Trim();
        }

        public int[] ClosestNumber (int[] arr)
        {
            int length = arr.Length;
            int minAbs = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < length; i++) 
            {
                var val = arr[i];
                if (i + 1 >= length) {
                    break;
                }
                for (int j = i + 1; j < length; j++)
                {
                    var abs = Math.Abs(val - arr[j]);

                    if (minAbs == 0 && abs != 0) {
                        minAbs = abs;
                        result.Add(val);
                        result.Add(arr[j]);
                    } else if (abs != 0 && minAbs == abs) 
                    {
                        result.Add(val);
                        result.Add(arr[j]);
                    } else if (abs < minAbs)
                    {
                        minAbs = abs;
                        result.Clear();
                        result.Add(val);
                        result.Add(arr[j]);
                    }

                }
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
