using System;

namespace smallestnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
         Console.Write("Enter first number: ");
         num1 = Convert.ToInt16(Console.ReadLine()); //Getting the first number
         Console.Write("Enter second number: ");
         num2 = Convert.ToInt16(Console.ReadLine()); // getting the second number
         Console.Write("Enter third number: ");
         num3 = Convert.ToInt16(Console.ReadLine()); //getting the third number
            if (num1 < num2) //IF the the first number is smaller than the second number
            {
                if (num1 < num3) //If the first number is also smaller than the third number
                {
                    Console.WriteLine("The first number is the smallest numer"); //Then the first number must be smallest as its smaller than botht the second and third numbers
                }
                else
                    Console.WriteLine("The third number is the smallest number"); //If the first number is smaller than the second number, but not smaller than the third number, the third number must be smallest
            }
            else if (num3 < num2) //We already know that the second number is smaller than the first number from the first if statment, so we just check that the third number isnt smaller
            {
                Console.WriteLine("The third number is the smallest number");
            }
            else
                Console.WriteLine("The second number is the smallest number"); //If the second number is smaller than the first number (first IF), and smaller than the third number (else if)It must be smallest                                                                         
        }
    }
}
