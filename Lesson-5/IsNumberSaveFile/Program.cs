/*
 * Задание 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */
using System;
using System.IO;

namespace IsNumberSaveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что хотите");
            string text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);
        }
    }
}
