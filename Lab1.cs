using System;

namespace LabPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input
            String numOne = "";
            String numTwo = "";


            Console.Write("Enter your first three digit whole number: ");
            numOne = Console.ReadLine();


            Console.Write("Enter your second three digit whole number: ");
            numTwo = Console.ReadLine();


            if(numOne.Length != numTwo.Length)
            {
                Console.WriteLine("Error: number of digits do not match\nTry again\n");
                //  \n is like in line styling and gives you a new line
            }

            for (int i = 0; i < 1; i++)
            {
                int sumOne = Int32.Parse(numOne);
                int sumTwo = Int32.Parse(numTwo);


                if ((numOne[0] + numTwo[0]) == (numOne[1] + numTwo[1]) && (numOne[1] + numTwo[1]) == (numOne[2] + numTwo[2]))
                {
                    Console.WriteLine("TRUE! Sums were the same.");
                }
                else
                {
                    Console.WriteLine("FALSE! Sums were not the same.");
                }

                {
                    Console.WriteLine("\nPress any key to exit. ");
                    Console.ReadKey();
                }
            }
        }
    }
}

       
