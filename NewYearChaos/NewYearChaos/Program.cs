using System;

namespace NewYearChaos
{
    internal class Program
    {
        private static void MinimumBribes(int[] q)
        {
            int bribe = 0;
            bool isChaotic = false;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    isChaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        bribe++;
            }
            if (isChaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(bribe);



        }

        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());



            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));

                MinimumBribes(q);
            }


        }
    }
}
