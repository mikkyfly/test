/*
 * Задание 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */
using System;
using System.IO;

namespace IsNumberRndSaveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 255");
            int numb = Convert.ToInt32(Console.ReadLine());
            string path = @"C:\Users\m.shikovskii\Desktop\test.dat";
            if (numb>=0 || numb<=255)
            {
                try
                {
                    // создаем объект BinaryWriter
                    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                    {
                        // записываем в файл значение каждого поля структуры
                        writer.Write(numb);
                        
                    }
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неккоректное число");
            }
            
        }
    }
}
