using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            string gpa;
            double gpaValue;
            string test;
            double testValue;

            WriteLine("Please enter your high school GPA here>>>");
            gpa = ReadLine();
            gpaValue = Convert.ToDouble(gpa);

            WriteLine("Please enter your admission test score here>>>");
            test = ReadLine();
            testValue = Convert.ToDouble(test);

            if (gpaValue >= 3 && testValue >= 60 || gpaValue <= 3 && testValue >= 80)
            {
                WriteLine("Approved");
            }
            else
            {
                WriteLine("Reject");
            }


        }
    }
}
