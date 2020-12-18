/*============================================================================
 * 1. Написать программу, выводящую элементы двумерного массива по диагонали. 
 *===========================================================================*/

using System;

namespace Part1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            char [,] matrix = new char[5, 5];

            matrix[0, 0] = 'x';
            matrix[1, 1] = 'x';
            matrix[2, 2] = 'x';
            matrix[3, 3] = 'x';
            matrix[4, 4] = 'x';

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(matrix[i, j]==0)
                    {
                        Console.Write(" ");
                    }
                    else
                    Console.Write($"{matrix[i, j]} ");                    
                }
                Console.WriteLine();
            }


        }
    }
}
