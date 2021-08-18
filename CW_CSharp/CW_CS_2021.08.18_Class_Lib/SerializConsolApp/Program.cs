using ClassLib;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializConsolApp
{
    class Program
    {
        static void Main()
        {
            ShowConsole(":: Computers ::");
            ShowConsole(":: Serializ All ::");
            // Создаём переменную
            List<PC> computers = new List<PC>(3);
            
            //  Заполняем
            computers.Add(new PC("Lenovo", "01", "4Gb", "nVidia GT1080 2Gb"));
            computers.Add(new PC("Acer", "02", "8Gb", "nVidia GT1080Ti 4Gb"));
            computers.Add(new PC("Asus", "03", "4Gb", "IntelHD 2Gb"));
            computers.Add(new PC("Sony", "04", "16Gb", "nVidia GT1080 2Gb"));
            computers.Add(new PC("HP", "05", "8Gb", "nVidia GT2080 2Gb"));

            SerializAllPC("D:\\listSerial.txt", ref computers);

            ShowConsole("\n:: Serializ one ::");

            foreach (PC computer in computers)
            {
                SerializPC("D:\\" + computer.Brand + "_" + computer.SerialNumber +".txt", computer); // тут
            }

            ShowConsole("Programm complite");
            Console.ReadKey();
        }

        private static void ShowConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void SerializAllPC(string path, ref List<PC> computers)
        {
            if (File.Exists(path))
            {
                ShowConsole($"Файл с именем {path} уже существует.\nОн будет перезаписан.");
            }
            //  XML - Serializer from List
            XmlSerializer xml = new XmlSerializer(typeof(List<PC>));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(file_xml, computers);
            }
            ShowConsole("SerializAllPC is done");
        }
        public static void SerializPC(string path, PC computer)
        {
            if (File.Exists(path))
            {
                ShowConsole($"Файл с именем {path} уже существует.\nОн будет перезаписан.");
            }
            //  XML - Serializer from List
            XmlSerializer xml = new XmlSerializer(typeof(PC));
            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(file_xml, computer);
            }
            ShowConsole($"SerializPC {path} is done.");
        }
    }

}
