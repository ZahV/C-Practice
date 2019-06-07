using System;
using System.Collections.Generic;

namespace Socks
{
    internal class Program
    {
        private static double SockMerchant(int n, int[] ar)
        {
            double pairs = 0;

            //var uniqueColors = new List<int>();

            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (!uniqueColors.Contains(ar[i]))
            //    {
            //        uniqueColors.Add(ar[i]);
            //    }
            //    else
            //    {
            //        uniqueColors.Remove(ar[i]);
            //        pairs++;
            //    }

            //}

            //return pairs;


            Dictionary<int, double> socks = new Dictionary<int, double>();

            foreach (var color in ar)
            {
                if (socks.ContainsKey(color))
                {
                    socks[color]++;
                    continue;
                }
                socks.Add(color, 1);

            }

            foreach (var coloredPairs in socks)
            {
                pairs += Math.Floor(coloredPairs.Value / 2);
            }

            return pairs;
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[n];

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            };

            double result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}
