using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter no less than five numbers separated by a comma :");

            string input = Console.ReadLine();

            string[] list = input.Split(new char[] {','});

            int[] numbers = new int[list.Length];

            if (numbers.Length >=5 && !string.IsNullOrWhiteSpace(input))
            {

                for (int i = 0; i < list.Length; i++)
                {

                    numbers[i] = Convert.ToInt32(list[i]);


                }

                Array.Sort(numbers);

                Console.WriteLine("The lowest numbers from the provided list are {0},{1},{2}", numbers[0], numbers[1],
                    numbers[2]);

            }
            else
            {
                Console.WriteLine("Invalid List");
            }
        }
    }

        
    
}
