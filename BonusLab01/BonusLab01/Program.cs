using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string letterGrade;
            int numericalGrade;
            Console.WriteLine("Welcome to the letter Grade Converter!");

            while (true)
            {
                numericalGrade = GetAndConvertInputToInt();

                if (numericalGrade <= 60)
                {
                    letterGrade = "F";
                }
                else if (numericalGrade > 60 && numericalGrade <= 66)
                {
                    letterGrade = "D";
                }
                else if (numericalGrade > 66 && numericalGrade <= 79)
                {
                    letterGrade = "C";
                }
                else if (numericalGrade > 79 && numericalGrade <= 87)
                {
                    letterGrade = "B";
                }
                else if (numericalGrade > 87)
                {
                    letterGrade = "A";
                }
                else letterGrade = "ERROR";
                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                ConsoleKeyInfo inputContinue = Console.ReadKey();
                if (inputContinue.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                }
                else break;
            }
        }
        public static int GetAndConvertInputToInt()
        {
            string input;
            int convertedString;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter a numerical grade: ");
                input = Console.ReadLine();
                try
                {
                    convertedString = Convert.ToInt32(input);
                    if (convertedString > 100 || convertedString < 0)
                    {
                        Console.WriteLine("A number you entered was a invalid number, please try again");
                        convertedString = 1;
                    }
                    return convertedString;
                }
                catch
                {
                    Console.WriteLine("A number you entered was a invalid number, please try again.");
                }
            }

        }
    }
}
