using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_CSharp_2021_04_21
{
    public enum Type_by_destination
    {
        Type1, Type2, Type3
    }
    public class Сhair:Furniture
    {
        //  Класс Стул

        public string _material ;   //  Материал обивки
        public Type_by_destination Type;   //  Тип стула по назначению (барный, офисный, гостинный и т.д.)
        public bool _transformation;   //  Возможность складывания

    }
}
