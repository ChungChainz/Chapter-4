using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace AgeInsultGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            int yes;
            int yes2;
            string ageString;
            string yesString;
            string yesString2;

            Write("Welcome to the famous Age Insult Generator!!!");
            Write("Please enter your supposed age?");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if (age < 18)
            {
                Write("You are a minor, hahahaha. And you cannot vote");
            }
             
            else if (age >= 18 && age < 25)
            {
                Write("You should be in college or done with college by now. Do not be a dead beat.");
            }
            else if (age >= 25 && age < 32)
            {
                Write("Do you have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                
                    if (yes == 1)
                        Write("Good for you.");
                    else
                        Write("Get a job hippie.");
            }
                
            
            else if (age >= 32 && age < 42)
            {
                Write("Are you over your midlife crisis yet? :)");
            }
            else if (age >= 42 && age < 55)
            {
                Write("I think I'm seeing some gray hairs up there.");
            }
            else if (age >= 55 && age < 62)
            { 
                Write("Have you retired yet? 1 for yes 2 for no");
                yesString2 = ReadLine();
                yes2 = Convert.ToInt32(yesString2);

                if (yes2 == 1)
                    Write("Congrats!");
                else
                    Write("That's rough, freedom is on your fingertips");







            }
               
        }
    }
}
