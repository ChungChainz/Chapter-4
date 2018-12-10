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

namespace RockPaperScissors.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            string inputPlayer1;
            string inputPlayer2;
            string golem = "r";
            string pichachu = "p";
            string scizor = "s";
            const int MIN = 1;
            const int MAX = 4;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(MIN, MAX);

            inputPlayer1 = txtChoice.Text;
            inputPlayer2 = txtChoice2.Text;
            if (randomNumber == 1)
            {
                txtChoice2.Text = "r";
            }
            if (randomNumber == 2)
            {
                txtChoice2.Text = "p";
            }
            if (randomNumber == 3)
            {
                txtChoice2.Text = "s";
            }

            inputPlayer1 = txtChoice.Text;
            inputPlayer2 = txtChoice2.Text;
            if (inputPlayer1 == golem && inputPlayer2 == scizor)
            {
                lblWinOrLose.Text = "YOU WON THE BATTLE";
                lblWinOrLose2.Text = "BETTER LUCK NEXT TIME";
                picGolem1.Visible = true;
                picGolem2.Visible = false;
                picPichachu1.Visible = false;
                picPichachu2.Visible = false;
                picScizor1.Visible = false;
                picScizor2.Visible = true;
             }
            else if (inputPlayer1 == pichachu && inputPlayer2 == golem)
            {
                lblWinOrLose.Text = "YOU WON THE BATTLE";
                lblWinOrLose2.Text = "BETTER LUCK NEXT TIME";
                picGolem1.Visible = false;
                picGolem2.Visible = true;
                picPichachu1.Visible = true;
                picPichachu2.Visible = false;
                picScizor1.Visible = false;
                picScizor2.Visible = false;
            }
            else if (inputPlayer1 == scizor && inputPlayer2 == pichachu)
            {
                lblWinOrLose.Text = "YOU WON THE BATTLE";
                lblWinOrLose2.Text = "BETTER LUCK NEXT TIME";
                picGolem1.Visible = false;
                picGolem2.Visible = false;
                picPichachu1.Visible = false;
                picPichachu2.Visible = true;
                picScizor1.Visible = true;
                picScizor2.Visible = false;
            }
            else if (inputPlayer1 == scizor && inputPlayer2 == golem)
            {
                lblWinOrLose.Text = "BETTER LUCK NEXT TIME";
                lblWinOrLose2.Text = "YOU WON THE BATTLE";
                picGolem1.Visible = false;
                picGolem2.Visible = true;
                picPichachu1.Visible = false;
                picPichachu2.Visible = false;
                picScizor1.Visible = true;
                picScizor2.Visible = false;
            }
            else if (inputPlayer1 == golem && inputPlayer2 == pichachu)
            {
                lblWinOrLose.Text = "BETTER LUCK NEXT TIME";
                lblWinOrLose2.Text = "YOU WON THE BATTLE";
                picGolem1.Visible = true;
                picGolem2.Visible = false;
                picPichachu1.Visible = true;
                picPichachu2.Visible = false;
                picScizor1.Visible = false;
                picScizor2.Visible = false;
            }
            else if (inputPlayer1 == pichachu && inputPlayer2 == scizor)
            {
                lblWinOrLose.Text = "BETTER LUCK NEXT TIME";
                lblWinOrLose2.Text = "YOU WON THE BATTLE";
                picGolem1.Visible = false;
                picGolem2.Visible = false;
                picPichachu1.Visible = true;
                picPichachu2.Visible = false;
                picScizor1.Visible = false;
                picScizor2.Visible = true;
            }

            else if (inputPlayer1 == scizor && inputPlayer2 == scizor)
            {
                lblWinOrLose.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                lblWinOrLose2.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                picGolem1.Visible = false;
                picGolem2.Visible = false;
                picPichachu1.Visible = false;
                picPichachu2.Visible = false;
                picScizor1.Visible = true;
                picScizor2.Visible = true;
            }
            else if (inputPlayer1 == pichachu && inputPlayer2 == pichachu)
            {
                lblWinOrLose.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                lblWinOrLose2.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                picGolem1.Visible = false;
                picGolem2.Visible = false;
                picPichachu1.Visible = true;
                picPichachu2.Visible = true;
                picScizor1.Visible = false;
                picScizor2.Visible = false;
            }
            else if (inputPlayer1 == golem && inputPlayer2 == golem)
            {
                lblWinOrLose.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                lblWinOrLose2.Text = "BOTH POKEMON FALL AT THE SAME TIME!";
                picGolem1.Visible = true;
                picGolem2.Visible = true;
                picPichachu1.Visible = false;
                picPichachu2.Visible = false;
                picScizor1.Visible = false;
                picScizor2.Visible = false;
            }
            
        }
       
    }
}
