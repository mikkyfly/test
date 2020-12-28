/*
 * Задание 5.
 * Список задач (ToDo-list):
    1) написать приложение для ввода списка задач;
    2) задачу описать классом ToDo с полями Title и IsDone; {x}
    3) на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
    4) если задача выполнена, вывести перед её названием строку «[x]»;
    5) вывести порядковый номер для каждой задачи;
    6) при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
    7) записать актуальный массив задач в файл tasks.json/xml/bin.
 */
using System;

namespace TODO_list
{
    class Program
    {
        static void Main(string[] args)
        {
            TODO list = new TODO();
            Console.WriteLine();
            list.Title = Console.ReadLine();

            list.IsDone = Convert.ToChar(Console.ReadLine());
        }
    }
}
