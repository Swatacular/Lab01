using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////// Variable Definitions //////

            string inputLength;
            string inputWidth; //Could use 1 input and convert it right away, but I seperated the processing down below.
            string inputHeight;
            double roomLength;
            double roomWidth;
            double roomHeight;
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("All Distances are in feet.");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter Length: ");
                inputLength = Console.ReadLine();
                Console.Write("Enter Width: ");
                inputWidth = Console.ReadLine();
                Console.Write("Enter Height: ");
                inputHeight = Console.ReadLine();

                //////////// Processing //////////////

                //// try/catch converting strings to ints ////
                roomLength = ConvertStringToInt(inputLength);
                roomWidth = ConvertStringToInt(inputWidth);
                roomHeight = ConvertStringToInt(inputHeight);

                //////////// Output and Loop ////////////////

                Console.WriteLine();
                Console.WriteLine("Area: " + roomLength * roomWidth);
                Console.WriteLine("Perimeter: " + (roomLength * 2 + roomWidth * 2));
                Console.WriteLine("Volume: " + (roomLength * roomWidth * roomHeight));
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

        //try and catch for input
        public static double ConvertStringToInt(string input)
        {
            double convertedString;
            try
            {
                convertedString = Convert.ToDouble(input);
            }
            catch
            {
                Console.WriteLine("A number you entered was a invalid number, setting to 1 and continuing");
                convertedString = 1;
            }
            return convertedString;
        }
    }
}