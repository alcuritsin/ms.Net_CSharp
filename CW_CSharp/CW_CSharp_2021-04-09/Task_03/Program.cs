//ToDo: Задание 03
/*
   Дан двумерный массив размерностью 5×5, заполненный случайными числами
из диапазона от –100 до 100.

Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
 */
using System;

namespace Task_03
{
    class Program
    {
        static void Main()
        {
            int row = 5;
            int col = 5;

            int min_val = -100;
            int max_val = 100;

            int[,] A = new int[row, col];

            Random rand = new Random();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    A[r, c] = rand.Next(min_val, max_val);
                }
            }

            Console.WriteLine("Массив `A`");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write($"{A[r, c]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int max = min_val; int min = max_val;   //  Заведомо неверные значения :)
            int row_max = 0; int col_max = 0;   //  Координаты максимального значения. Т.е. строка и столбец.
            int row_min = 0; int col_min = 0;   //  Координаты минимального значения. Т.е. строка и столбец.

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (A[r, c] > max)
                    {
                        //  Значение массива больше запомненого максимального значения
                        row_max = r;    //  Запоминаем строчку
                        col_max = c;    //  Запоминаем колонку
                        max = A[r, c];  //  Запоминаем новое максимальное значение
                    }
                    if (A[r,c] <min)
                    {
                        //  Значение массива меньше запомненого минимального значения
                        row_min = r;    //  Запоминаем строку
                        col_min = c;    //  Запоминаем колонку
                        min = A[r, c];  //  Запоминаем новое минимальное значение
                    }
                }
            }

            Console.WriteLine($"Максимальное значение A [{row_max + 1},{col_max + 1}] = {max}");
            Console.WriteLine($"Минимальное значение A [{row_min + 1},{col_min + 1}] = {min}\n");
            
            //  Левый верхний угол области суммирования -- A[row_min,col_min]
            //  Правый нижний угол области суммирования -- A[row_max,col_max]
            if (row_max<row_min)
            {
                row_max ^= row_min;
                row_min ^= row_max;
                row_max ^= row_min;
            }
            if (col_max<col_min)
            {
                col_max ^= col_min;
                col_min ^= col_max;
                col_max ^= col_min;
            }

            int summ_area = 0;
            for (int r = row_min; r <= row_max; r++)
            {
                for (int c = col_min; c <= col_max; c++)
                {
                    summ_area += A[r, c];
                }
            }

            Console.WriteLine($"Сумма области A [{row_min + 1}, {col_min + 1}] : A [{row_max + 1}, {col_max + 1}] = {summ_area}");
        }
    }
}
//Signature - подпись
/*
-------------------------------------------
|                                         |
|   "Компьютерная академия ШАГ"           |
|   Курс: PD_011                          |
|   Предмет: Платформа Microsoft .NET     |
|            и язык программирования C#   |
|                                         |
|   Исполнитель: Курицын Алексей          |
|   Преподаватель: Старинин Андрей        |
|                                         |
|   Екатеринбург - 2021                   |
|                                         |
-------------------------------------------*/
