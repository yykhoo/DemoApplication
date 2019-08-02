using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Guru99Tutorial: Tutorial
    {
        public void RenameTutorial( string pName )
        {
            tutorialName = pName;
        }

        public override void Set()
        {
            tutorialName = "GURUTutorial Set";
        }

        public void displayChristmasTree(int num)
        {
            for (int i = 1; i <= num; i += 2)
            {
                int empSpace = (num - i) / 2;
                for (int j = 1; j <= empSpace; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void displayDiamond(int num)
        {
            for (int i = 1; i <= num; i += 2)
            {
                int empSpace = (num - i) / 2;
                for (int j = 1; j <= empSpace; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = ( num - 2 ); i >= 1; i -= 2)
            {
                int empSpace = ( num - i ) / 2;
                for (int j = 1; j <= empSpace; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        


    }
}
