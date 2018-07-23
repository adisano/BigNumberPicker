using System;

namespace BigNumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will pick the largest number out of 3 numbers. Please enter the first number:");
            string numberOneStr = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            string numberTwoStr = Console.ReadLine();
            Console.WriteLine("Please enter the third number:");
            string numberThreeStr = Console.ReadLine();

            int numberOneInt = int.Parse(numberOneStr);
            int numberTwoInt = int.Parse(numberTwoStr);
            int numberThreeInt = int.Parse(numberThreeStr);

            if (numberOneInt > numberTwoInt && numberOneInt > numberThreeInt)
            {
                Console.WriteLine("The first number is the largest.");
            }
            else if (numberTwoInt > numberOneInt && numberTwoInt > numberThreeInt)
            {
                Console.WriteLine("The second number is the largest.");
            }
            else
            {
                Console.WriteLine("The third number is the largest.");
            }

            Console.ReadLine();

        }
    }
}
