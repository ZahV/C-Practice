using System;

namespace MinimumSwaps2
{
    internal class Program
    {
        private static int MinimumSwaps(int[] arr)
        {
            // var swaps = 0;
            // var temp = 0;

            //// Речник в който стойността на итератора в арейа е ключ, а позицията на итератора е стойност
            // Dictionary<int, int> numberDictionary = new Dictionary<int, int>();
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     numberDictionary.Add(arr[i], i);
            // }


            // //сортиране на арейа с бъбъл сорт
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     for (int j = 0; j < arr.Length - 1; j++)
            //     {
            //         if (arr[j] > arr[j + 1])
            //         {
            //             temp = arr[j + 1];
            //             arr[j + 1] = arr[j];
            //             arr[j] = temp;
            //         }

            //     }
            // }

            // // взимам индекса на арейа преди сортирането
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     arr[i] = numberDictionary[arr[i]];

            // }

            // // правя елементите на циклите -1
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     int val = arr[i];
            //     if (val < 0) continue;
            //     while (val != i)
            //     {
            //         int new_val = arr[val];
            //         arr[val] = -1;
            //         val = new_val;
            //         swaps++;
            //     }
            //     arr[i] = -1;
            // }

            // return swaps;

            int first = 0, last = arr.Length - 1;
            int swaps = 0;
            while (first < last)
            {
                while (arr[first] == first + 1 && first < last)
                    first++;
                if (first < last)
                {
                    int temp = arr[arr[first] - 1];
                    arr[arr[first] - 1] = arr[first];
                    arr[first] = temp;
                    swaps++;
                }
            }
            return swaps;
        }

        private static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int res = MinimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}
