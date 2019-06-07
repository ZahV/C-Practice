using System;
using System.Collections.Generic;
namespace ListAndArrayexcersize
{
    class Program
    {
        static void Main()
        {
            //Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.

            Console.WriteLine("Please enter your name so I can display it in reverse. YEET!. : ");
            string input = Console.ReadLine();

            char[] name = new char[input.Length];

            for (int i = input.Length; i > 0; i--)
            {

                name[input.Length - i] = input[i - 1];

                string reversed = new string(name);

                Console.WriteLine(reversed);


            }

           
        }
    }
}
