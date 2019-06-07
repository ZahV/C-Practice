using System;

namespace Converter2
{

    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter();

            Console.WriteLine("Please enter an amount to be converted.");
            double amount = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the currency for the amount.");
            string type = Console.ReadLine();

            Console.WriteLine("Please enter the currency to which the amount will be converted to");
            string type1 = Console.ReadLine();

            Console.WriteLine($"{amount} {type} = {conv.Convert(amount,type,type1)} {type1}");
        }
    }
}
