using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            string windSpeed;
            double speedValue;
            WriteLine("Please enter the windspeed to figure out the a hurricane's category here (in mph)>>>");
            windSpeed = ReadLine();
            speedValue = Convert.ToDouble(windSpeed);

            if(speedValue >= 157)
            {
                WriteLine("Category 5 Hurricane");
            }
            if (speedValue >= 133 && speedValue < 157)
            {
                WriteLine("Category 4 Hurricane");
                  
            }
            if (speedValue >= 111 && speedValue < 133)
            {
                WriteLine("Category 3 Hurricane");

            }
            if (speedValue >= 96 && speedValue < 111) 
            {
                WriteLine("Category 2 Hurricane");

            }
            if (speedValue >= 74 && speedValue < 96)
            {
                WriteLine("Category 1 Hurricane");

            }
            else if (speedValue < 74)
            {
                WriteLine("It's not a Hurricane");
            }





        }
    }
}
