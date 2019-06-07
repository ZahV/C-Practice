using System;


/*Complete the function rotLeft in the editor below. It should return the resulting array of integers.

rotLeft has the following parameter(s):

An array of integers .
An integer , the number of rotations.
*/

namespace ArraysLeftRotation
{
    internal class Program
    {
        private static int[] RotLeftXTimes(int[] a, int d)
        {
            var rotatedArray = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                var newIndex = (i + d) % a.Length;
                rotatedArray[i] = a[newIndex];

            }
            return rotatedArray;
        }



        private static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
            int[] result = RotLeftXTimes(a, d);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
