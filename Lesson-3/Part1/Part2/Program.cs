/*============================================================================
 * 2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, 
 * хранящий список телефонных контактов: первый элемент хранит имя контакта,
 * второй — номер телефона/email.
 *===========================================================================*/

using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] phoneBook = new string[5, 2];
            
            MethodInOut(out phoneBook[0, 0],out  phoneBook[0, 1]);            

            MethodInOut(out phoneBook[1, 0], out phoneBook[1, 1]);            

            MethodInOut(out phoneBook[2, 0], out phoneBook[2, 1]);            

            MethodInOut(out phoneBook[3, 0], out phoneBook[3, 1]);            

            MethodInOut(out phoneBook[4, 0], out phoneBook[4, 1]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++) 
                {
                    Console.WriteLine($"{phoneBook[i, j]}");
                }
                //Console.WriteLine();
            }
        }

        static void MethodInOut(out string name, out string numberPhone)
        {
            Console.WriteLine("Введите название контакта");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона");
            numberPhone = Console.ReadLine();
        }


    }
}
