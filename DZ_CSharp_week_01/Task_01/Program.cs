//ToDo:   Задание 01   --done
/*  
   Написать программу, которая считывает символы с кла-
виатуры, пока не будет введена точка. Программа должна
сосчитать количество введенных пользователем пробелов.
*/
using System;

namespace DZ_C__week_1
{
    class Program
    {
        static void Main()
        {
            int space_counter = 0;
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();

                Console.WriteLine("***   Программа считывает нажатие клавишь.   ***");
                Console.WriteLine($"-- Количество нажатий клавиши `пробел`: {space_counter}");
                Console.WriteLine("-- Для завершения программы нажмите `точку`!");
                // Console.ReadKey(true) клавишу считывает, но не отображает
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    space_counter++;
                }
            } while (cki.Key != ConsoleKey.OemPeriod);

            Console.WriteLine($"\n`пробел` нажат: {space_counter} раз(-а).\n");
            Console.WriteLine("Программа завершена.");

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