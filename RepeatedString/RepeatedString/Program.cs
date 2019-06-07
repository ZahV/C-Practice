using System;

namespace RepeatedString
{
    internal class Program
    {
        private static double RepeatedString(string s, double n)

        {
            double counter = 0;

            foreach (char c in s)
            {
                if (c == 'a')
                {
                    counter++;
                }
            }
            counter = (counter * (n / s.Length));
            for (int i = 0; i < n % s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    counter++;
                }
            }
            return Math.Floor(counter);
        }

        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            double n = Convert.ToInt32(Console.ReadLine());

            double result = RepeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}
