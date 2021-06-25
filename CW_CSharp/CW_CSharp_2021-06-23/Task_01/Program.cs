using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main()
        {

            string file_name;
            do
            {
                Console.Write("Укажите существующий файл исходник:"); file_name = Console.ReadLine();
            } while (File.Exists(file_name));

            string action;
            Console.WriteLine($"Файл: {file_name} еайден.");
            Console.WriteLine("1 - 'public' заменить на 'private'");
            Console.WriteLine("2 - Строчные 's' заменить на прописные 'S'");
            Console.WriteLine("3 - Удалить отступы");
            Console.WriteLine("4 - Зашифровать > ьтаворфиншаЗ");
            Console.WriteLine("5 - Выход");
            Console.WriteLine();

            string source_line;  //  Исходный код
            string mutation_line;  //  Исходный код

            StreamReader sr;    //  Поток на чтение
            StreamWriter sw;    //  Поток на запись
            do
            {
                Console.WriteLine("Выбор действия: "); action = Console.ReadLine();

                switch (action)
                {
                    case "1":   //  'public' заменить на 'private'
                        string search_word = "public";  //  Строка для поиска
                        string sub_word = "private";    //  Заменить на ...

                        source_line = "";  //  Исходный код

                        sr = new StreamReader(file_name);
                        sw = new StreamWriter(file_name + "mutation", true);

                        while (source_line != null)
                        {
                            source_line = sr.ReadLine();
                            source_line = source_line.Replace(search_word, sub_word);
                            sw.WriteLine(source_line);
                        }

                        sr.Close(); sw.Close();

                        File.Move(file_name + "mutation", file_name, true); //  Перезапись файла исходника мутированным

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Все слова public в объявлении полей классов заменены на слово private -- выполнено.");
                        Console.ResetColor();

                        break;

                    case "2":   // Строчные 's' заменить на прописные 'S'

                        source_line = "";  //  Исходный код

                        sr = new StreamReader(file_name);
                        sw = new StreamWriter(file_name + "mutation", true);


                        while (source_line != null)
                        {
                            mutation_line = "";  // Мутация кода

                            source_line = sr.ReadLine();

                            bool first_word = true; //  Первое слово?

                            char separator = ' ';  //  Разделитель слов - пробел

                            foreach (string word in source_line.Split(separator))
                            {
                                string new_word = "";
                                if (word.Length > 2)
                                {
                                    //  Если слово длиннее двух символов
                                    //  Производим мутацию
                                    foreach (char ch in word)
                                    {
                                        if (char.IsLower(ch))
                                        {
                                            //  если символ строчная
                                            //  заменить на прописную
                                            //  добавить в накопитель нового слова
                                            new_word += char.IsUpper(ch);
                                        }
                                        else
                                        {
                                            //  иначе добавить в накопитель нового слова без изменения
                                            new_word += ch;
                                        }
                                    }
                                }
                                else
                                {
                                    //  Без мутации
                                    new_word = word;
                                }

                                if (first_word)
                                {
                                    //  Если слово первое
                                    //  Меняем метку
                                    //  Собираем мутированную строку для вывода без первого разделителя.
                                    first_word = false; // Дальше будет уже не первое слово;
                                    mutation_line += new_word;
                                }
                                else
                                {
                                    //  Иначе продолжаем сбор через разделитель.
                                    mutation_line += separator + new_word;
                                }
                            }
                            //  Запись мутированной строки во временный файл.
                            sw.WriteLine(mutation_line);
                        }

                        sr.Close(); sw.Close();

                        File.Move(file_name + "mutation", file_name, true); //  Перезапись файла исходника мутированным

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("В словах длиннее двух символов, все строчные символы заменены прописными -- выполнено.");
                        Console.ResetColor();
                        break;
                    case "3":
                        //    Также в коде программы удалить все «лишние» пробелы и табуляции,
                        //    оставив только необходимые для разделения операторов.
                        source_line = "";  //  Исходный код

                        sr = new StreamReader(file_name);
                        sw = new StreamWriter(file_name + "mutation", true);


                        while (source_line != null)
                        {
                            //  Прочитать строку из оригинала
                            source_line = sr.ReadLine();

                            mutation_line = "";  // Мутация кода

                            for (int i = 0; i < source_line.Length; i++)
                            {
                                //  Пробег по символам в строке.
                                if (source_line[i] == ' ')
                                {
                                    //  Если текущий символ пробел 
                                    if (source_line[i + 1] == ' ' || source_line[i + 1] == '\t' || source_line[i - 1] == '\t')
                                    {
                                        //  Если следующий символ пробел ИЛИ табуляция ИЛИ предидущий символ табуляция
                                        //  Пропустить
                                        continue;
                                    }
                                }
                                else if (source_line[i] == '\t' && source_line[i + 1] == '\t')
                                {
                                    //  Иначе Если текущий символ табуляция и следующий символ табляция
                                    //  Пропустить текущий
                                    continue;
                                }
                                else
                                {
                                    // Иначе добавить текущий символ в мутированный накопитель строки.
                                    mutation_line += source_line[i];
                                }
                            }

                            //  Запись мутированной строки во временный файл.
                            sw.WriteLine(mutation_line);
                        }

                        sr.Close(); sw.Close();

                        File.Move(file_name + "mutation", file_name, true); //  Перезапись файла исходника мутированным
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Удаление «лишних» пробелов и табуляций -- выполнена.");
                        Console.ResetColor();

                        break;

                    case "4":
                        //  Записать символы каждой строки программы в другой файл в обратном порядке.
                        source_line = "";  //  Исходный код

                        //  Составим новое имя файла из текущего, с учетом его расширения
                        string new_file_name;
                        string[] split_file_name = file_name.Split('.');
                        string file_type = split_file_name[split_file_name.Length - 1];

                        new_file_name = split_file_name[0];

                        for (int i = 1; i < split_file_name.Length - 2; i++)
                        {
                            new_file_name += '.' + split_file_name[i];
                        }

                        //  старое имя_mutation.тип
                        new_file_name += "_mutation" + '.' + file_type;

                        sr = new StreamReader(file_name);
                        sw = new StreamWriter(new_file_name, true);

                        while (source_line != null)
                        {
                            //  Прочитать строку из оригинала
                            source_line = sr.ReadLine();

                            mutation_line = "";  // Мутация кода

                            for (int i = source_line.Length - 1; i >= 0; i--)
                            {
                                //  Пробег по символам в строке в обратном порядке.

                                // Добавить текущий символ в мутированный накопитель строки.
                                mutation_line += source_line[i];
                            }

                            //  Запись мутированной строки во новый файл.
                            sw.WriteLine(mutation_line);
                        }

                        sr.Close(); sw.Close();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Записать символы каждой строки программы в другой файл в обратном порядке -- выполнена.");
                        Console.ResetColor();


                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Команда не распознана. Введите снова.");
                        Console.ResetColor();

                        break;

                }
            } while (action != "5");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Програма завершена.");
            Console.ResetColor();

        }

        //static string WordReplace(string source_line, string search_word, string sub_word)
        //{
        //    source_line = source_line.Replace(sea);

        //}
    }

}
//ToDo:
/*
Прочитать текст C#-программы (выбрать самостоятельно):
-   Все слова public в объявлении полей классов заменить на слово private
-   В исходном коде в каждом слове длиннее двух символов все строчные символы заменить прописными.
-   Также в коде программы удалить все «лишние» пробелы и табуляции,
    оставив только необходимые для разделения операторов.
-   Записать символы каждой строки программы в другой файл в обратном порядке.
*/

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