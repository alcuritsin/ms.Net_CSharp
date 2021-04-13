//ToDo: Задание 01
/*
   Объявить одномерный (5 элементов ) массив с именем A
и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. --done

Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
а двумерный массив В случайными числами с помощью циклов. --done

Вывести на экран значения массивов: массива А в одну строку,
массива В — в виде матрицы. --done

Найти в данных массивах:
    --  общий максимальный элемент,
    --  общий минимальный элемент,

    --  общую сумму всех элементов,
    --  общее произведение всех элементов,

    --  сумму четных элементов массива А,
    --  сумму нечетных столбцов массива В.
 */
using System;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            int n = 5;
            double[] A = new double[n];

            int row = 3;
            int col = 4;
            double[,] B = new double[row, col];
            Random rand = new Random();

            //  Заполнение
            Console.WriteLine("Введите дробные значения массива `A`");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i + 1}] = "); A[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    B[i, j] = rand.NextDouble();
                }
            }

            //  Вывод
            Console.WriteLine("Массив `A`");
            foreach (double item in A)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Массив `B`");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //  Поиск общего в массивах
            double comm_max = 0;
            double comm_min = 0;
            bool comm = false;  //  Есть общие значения

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] == B[r,c]) //  Найдено общее значение.
                        {
                            comm = true;
                            if (comm_max<A[i])
                            {
                                comm_max = A[i]; // Максимальное
                            }
                            if (comm_min>A[i])
                            {
                                comm_min = A[i];    //  Минимальное
                            }
                        }
                    }
                }
            }

            if (!comm)
            {
                Console.WriteLine($"Максимальное общее число: {comm_max}");
                Console.WriteLine($"Минимальное общее число: {comm_min}");
            }
            else
            {
                Console.WriteLine("Общих значений не обнаружено :(");
            }

            //  Сумма и произведение значений массива
            double sum = 0;
            double mul = 1;

            for (int i = 0; i < n; i++)
            {
                sum += A[i];
                mul *= A[i];
            }

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    sum += B[r, c];
                    mul *= B[r, c];
                }
            }
            Console.WriteLine($"Общая сумма элементов массивов: {sum}");
            Console.WriteLine($"Общее произведение элементов массивов: {mul}");

            //  Суммы четных элементов массива `A`
            double sum_even = 0;

            for (int i = 0; i < n; i++)
            {
                if (i%2 == 0)
                {
                    sum_even += A[i];
                }
            }

            Console.WriteLine($"Сумма четных элементов массива `A`: {sum_even}");

            //  Сумма нечетных столбцов массива `В`
            double summ_odd = 0;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c%2 != 0)
                    {
                        summ_odd += B[r, c];
                    }
                }
            }

            Console.WriteLine($"Сумма елементов нечетных столбцов массива `В`: {sum_even}");
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
