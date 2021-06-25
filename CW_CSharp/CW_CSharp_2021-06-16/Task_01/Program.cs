using System;
using System.IO;

/*
 Задание.
Вывести на экран в цвете в консоли информацию о дисках
(имя диска, полный размер, размер доступный для записи),

также вывести список файлов в корне диска и папок там же.

Размер выводить в Gb или Mb или Kb или  b в зависимости от ситуации.

Выводить папки и файлы разными цветами: картинки - красным, исполняемые файлы - зелёным, системные и служебные - синим, папки - серым.
*/

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            var disks = DriveInfo.GetDrives();

            Console.WriteLine("|\tимя диска\t|\tполный размер\t|\tразмер доступный для записи\t|");

            foreach (var disk in disks)
            {


                string  diskSize;
                string diskSizeWrite;

                Console.WriteLine("|\tимя диска\t|\tполный размер\t|\tразмер доступный для записи\t|");

                switch (disk.TotalSize)
                {
                    case < 1024:
                        //B
                        diskSize = (double)disk.TotalSize + " B";
                        break;
                    case >= 1024 and < 1048576:
                        //KB
                        diskSize = (double)(disk.TotalSize / 1024) + " KB";
                        break;
                    case >= 1048576 and < 1073741824:
                        //MB
                        diskSize = (double)(disk.TotalSize / 1048576) + " MB";
                        break;
                    //case >= 1073741824 and < 1.1e+12:
                    default:
                        //GB
                        diskSize = (double)(disk.TotalSize / 1073741824) + " GB";
                        break;
                        ////TB
                        //diskSize = (double)(disk.TotalSize / 1.1e+12) + " TB";
                }

                switch (disk.TotalFreeSpace)
                {
                    case < 1024:
                        //B
                        diskSizeWrite = (double)disk.TotalFreeSpace + " B";
                        break;
                    case >= 1024 and < 1048576:
                        //KB
                        diskSizeWrite = (double)(disk.TotalFreeSpace / 1024) + " KB";
                        break;
                    case >= 1048576 and < 1073741824:
                        //MB
                        diskSizeWrite = (double)(disk.TotalFreeSpace / 1048576) + " MB";
                        break;
                    //case >= 1073741824 and < 1.1e+12:
                    default:
                        //GB
                        diskSizeWrite = (double)(disk.TotalFreeSpace / 1073741824) + " GB";
                        break;
                        ////TB
                        //diskSizeWrite = (double)(disk.TotalFreeSpace / 1.1e+12) + " TB";
                        //break;
                }

                Console.WriteLine($"|\t{disk.Name}\t|\t{diskSize}\t|\t{diskSizeWrite}\t|");


                var rootPath = disk.RootDirectory.ToString();
                Console.WriteLine("-----\tПапки\t-----");
                Console.ForegroundColor = ConsoleColor.Gray;
                var dirs = Directory.GetDirectories(rootPath);
                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);
                }

                Console.WriteLine("-----\tФайлы\t-----");
                Console.ResetColor();

                //string fileType;

                var files = Directory.GetFiles(rootPath);
                foreach (var file in files)
                {
                    string []fileWords = file.Split('.');
                    string fileType = fileWords[fileWords.Length - 1];
 
                    switch (fileType)
                    {
                        case "exe":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        
                        case "jpg":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "sys":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                    }
                    Console.WriteLine(file);

                    Console.ResetColor();
                }
            }
        }
    }
}
