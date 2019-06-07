using Amazon;

namespace AccessModifiersExcersize
{

    class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
