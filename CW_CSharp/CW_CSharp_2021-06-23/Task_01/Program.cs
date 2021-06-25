﻿using System;
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

            string action = "";
            Console.WriteLine($"Файл: {file_name} еайден.");
            Console.WriteLine("1 - 'public' заменить на 'private'");
            Console.WriteLine("2 - Строчные 's' заменить на прописные 'S'");
            Console.WriteLine("3 - Удалить отступы");
            Console.WriteLine("4 - Зашифровать > ьтаворфиншаЗ");
            Console.WriteLine();
            Console.WriteLine("Выбор действия: "); action = Console.ReadLine();
            
            string source_line;  //  Исходный код
            string mutation_line;  //  Исходный код

            StreamReader sr;    //  Поток на чтение
            StreamWriter sw;    //  Поток на запись

            switch (action)
            {
                case "1":   //  'public' заменить на 'private'
                    string search_word = "public";  //  Строка для поиска
                    string sub_word = "private";    //  Заменить на ...

                    source_line = "";  //  Исходный код

                    sr = new StreamReader(file_name);
                    sw = new StreamWriter(file_name + "mutation",true);

                    while (source_line != null)
                    {
                        source_line = sr.ReadLine();
                        source_line = source_line.Replace(search_word, sub_word);
                        sw.WriteLine(source_line);
                    }

                    sr.Close(); sw.Close();

                    File.Move(file_name + "mutation", file_name, true); //  Перезапись файла исходника мутированным

                    break;

                case "2":   // Строчные 's' заменить на прописные 'S'

                    source_line = "";  //  Исходный код
                    mutation_line = "";  // Мутация кода

                    sr = new StreamReader(file_name);
                    sw = new StreamWriter(file_name + "mutation",true);


                    while (source_line != null)
                    {
                        source_line = sr.ReadLine();

                        bool first_word = true; //  Первое слово?

                        char separator = ' ';  //  Разделитель слов - пробел

                        foreach(string word in source_line.Split(separator))
                        {
                            string new_word="";
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

                    break;

            }

                
        }

        //static string WordReplace(string source_line, string search_word, string sub_word)
        //{
        //    source_line = source_line.Replace(sea);
            
        //}
    }

}

//Прочитать текст C#-программы (выбрать самостоятельно);
//-   все слова public в объявлении полей классов заменить на слово private
//-    В исходном коде в каждом слове длиннее двух символов все строчные символы заменить прописными.
//-    Также в коде программы удалить все «лишние» пробелы и табуляции,
//    оставив только необходимые для разделения операторов.
//-   Записать символы каждой строки программы в другой файл в обратном порядке.