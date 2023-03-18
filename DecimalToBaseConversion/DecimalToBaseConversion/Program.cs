using System;

namespace DecimalToBaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 2)
            {
                Console.WriteLine("Invalid arguments. Please provide an integer in decimal and a new base number system.");
                return;
            }

            int decimalNumber;
            if (!int.TryParse(args[0], out decimalNumber))
            {
                Console.WriteLine("Invalid decimal number provided.");
                return;
            }

            int newBase;
            if (!int.TryParse(args[1], out newBase) || newBase < 2 || newBase > 20)
            {
                Console.WriteLine("Invalid new base number system provided. Please choose a number between 2 and 20.");
                return;
            }

            string convertedNumber = ConvertToBase(decimalNumber, newBase);
            Console.WriteLine($"The decimal number {decimalNumber} converted to base {newBase} is: {convertedNumber}");
        }

        static string ConvertToBase(int decimalNumber, int newBase)
        {
            string digits = "0123456789ABCDEFGHIJ";
            string result = "";
            while (decimalNumber > 0)
            {
                result = digits[decimalNumber % newBase] + result;
                decimalNumber /= newBase;
            }
            return result;
        }
    }
}
