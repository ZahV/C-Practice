using System;

namespace CountingValleys
{
    internal class Program
    {
        private static int CountingValleys(int n, string s)
        {
            var terrain = s.ToLower().ToCharArray();

            int valleys = 0;

            int currentLvl = 0;

            for (int i = 0; i < terrain.Length; i++)
            {
                if (terrain[i] == 'u')
                {
                    currentLvl++;
                }

                if (terrain[i] == 'd')
                {
                    currentLvl--;
                }

                if (currentLvl == 0 && terrain[i] == 'u')
                {
                    valleys++;
                }
            }

            return valleys;
        }

        private static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = CountingValleys(n, s);

            Console.WriteLine(result);


        }
    }
}
