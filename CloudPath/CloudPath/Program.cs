using System;

namespace CloudPath
{
    internal class Program
    {
        private static int JumpingOnClouds(int[] c)
        {
            int turns = 0;

            for (int i = 0; i < c.Length; i++, turns++)
            {
                if (i < c.Length - 2 && c[i + 2] == 0)
                {
                    i++;
                }
            }

            turns--;

            return turns;
        }

        private static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));


            int result = JumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}
