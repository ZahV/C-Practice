using System;

namespace _2DArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[][] array = new int[6][];
            int max = int.MinValue;
            int temp;


            //populating the values in the array


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int value = Int32.Parse(Console.ReadLine());
                    array[i][j] = value;
                }
            }
            // [j=1] [j=2] [j=3]//i=1
            //       [j=1]      //i=2
            // [k=1] [k=2] [k=3]//i=3
            // i = rows , j = columns
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp = array[i][j] + array[i][j + 1] + array[i][j + 2] + array[i + 1][j + 1] + array[i + 2][j] +
                           array[i + 2][j + 1] + array[i + 2][j + 2];
                    max = Math.Max(temp, max);
                }
            }

            Console.WriteLine(max);
        }
    }
}
