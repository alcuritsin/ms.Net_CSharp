using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenUtensils
{
    public class Kit:Silverware
    {
        //  Класс Набор
        public Fork _fork { get; set; } //  Объект класса Вилка
        public Spoon _spoon { get; set; }   //  Объект класса Ложка
        public Knife _knife { get; set; }   //  Объект класса Нож
        public int _person { get; set; }    //  Количество персон.
    }
}
