using System;
using System.Collections.Generic;

namespace Converter2
{

    public class Converter
    {
        private Dictionary<string, double> currencies = new Dictionary<string, double>()
        {
            {"BGN", 1},
            {"USD", 1.72960108},
            {"EUR", 1.95566514},
            {"GBP", 2.23406519},
        };

        public double Convert(double amount, string y, string z)
        {
            try
            {
                return amount * currencies[y] / currencies[z];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("One of the currencies you are entering does not exist. Tell that lazy fuck to add it.");
                throw;
            }
            
        }
    }
}