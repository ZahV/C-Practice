using System;

namespace Converter
{
    partial class Program
    {

        static void Main(string[] args)
        {
            
            Currency currency = new Currency();

            Console.WriteLine("Please enter a currency to be converted :");
            string type = Console.ReadLine();
            Console.WriteLine("Please enter the amount :");
            double ammount = Double.Parse(Console.ReadLine());

            currency.ConvertFrom(type, ammount);

            Console.WriteLine("Please enter a currency so the previously entered amount can be converted.");
            string type1 = Console.ReadLine();
            Console.WriteLine($"{ammount} {type} = {currency.ConvertTo(type1)} {type1}");
            
        }
    }
}
 