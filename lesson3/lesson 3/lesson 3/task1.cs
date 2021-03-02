using System;

namespace lesson_3
{
    class task1
    {

        //Написать программу, выводящую элементы двухмерного массива по диагонали.
        //
        static void Main(string[] args)
        {

            // Объявляем двумерный массив
            int[,] myArr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            
            // перебираем элементы массива и выводим те, индексы которых совпадают: т.е. по диагонали
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                   if (i == j)
                    { 
                    Console.Write(myArr[i, j]);
                    }
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }
}
