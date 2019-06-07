using System;
using System.Reflection.Metadata.Ecma335;

namespace Converter
{
    partial class Program
    {
        public class Currency
        {
            private double _dollar;
            

            public double ConvertFrom(string x, double y)
            {
                switch (x)
                {
                    case "USD":
                        return _dollar = y * 1;
                    case "BGN":
                        return _dollar = y * 0.578202;
                    case "GBP":
                        return _dollar = y * 1.292645;
                    case "EUR":
                        return _dollar = y * 1.131135;

                }

                return _dollar;
            }

            public double ConvertTo(string x)
            {
                switch (x)
                {
                    case "USD":
                        return _dollar * 1;
                    case "BGN":
                        return _dollar * 1.729098;
                    case "GBP":
                        return _dollar * 0.773604;
                    case "EUR":
                        return _dollar * 0.883945;
                }

                return _dollar;
            }
        }
    }
}