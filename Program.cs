using System;

namespace Floating_point_program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Mantissa (8 bits): ");
            string mantissaString = Console.ReadLine();

            if (mantissaString.Length != 8)
            {
                Console.WriteLine("Sorry mantissa is the wrong size.");
                return;
            }

            Console.WriteLine("Enter Exponent (4 bits): ");
            string exponentString = Console.ReadLine();

            if (exponentString.Length != 4)
            {
                Console.WriteLine("Exponent is the wrong size.");
                return;
            }

            if (mantissaString.Substring(0, 2) != "01" && mantissaString.Substring(0, 2) != "10")
            {
                Console.WriteLine("Mantissa is not normalised.");
                return;
            }

            int mantissaInt = Convert.ToInt32(mantissaString, 2);

            int exponentInt = Convert.ToInt32(exponentString, 2);

            if (mantissaString[0] == '1')
            {
                mantissaInt -= 256;
            }

            if (exponentString[0] == '1')
            {
                exponentInt -= 16;
            }

            double mantissa = mantissaInt * Math.Pow(2, -7);
            double exponent = Math.Pow(2, exponentInt);

            double result = mantissa * exponent;

            Console.WriteLine("result: " + result);
        }
    }
}