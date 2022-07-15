using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExcersize
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahr)
        {

            double cel = (fahr - 32) * 5 / 9;
            return cel;
            
        }
        public static double CelsiusToFahrenheit(double cel)
        {

            double fahr = (cel * 9 / 5) + 32;
            return fahr;
        }
    }
}
