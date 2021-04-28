using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenUtensils
{
    public enum TypeSpoon
    {
        Table, Dessert, Tea, Coctail
        // Ложка столовая, Ложка десертная, Ложка чайная, Ложка коктейльная
    }

    public class Spoon : Silverware
    {
        //  Класс ложка
        public TypeSpoon _type { get; set;}
    }
}
