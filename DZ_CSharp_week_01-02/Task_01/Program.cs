using System;

namespace Task_01
{
    class Program
    {
        static void Main()
        {
            //  Класс Lighter - Зажигалка 
            Console.WriteLine("Класс Lighter - Зажигалка");

            Lighter lighter_ZP001 = new Lighter();
            lighter_ZP001.Article = "ZP001";
            lighter_ZP001.Brand = "Zippo";
            lighter_ZP001.MadeIn = "USA";
            lighter_ZP001.TypeAction = TypeAction.Petrol;
            lighter_ZP001.WidthInCM = 4.0;
            lighter_ZP001.HeightInCM = 7.0;
            lighter_ZP001.ThicnessInCM = 0.8;
            lighter_ZP001.Material = Material.Metal;
            lighter_ZP001.Color = "золото, с печатью";
            lighter_ZP001.ImageLink = "/ing/img_ZP001.png";
            lighter_ZP001.Price = 1500.0;

            Lighter lighter_ZP002 = new Lighter();
            lighter_ZP002.Article = "ZP002";
            lighter_ZP002.Brand = "Zippo";
            lighter_ZP002.MadeIn = "USA";
            lighter_ZP002.TypeAction = TypeAction.Petrol;
            lighter_ZP002.WidthInCM = 4.0;
            lighter_ZP002.HeightInCM = 7.0;
            lighter_ZP002.ThicnessInCM = 0.8;
            lighter_ZP002.Material = Material.Metal;
            lighter_ZP002.Color = "серебро, с печатью";
            lighter_ZP002.ImageLink = "/ing/img_ZP002.png";
            lighter_ZP002.Price = 1600.0;

            Lighter lighter_CH001 = new Lighter();
            lighter_CH001.Article = "CH001";
            lighter_CH001.Brand = "Пятёрочка";
            lighter_CH001.MadeIn = "China";
            lighter_CH001.TypeAction = TypeAction.Gas;
            lighter_CH001.WidthInCM = 2.5;
            lighter_CH001.HeightInCM = 8.0;
            lighter_CH001.ThicnessInCM = 1.0;
            lighter_CH001.Material = Material.Plastic;
            lighter_CH001.Color = "красный";
            lighter_CH001.ImageLink = "/ing/img_CH001.png";
            lighter_CH001.Price = 1700.0;

            lighter_ZP001.InfoInConsole();
            lighter_ZP002.InfoInConsole();
            lighter_CH001.InfoInConsole();
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