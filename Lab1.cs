using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPart1
{
    class Program
    {
        static void Main(string[] args)
        {

            String num1 = "";
            String num2 = "";

            do
            {
                Console.Write("Enter first number: ");
                num1 = Console.ReadLine();

                Console.Write("Enter second number: ");
                num2 = Console.ReadLine();

                if (num1.Length != num2.Length)
                {
                    Console.WriteLine("Error: number of digits do not match\nTry again\n");
                }

            } while (num1.Length != num2.Length);

            int sum1 = sumOfDigits(Int32.Parse(num1));
            int sum2 = sumOfDigits(Int32.Parse(num2));
            //Console.WriteLine("sum1 is " + sum1);
            //Console.WriteLine("sum2 is " + sum2);

            if (sum1 != sum2)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            Console.WriteLine("\nHit any key to continue...");
            Console.ReadKey();
        }



        public static int sumOfDigits(int number)  //number = 123
        {
            int divisor = 10;
            int sum = 0;

            int aDigit = number % divisor;  // 123 % 10 = 3
            while (aDigit != 0)
            {
                sum = sum + aDigit;
                number = number / divisor;
                aDigit = number % divisor;
            }

            return sum;
        }
    }
}

