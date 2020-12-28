/*
 * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
 * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
 * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
 */

using System;
using System.Diagnostics;

namespace KillConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Process process in Process.GetProcesses())
            {
                
                Console.WriteLine($"ID: {process.Id} | Name: {process.ProcessName} | Memory: {process.VirtualMemorySize64} ");
            }
            try
            {
                Console.WriteLine("Введите проецесс который хотите остановить");
                string proccesKill = Console.ReadLine();
                foreach (Process proc in Process.GetProcessesByName(proccesKill))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
