using System;

namespace LabPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input
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
                    //  \n is like in line styling and gives you a new line
                }
            } 

            while (num1.Length != num2.Length);


            int sum1 = sumOfDigits(Int32.Parse(num1));
            //will pass sum1
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

        public static int sumOfDigits(int number)  //exm if input number = 123
        //create a function to reuse and then return int from a string; manipulate string as int
        {
            //modulo opperation % returns the remainder of the divide
            int divisor = 10;
            int sum = 0;



            int aDigit = number % divisor;  // 123 % 10 = 3

            while (aDigit != 0)
            {
                sum = sum + aDigit;
                number = number / divisor;
                aDigit = number % divisor;
                //true division to return an int; 123/10 = 12.3 so number is 12
                //loop around at the while loop
            }
            return sum;
            //need to add a iterative statment and for loop. still working on that ¯\_(ツ)_/¯
        }
    }
}
