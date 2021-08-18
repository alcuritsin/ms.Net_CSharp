using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User
                {
                    Name = "Andrey",
                    Age = 35,
                    Phones = new List<string>
                    {
                        "+79042144491",
                        "2575755"
                    }
                },
                new User
                {
                    Name = "Anna",
                    Age = 20,
                    Phones = new List<string>
                    {
                        "+79042144491",
                        "2575755"
                    }
                }
            };


            var xmlSerializer = new XmlSerializer(typeof(List<User>));
            //using (var fileXmlOutput = new FileStream("user.xml", FileMode.OpenOrCreate))
            using (var fileXmlOutput = new FileStream("user.xml", FileMode.Truncate))
            {
                xmlSerializer.Serialize(fileXmlOutput, users);
            }


            //using (var fileJsonOutput = new FileStream("user.json", FileMode.OpenOrCreate))
            using (var fileJsonOutput = new FileStream("user.json", FileMode.Truncate))
            {
                JsonSerializer.SerializeAsync(fileJsonOutput, users);
            }

            var xmlDeserializer = new XmlSerializer(typeof(List<User>));
            using var fileXmlInput = new FileStream("user.xml", FileMode.Open);
            var usersXml = (List<User>)xmlDeserializer.Deserialize(fileXmlInput);

            using var fileJsonInput = new FileStream("user.json", FileMode.Open);
            var usersJson = JsonSerializer.DeserializeAsync<List<User>>(fileJsonInput).Result;

            PrintUsers(users, "Исходные данные: ");
            PrintUsers(usersXml, "Десериализованные данные из XML: ");
            PrintUsers(usersJson, "Десериализованные данные из JSON: ");
        }

        static void PrintUsers(List<User> users, string message)
        {
            Console.WriteLine(message);
            foreach (var user in users)
            {
                PrintUser(user);
            }
        }

        static void PrintUser(User user)
        {
            Console.Write($"{user.Name}, {user.Age}");
            foreach (var phone in user.Phones)
            {
                Console.Write($" {phone} ");
            }
            Console.WriteLine();
        }
    }
}