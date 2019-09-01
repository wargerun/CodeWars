using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Test.Tasks
{
    public static class SumDigPower
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> res = new List<long>();
            for (long i = a; i <= b; i++)
            {
                int[] val = i.ToString().Select(x => int.Parse(x.ToString())).ToArray();
                double sum = 0;

                for (int j = 0; j < val.Length;)
                {
                    sum += Math.Pow(val[j], ++j);
                }


                if (sum == i)
                    res.Add((long)sum);
            }

            return res.ToArray();
        }
    }
}