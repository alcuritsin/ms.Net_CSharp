using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size = 5;
            var A = new double[size];

            int row = 3;
            int column = 4;
            var B = new double[row, column];

            Console.WriteLine("Ввод одномерного массива:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i}-й эл-т:");
                A[i] = Convert.ToDouble( Console.ReadLine());
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            Console.WriteLine("Вывод массива A:");
            foreach (var item in A)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("Вывод двумерного массива B:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                   Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }

            //Найти в данных массивах общий максимальный элемент, минимальный элемент
            double comm_max=0;
            double comm_min=0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int n = 0; n < size; n++)
                    {
                        if (A[n] == B[row, column])
                        {
                            if (A[n] > comm_max) comm_max = A[n];
                            if (A[n] < comm_min) comm_min = A[n];
                        }
                    }
                }
            }
            if (comm_max != 0) Console.WriteLine($"Макс.общее = {comm_max}");
            else Console.WriteLine("Возможно нет общего максимального числа");

            if (comm_min != 0) Console.WriteLine($"Мин.общее = {comm_min}");
            else Console.WriteLine("Возможно нет общего минимального числа");

            //Найти в данных массивах общую сумму всех элементов
            double A_summ=0;
            double B_summ=0;

            for (int i = 0; i < size; i++)
            {
                A_summ += A[i];
            }
            Console.WriteLine($"Сумма эл-тов массива A = {A}");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    B_summ += B[i, j];
                }
            }
            Console.WriteLine($"Сумма эл-тов массива B = {B}");

            //общее произведение всех элементов
            double A_pow = 1;
            double B_pow = 1;

            for (int i = 0; i < size; i++)
            {
                A_pow *= A[i];
            }
            Console.WriteLine($"Произведение эл-тов массива A = {A}");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    B_pow *= B[i, j];
                }
            }
            Console.WriteLine($"Произведение эл-тов массива B = {B}");

            //сумму четных элементов массива А
            double A_summ

            //сумму нечетных столбцов массива В
        }
    }
}