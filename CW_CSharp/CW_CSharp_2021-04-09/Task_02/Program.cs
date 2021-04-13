//ToDo: Задание 02
/*
   Подсчитать количество слов во введенном предложении.
 */
using System;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Введите предложение:");
            str = Console.ReadLine();

            string[] words = str.Split(' ');

            int count_words = 0;

            foreach (var word in words)
            {
                if (word.Length>0)
                {
                    count_words++;
                }
            }

            Console.WriteLine($"Слов в строке: {count_words}");
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