/*
 * Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
 * и возвращающую число — сумму всех чисел в строке.
 * Ввести данные с клавиатуры и вывести результат на экран.
 */

using System;

namespace SumNuberPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            SumStr();
           
        }

        static void SumStr() //string numbers
        {
            Console.WriteLine("Введите числа через пробел");
            string numbers = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsNumber(numbers[i]))
                {
                    sum += Convert.ToInt32(numbers[i].ToString());
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}
