using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    partial class Lighter
    {
        public partial void InfoInConsole()
        {
            Console.WriteLine("***   info >>");
            Console.WriteLine($"Артикул: {this.Article}");
            Console.WriteLine("Информация о бренде:");
            Console.WriteLine($"Производитель: {this.Brand}\tСтрана: {this.MadeIn}");
            Console.WriteLine("Техническая информация:");

            string type_action = "";
            switch (this.TypeAction)
            {
                case TypeAction.Gas:
                    type_action = "Газовая";
                    break;
                case TypeAction.Petrol:
                    type_action = "Бензиновая";
                    break;
                case TypeAction.Electronic:
                    type_action = "Электрическая";
                    break;
                default:
                    break;
            }

            Console.Write($"Тип: {type_action}\tW: {this.WidthInCM}\tH: {this.HeightInCM}\tT: {this.ThicnessInCM}\t");

            string material = "";
            switch (this.Material)
            {
                case Material.Metal:
                    material = "Металл";
                    break;
                case Material.Plastic:
                    material = "Пластик";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Материал: {material}\tЦвет: {this.Color}");
            Console.WriteLine("Информация для каталога:");
            Console.WriteLine($"Изображение: {this.ImageLink}\tЦена: {this.Price}");
        }
    }
}
