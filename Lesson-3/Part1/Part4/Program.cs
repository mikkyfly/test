/*========================================================================================================
 * 4. «Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O,
 * где Х — элементы кораблей, а О — свободные клетки.
 *========================================================================================================*/

using System;

namespace Part4
{
    class Program
    {

        static void Main(string[] args)
        {
            char[,] map = new char[10, 10];


            #region ships 4
            map[0, 0] = 'X';
            map[1, 0] = 'X';
            map[2, 0] = 'X';
            map[3, 0] = 'X';
            #endregion

            #region ships 3
            map[0, 2] = 'X';
            map[0, 3] = 'X';
            map[0, 4] = 'X';

            map[2, 2] = 'X';
            map[3, 2] = 'X';
            map[4, 2] = 'X';
            #endregion

            #region ships 2
            map[1, 9] = 'X';
            map[2, 9] = 'X';

            map[7, 9] = 'X';
            map[8, 9] = 'X';

            map[8, 6] = 'X';
            map[8, 7] = 'X';
            #endregion

            #region ships 1
            map[8, 1] = 'X';

            map[7, 3] = 'X';

            map[6, 7] = 'X';

            map[5, 6] = 'X';
            #endregion

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i, j] == 0)
                    {
                        Console.Write("O");
                    }
                    else
                        Console.Write(map[i, j]);                    
                }
                Console.WriteLine();

            }



        }
    }
}
