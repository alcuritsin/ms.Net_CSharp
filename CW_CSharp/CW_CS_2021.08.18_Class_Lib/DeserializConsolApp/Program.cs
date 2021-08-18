using ClassLib;

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main()
        {
            ShowConsole(":: Computers      ::");
            ShowConsole(":: Deserializ ALL ::");
            List < PC > computers = new List<PC>(3);
            DeserializAllPC("D:\\listSerial.txt", ref computers);

            foreach (PC computer in computers)
            {
                computer.RegistrHandler(new PC.PCStateHandler(ShowConsole));
                computer.info();
            }

            ShowConsole(":: Deserializ One ::");

            PC compDes = new PC();

            DeserializPC("D:\\Lenovo_01.txt", ref compDes);

            //compDes.RegistrHandler(new PC.PCStateHandler(ShowConsole));
            compDes._del = ShowConsole;
            compDes.info();

            ShowConsole("Programm complite");
            Console.ReadKey();
        }
        private static void ShowConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void DeserializAllPC(string path, ref List<PC> computers)
        {
            //  XML - Deserialize to List
            XmlSerializer xml_formatter = new XmlSerializer(typeof(List<PC>));

            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                computers = (List<PC>)xml_formatter.Deserialize(file_xml);
            }
            ShowConsole("DeserializAllPC is done");
        }
        public static void DeserializPC(string path, ref PC computer)
        {
            //  XML - Deserialize to List
            XmlSerializer xml_formatter = new XmlSerializer(typeof(PC));

            using (FileStream file_xml = new FileStream(path, FileMode.OpenOrCreate))
            {
                computer = (PC)xml_formatter.Deserialize(file_xml);
            }
            ShowConsole("DeserializAllPC is done");
        }


    }
}
