using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public enum TypeAction
    {
        //  Тип источника горения
        Electronic,     //  Электронный
        Petrol,         //  Бензиновый
        Gas             //  Газовая
    }
    public enum Material
    {
        //  Материалы корпуса
        Metal,  // Металл
        Plastic //  Пластик
    }
    partial class Lighter
    {
        //  Информация о бренде
        public string Article { get; set; } //  Артикул номер как у производителя (может принимать буквы)
        public string Brand { get; set; }   //  Производитель
        public string MadeIn { get; set; }  //  Страна производства

        //  Технические храктеристики
        public TypeAction TypeAction { get; set; }  //  Тип источника горения
        public double WidthInCM { get; set; }   //  Ширина в сантиметрах
        public double HeightInCM { get; set; }   //  Высота в сантиметрах
        public double ThicnessInCM { get; set; }   //  Толщина в сантиметрах
        public Material Material { get; set; }    //  Материал корпуса
        public string Color {get;set;}  //   Расцветка

        //  Прайс / каталог
        public string ImageLink { get; set; }   //  Ссылка на картинку
        public double Price { get; set; }   // Цена

        //  Methods:
        public partial void InfoInConsole();
    }
}
