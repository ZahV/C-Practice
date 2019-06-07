using System;
using System.Collections.Generic;



namespace Dice1
{
    class Program {

        static void Main(string[] args)
        {

            Console.WriteLine("How many-sided of a dice are you throwing?");

            int diceSides = int.Parse(Console.ReadLine());

            Console.WriteLine("And how many of those {0}-sided dices would you like to throw?",diceSides);

            int numberOfDice = int.Parse(Console.ReadLine());

            Console.WriteLine("Which number would you like to check to see if you got it and how many times you got it? :");
            int numberSearch = int.Parse(Console.ReadLine());

            int[] dice = new int[diceSides];
            Random ran = new Random();
            List<int> duplicates = new List<int>();
            Dictionary<int, int> check = new Dictionary<int, int>();
            
           

            for (int i = 0; i < numberOfDice; i++) { 
           

                int roll = ran.Next(1, dice.Length + 1);
                duplicates.Add(roll);
            }

            int[] showDuplicates = duplicates.ToArray();

            foreach (int number in showDuplicates) {

                if (check.ContainsKey(number))
                    check[number]++;
                else
                    check[number] = 1;

            }
            foreach (var pair in check)

                if (numberSearch == pair.Key) {

                    Console.WriteLine("The number {0} has been rolled {1} times!" , pair.Key,pair.Value);


                }

        }
    }
}
