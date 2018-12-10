using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp1;
            double temp2;
            double temp3;
            double eight;
            double highNoon;
            double five;
            string inputValue;

            WriteLine("Enter what the temperature, in fahrenheit was at 8am>>> ");
            inputValue = ReadLine();
            temp1 = Convert.ToDouble(inputValue);

            WriteLine("Enter what the temperature, in fahrenheit was at 12pm>>> ");
            inputValue = ReadLine();
            temp2 = Convert.ToDouble(inputValue);

            WriteLine("Enter what the temperature, in fahrenheit was at 5pm>>> ");
            inputValue = ReadLine();
            temp3 = Convert.ToDouble(inputValue);

            eight = (temp1 * 1.8) + 32;
            highNoon = (temp2 * 1.8) + 32;
            five = (temp3 * 1.8) + 32;
            if (temp1 >= 1000)
            {
                Write("ERROR 404 ");
            }
            if (temp1 <= 32)
            {
                Write("It is freezing. ");
            }
            else if (temp1 >= 100 && temp1 < 1000)
            {
                Write("It is hot outside. ");
            }

            WriteLine("At 8am, the temperature in celsius is {0} degrees.", eight);
            if (temp2 >= 1000)
            {
                Write("ERROR 404 ");
            }

            if (temp2 <= 32)
            {
                Write("It is freezing. ");
            }
            else if (temp2 >= 100 && temp2 < 1000)
            {
                Write("It is hot outside. ");
            }
            WriteLine("At noon, the temperature in celsius is {0} degrees.", highNoon);
            if (temp3 >= 1000)
            {
                Write("ERROR 404");
            }
            if (temp3 <= 32)
            {
                Write("It is freezing. ");
            }
            else if (temp3 >= 100 && temp3 < 1000)
            {
                Write("It is hot outside. ");
            }
            WriteLine("At 5pm, the temperature in celsuis is {0} degrees.", five);




           

            

        }
    }
}
