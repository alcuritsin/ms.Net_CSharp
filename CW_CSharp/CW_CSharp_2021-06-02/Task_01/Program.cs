using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            double num1 = 5.0;
            double num2 = 3.0;

            double result;
            
            //Message log;
            log = WriteToFile;

            var operation = new Actions();

            result = operation.Calc(num1, num2, Add);
            Console.WriteLine($"sum = {result}");

            result = operation.Calc(num1, num2, Ded);
            Console.WriteLine($"ded = {result}");

            result = operation.Calc(num1, num2, Div);
            Console.WriteLine($"div = {result}");

            result = operation.Calc(num1, num2, Max);
            Console.WriteLine($"max = {result}");

            result = operation.Calc(num1, num2, Min);
            Console.WriteLine($"min = {result}");
            
            result = operation.Calc(num1, num2, Mid);
            Console.WriteLine($"mid = {result}");



        }

        static double Add(double num1, double num2)
        {
            
            return num1 + num2;
        }

        static double Ded(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        static double Max(double num1, double num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        static double Min(double num1, double num2)
        {
            return num1 < num2 ? num1 : num2;
        }

        static double Mid(double num1, double num2)
        {
            return (num1 * num2) / 2;
        }

        static void WriteToFile(string msg)
        {
            using var file = new StreamWriter("temp.txt", true);
            file.WriteLine(msg);
        }
    }
}

/*
 Написать программу-калькулятор, которая выполняет следующие действия:

сложение, вычитание, умножение, деление, нахождение наибольшего и наименьшего, вычисление среднего.

Создать класс для вычисления, использовать делегаты. Постараться добавить возможность логгирования/журналирования событий/ошибок.
*/