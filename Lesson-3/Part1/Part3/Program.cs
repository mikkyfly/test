/*========================================================================================================
 * 3. Написать программу, выводящую введённую пользователем
 * строку в обратном порядке (olleH вместо Hello).
 *========================================================================================================*/

using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
        
    }
}
