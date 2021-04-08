//ToDo:   Задание 02   --done
/*
   Ввести с клавиатуры номер трамвайного билета (6-значное
число) и про-верить является ли данный билет счастливым
(если на билете напечатано шестизначное число, и сумма
первых трёх цифр равна сумме последних трёх, то этот
билет считается счастливым).
 */
using System;
using System.Text; //Для использования StringBuilder

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("###  Задание 02   ###\n");

            Console.WriteLine("***   Проверка трамвайного билета.   ***\n");
            Console.Write("Введите номер билета (6 цифр):");

            //  Принимаем только цифры
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo cki;
            int char_counter = 0;   //  Счетчик количества символов. Для ограничения длинны строки ввода
            while ((cki = Console.ReadKey(true)).Key != ConsoleKey.Enter || char_counter != 6)   //  Пока не нажали Enter и Пока не ввели шесть цифр
            {
                char k = cki.KeyChar;   //  Временный буфер для хранения нажатой клавиши
                if (Char.IsDigit(k) || cki.Key == ConsoleKey.Backspace) // Принимать только цыфры и клавишу Backspase
                {
                    if (char_counter >=0 && char_counter <= 5 || cki.Key == ConsoleKey.Backspace)
                    {
                        Console.Write(k);   //  Выводим в консоль символ
                        sb.Append(k);   // Добавляем к буферу цифру
                        if(cki.Key == ConsoleKey.Backspace)
                        {
                            Console.Write(" ");   //  Стираем символ
                            Console.Write(k);   //  Возвращаем каретку
                            char_counter--;
                        }
                        else
                        {
                            char_counter++;
                        }
                    }
                }
            }

            string ticket_number = sb.ToString(); //    Номер билета
            int lucky_number = 0;   //  Билет счястливчик.
            for (int i = 0; i < 6/2; i++)
            {
                lucky_number += ticket_number[i] - ticket_number[i + 3];
            }

            Console.WriteLine("\n");
            Console.WriteLine((lucky_number == 0) ? "Билет счастливый!" : "Билет обычный...");
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