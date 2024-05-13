using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
            return celsiusTemp;
        }

        public static double CelsiusToFahrenheit(double celsiusTemp)
        {
            double fahrenheitTemp = (9 / 5 * celsiusTemp) + 32;
            return fahrenheitTemp;
        }
    }
}
