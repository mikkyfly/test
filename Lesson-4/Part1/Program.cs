/*
 * Написать метод GetFullName(string firstName, string lastName, string patronymic),
 * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу,
 * выводящую в консоль 3–4 разных ФИО. 
 */
using System;

namespace FullNamePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            InFullName();
            InFullName();
            InFullName();

        }

        static void GetFullName(string firstName, string lastName, string patronimic)
        {
            
            string fName = firstName;
            
            string lName = lastName;
            
            string patr = patronimic;

            Console.WriteLine($"{fName} {lName} {patr}"); 
        }
        static void InFullName()
        {
            Console.WriteLine("Введите Имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите Отчество");
            string patronimic = Console.ReadLine();
            GetFullName(firstName, lastName, patronimic);
        }

    }
}
