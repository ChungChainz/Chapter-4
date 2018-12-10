using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            double value;
            
            WriteLine("Enter the value of your purchase");
            inputValue = ReadLine();
            value = Convert.ToDouble(inputValue);
            
            if (value > 5000)
            {
                WriteLine("ERROR 404");
            }
            else
            {
                WriteLine("Approved");
            }
        }
    }
}
