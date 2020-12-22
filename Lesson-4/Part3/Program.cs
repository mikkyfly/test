/*
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
 * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
 * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
 * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
 */

using System;
using System.Collections.Generic;

namespace SeasonsPart3
{
    class Program
    {
        enum Season 
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц");
            int month = Convert.ToInt32(Console.ReadLine());
            CallSeason(month);
        }
        static void CallSeason(int month)
        {
            
            switch (month)
            {
                case 1: //January
                    Season seasonsJanuary;
                    seasonsJanuary = Season.Winter;
                    Console.WriteLine(seasonsJanuary + " Зима");
                    break;
                case 2: //February
                    Season seasonsFebruary;
                    seasonsFebruary = Season.Winter;
                    Console.WriteLine(seasonsFebruary + " Зима");
                    break;
                case 3: //March
                    Season seasonsMarch;
                    seasonsMarch = Season.Spring;
                    Console.WriteLine(seasonsMarch + " Весна");
                    break;
                case 4: //April
                    Season seasonsApril;
                    seasonsApril = Season.Spring;
                    Console.WriteLine(seasonsApril + " Весна");
                    break;
                case 5: //May
                    Season seasonsMay;
                    seasonsMay = Season.Spring;
                    Console.WriteLine(seasonsMay + " Весна");
                    break;
                case 6: //June
                    Season seasonsJune;
                    seasonsJune = Season.Summer;
                    Console.WriteLine(seasonsJune + " Лето");
                    break;
                case 7: //July
                    Season seasonsJuly;
                    seasonsJuly = Season.Summer;
                    Console.WriteLine(seasonsJuly + " Лето");
                    break;
                case 8: //August
                    Season seasonsAugust;
                    seasonsAugust = Season.Summer;
                    Console.WriteLine(seasonsAugust + " Лето");
                    break;
                case 9: //September
                    Season seasonsSeptember;
                    seasonsSeptember = Season.Autumn;
                    Console.WriteLine(seasonsSeptember + " Осень");
                    break;
                case 10: //October
                    Season seasonsOctober;
                    seasonsOctober = Season.Autumn;
                    Console.WriteLine(seasonsOctober + " Осень");
                    break;
                case 11: //November
                    Season seasonsNovember;
                    seasonsNovember = Season.Autumn;
                    Console.WriteLine(seasonsNovember + " Осень");
                    break;
                case 12: //December
                    Season seasonsDecember;
                    seasonsDecember = Season.Winter;
                    Console.WriteLine(seasonsDecember + " Зима");
                    break;
                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }


            


        }

    }
}
