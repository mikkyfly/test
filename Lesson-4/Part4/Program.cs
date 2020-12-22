/*
 * Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
 */

using System;

namespace NumberFibonacciPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте первое число");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(number);
            
        }
        static int Fibonacci(int number)
        {
            Console.WriteLine(number);
            if (number==0 || number==1)
            {
                return number;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            
            
        }
    }
}
