using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
            
namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 11;
            string number;
            int numberValue;

           
            WriteLine("Guess a random number from 1 to 10 here>>>");
            number = ReadLine();
            numberValue = Convert.ToInt32(number);

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(MIN, MAX);
            WriteLine("The random number is " + randomNumber);
            if (numberValue < MAX && numberValue > MIN)
            {


                if (numberValue < randomNumber)
                {
                   WriteLine("Too Low");
                }
                else if (numberValue < 10 && numberValue > randomNumber)
                {
                    WriteLine("Too High");
                }
                else if (numberValue == randomNumber)
                {
                    WriteLine("Correct!");
                }
            }
            else
                WriteLine("Error!");
           
        }
    }
}
