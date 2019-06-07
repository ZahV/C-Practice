using System;

namespace ReverseArray
{
    internal class Program
    {
        private static int[] ReverseArray(int[] a)
        {

            int i = 0;
            int j = a.Length - 1;
            while (i < j)
            {
                var temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            }

            return a;
        }

        private static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int[] res = ReverseArray(arr);

            Console.WriteLine(string.Join(" ", res));


        }
    }
}
