/*
 * Задание 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */

using System;
using System.IO;

namespace WriteDataTimeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string time = Convert.ToString(DateTime.Now);
            
            try
            {
                using (var sw = new StreamWriter("startup.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(time);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }







        }
    }
}
