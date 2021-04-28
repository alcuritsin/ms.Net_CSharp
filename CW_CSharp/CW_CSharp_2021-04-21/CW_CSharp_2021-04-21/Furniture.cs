using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_CSharp_2021_04_21
{
    public class Furniture
    {
        //  Класс мебель
        private int _id;    //  Артикул

        public int _width { get; set; } //  Ширина
        public int _depth { get; set; } //  Глубина
        public int _height { get; set; } // Высота

        private string _colections; //  Колекция (набор) медбели...
        private string _color;  //  Цвет
        private string _brand;  //  Бренд
    }
}
